using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using Google.Apis.Drive.v2;
using Google.Apis.Download;

namespace Курсовой2
{
    public partial class Zayavka : Form
    {
        string Klub;

        SheetsService service;
        public Zayavka(bool checAB, bool checZ)
        {
            InitializeComponent();
            if (checAB == true) Klub = "'Андрей Боголюбский'!A3:F"; 
            if (checZ == true)  Klub = "'Зебра'!A3:F";
            Zapolnenie(Klub);
        }

        //################################ Google Drive #########################################################
        private static string ClientSecret = "keykey.json";
        private static string ApplicationName = "Kurs";
        private static string[] Scopes = { DriveService.Scope.Drive };
        private static readonly string[] ScopesSheets = { SheetsService.Scope.Spreadsheets };
        private static readonly string SpredsheetsID1 = "1DyIr0-PxTC-B4vrcH7aqbEE3d8R31fI5mf7PeeBq3OI";
        private static readonly string SpredsheetsID = "1W1KGfK6YoVjo45H8HOCYQ7O9R5VRJcZZU9_DRU8FdCM";
        private const string ZayavSH = "'Заявка'!A14:A";
        private const int Zayav = 1275989775;


        public static UserCredential GetSheetCredetionals()
        {
            using (var stream = new FileStream(ClientSecret, FileMode.Open, FileAccess.Read))
            {
                var creadPath = Path.Combine(Directory.GetCurrentDirectory(), "sheetcredentioals.json");

                return GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    ScopesSheets,
                    "User",
                    CancellationToken.None,
                    new FileDataStore(creadPath, true)).Result;
            }
        }

        public static UserCredential GetUserCredential()
        {
            using (var stream = new FileStream("keykey.json", FileMode.Open, FileAccess.Read))
            {
                string creadPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                creadPath = Path.Combine(creadPath, "driveApiCredentials", "drive-sredentials.json");

                return GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "User",
                    CancellationToken.None,
                    new FileDataStore(creadPath, true)).Result;
            }
        }

        public static SheetsService GetService(UserCredential credential)
        {
            return new SheetsService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName
            }
            );
        }

        private static DriveService GetDriveService(UserCredential credential)
        {
            return new DriveService(
                new BaseClientService.Initializer
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName
                });
        }

        public static List<IList<object>> GetFirstCell(SheetsService service, string SpreadSheetsID, string range)
        {
            SpreadsheetsResource.ValuesResource.GetRequest request = service.Spreadsheets.Values.Get(SpreadSheetsID, range);
            ValueRange response = request.Execute();

            List<IList<object>> spis = new List<IList<object>>();
            try
            {
                foreach (var value in response.Values)
                    spis.Add(value);
            }
            catch (NullReferenceException)
            {
                return spis;
            }
            return spis;
        }

        public void FillNew(int row, int column, string text1)
        {
            List<Request> request = new List<Request>();

            List<CellData> values = new List<CellData>();
            values.Add(new CellData { UserEnteredValue = new ExtendedValue { StringValue = text1 } });

            request.Add(
                new Request
                {
                    UpdateCells = new UpdateCellsRequest
                    {
                        Start = new GridCoordinate
                        { SheetId = Zayav, RowIndex = row, ColumnIndex = column },
                        Rows = new List<RowData> { new RowData { Values = values } },
                        Fields = "userEnteredValue"
                    }
                }
                );

            BatchUpdateSpreadsheetRequest busr = new BatchUpdateSpreadsheetRequest { Requests = request };
            service.Spreadsheets.BatchUpdate(busr, SpredsheetsID1).Execute();
        }

        private static void NEWROW(SheetsService service, int count)
        {
            List<Request> request = new List<Request>();

            request.Add(
                new Request
                {
                    InsertRange = new InsertRangeRequest
                    {
                        Range = new GridRange
                        {
                            SheetId = Zayav,
                            StartRowIndex = 13,
                            EndRowIndex = 13+count
                        },
                        ShiftDimension = "ROWS"
                    }
                }
                );

            request.Add(
                new Request
                {
                    UpdateBorders = new UpdateBordersRequest
                    {
                        Range = new GridRange
                        {
                            SheetId = Zayav,
                            StartRowIndex = 12,
                            EndRowIndex = 13+count,
                            StartColumnIndex = 0,
                            EndColumnIndex = 17,
                        },
                        InnerHorizontal = new Border
                        {
                            Style = "SOLID",
                            Width = 1
                        },
                        InnerVertical = new Border
                        {
                            Style = "SOLID",
                            Width = 1
                        },
                        Bottom = new Border
                        {
                            Style = "SOLID",
                            Width = 2
                        }
                    }
                }
                );

            BatchUpdateSpreadsheetRequest busr = new BatchUpdateSpreadsheetRequest { Requests = request };
            service.Spreadsheets.BatchUpdate(busr, SpredsheetsID1).Execute();
        }

        private static void Clean(SheetsService service, int count)
        {
                List<Request> request = new List<Request>();
                request.Add(
                    new Request
                    {
                        DeleteDimension = new DeleteDimensionRequest
                        {
                            Range = new DimensionRange
                            {
                                SheetId = Zayav,
                                Dimension = "ROWS",
                                StartIndex = 13,
                                EndIndex = 13+count
                            }
                        }
                    }
                    );

                BatchUpdateSpreadsheetRequest busr = new BatchUpdateSpreadsheetRequest { Requests = request };
                service.Spreadsheets.BatchUpdate(busr, SpredsheetsID1).Execute();
        }

        private static void Download(string fileid, string Path)
        {
            UserCredential credential = GetUserCredential();
            DriveService service_d = GetDriveService(credential);
            var request = service_d.Files.Export(fileid, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
            var stream = new MemoryStream();
            request.MediaDownloader.ProgressChanged += (IDownloadProgress progress) =>
            {
                using (FileStream file = new FileStream(Path, FileMode.Create, FileAccess.Write))
                {
                    stream.WriteTo(file);
                }
            };
            request.Download(stream);
        }


        private void Gmail(string pass, string date, string Klub, List<string> names)
        {
            string path_file = "D:\\Заявка от клуба '" + Klub + "'.xlsx";
            Download(SpredsheetsID1, path_file);

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("bondareva-polina98@mail.ru"); // Адрес отправителя
            mail.To.Add(new MailAddress("bondareva-polina98@mail.ru")); // Адрес получателя
            mail.Subject = "Заявка на соревнования";
            mail.Body = "Заявка на соревнования " + date + " от клуба: " + Klub;
            mail.Attachments.Add(new Attachment(path_file));

            if (Svidetelstva.Checked == true)
                foreach (string n in names)
                    mail.Attachments.Add(new Attachment(@"C:\Users\bondareva_pa\Pictures\" + n + ".jpg"));

            SmtpClient client = new SmtpClient();
            client.Host = "smtp.mail.ru";
            client.Port = 465;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("bondareva-polina98@mail.ru", pass);
            try { client.Send(mail); }
            catch (SmtpException) { MessageBox.Show("Ошибка пароля или отпарвки!"); return; }
            MessageBox.Show("Заявка отпарвлена!");
        }

        //#################################### Логичкская часть ######################################

        private void Zapolnenie(string Klub)
        {
            UserCredential credential = GetSheetCredetionals();
            service = GetService(credential);

            List<string> name = new List<string>();
            foreach (var each in GetFirstCell(service, SpredsheetsID, Klub))
                name.Add(each[0].ToString());

            Spisok.Items.AddRange(name.ToArray());
        }

        private void but_print_Click(object sender, EventArgs e)
        {
            if (text_pass.Text == null)
            {
                MessageBox.Show("Не введен пароль");
                return;
            }
              
            Clean(service, GetFirstCell(service, SpredsheetsID1, ZayavSH).Count);

            FillNew(2, 4, text_date.Text); // date
            FillNew(4, 4, Klub.Split('!')[0]); // club
            FillNew(5, 4, text_city.Text); // city
            FillNew(6, 4, text_trener.Text); // coach
            FillNew(7, 4, text_pred.Text); // club's people
            FillNew(8, 4, text_sud.Text); // sud
            NEWROW(service, Spisok.CheckedIndices.Count);

            List<IList<object>> data = GetFirstCell(service, SpredsheetsID, Klub);
            int row = 13;
            int k = 1;

            foreach (var i in Spisok.CheckedIndices)
            {
                for (int j = 0; j < data.Count; j++)
                {
                    if (j == int.Parse(i.ToString()))
                    {
                        FillNew(row, 0, k.ToString());
                        FillNew(row, 2, data[j][0].ToString());
                        FillNew(row, 3, data[j][2].ToString());
                        FillNew(row, 4, data[j][5].ToString());
                        FillNew(row, 5, data[j][4].ToString());
                        FillNew(row, 8, "Ш");
                        FillNew(row, 11, "Ш");
                        FillNew(row, 13, Klub.Split('!')[0]);
                        FillNew(row, 14, text_city.Text);
                        FillNew(row, 15, text_trener.Text);

                        row++;
                        k++;
                    }
                }
            }

            List<string> Name = new List<string>();
            foreach (var i in Spisok.CheckedIndices)
                for (int j = 0; j < data.Count; j++)
                    if (j == int.Parse(i.ToString()))
                        Name.Add(data[j][0].ToString());

            Gmail(text_pass.Text, text_date.Text.ToString(), Klub.Split('!')[0], Name);


            text_date.Text = "";
            text_city.Text = "";
            text_trener.Text = "";
            text_pred.Text = "";
            text_sud.Text = "";
            text_pass.Text = "";
            Svidetelstva.Checked = false;
            foreach (int i in Spisok.CheckedIndices)
                Spisok.SetItemCheckState(i, CheckState.Unchecked);
        }
    }
}
