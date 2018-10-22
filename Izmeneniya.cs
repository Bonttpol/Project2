using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Windows.Forms;
using Google.Apis.Util.Store;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;

namespace Курсовой2
{
    public partial class Izmeneniya : Form
    {
        int sheet;
        SheetsService service;
        string Klub;

        public Izmeneniya(bool checAB, bool checZ)
        {
            InitializeComponent();
            if (checAB == true) { Klub = AndrB; sheet = ABsid; };
            if (checZ == true) {Klub = Zebra; sheet = Zsid; };

            Zapolnenie(Klub);
        }
        //################################ Доступ к Google Drive ################################
        private static string ClientSecret = "keykey.json";
        private static string ApplicationName = "Kurs";
        private static readonly string[] ScopesSheets = { SheetsService.Scope.Spreadsheets };
        private static readonly string SpredsheetsID = "1W1KGfK6YoVjo45H8HOCYQ7O9R5VRJcZZU9_DRU8FdCM";
        private const string AndrB = "'Андрей Боголюбский'!A3:C";
        private const string Zebra = "'Зебра'!A3:C";
        private const int ABsid = 1675588482;
        private const int Zsid = 1330079340;
        
        public static UserCredential GetSheetCredetionals()
        {
            using (var stream = new FileStream(ClientSecret, FileMode.Open, FileAccess.Read))
            {
                var  creadPath = Path.Combine(Directory.GetCurrentDirectory(), "sheetcredentioals.json");

                return GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    ScopesSheets,
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

        public static List<string> GetFirstCell(SheetsService service, string SpreadSheetsID, string range)
        {
            SpreadsheetsResource.ValuesResource.GetRequest request = service.Spreadsheets.Values.Get(SpredsheetsID, range);
            ValueRange response = request.Execute();
            
            List<string> spis = new List<string>();
           
            foreach (var value in response.Values)
                spis.Add(value[0].ToString());
            return spis; 
        }

        public List<string> GetRow(int index)
        {
            SpreadsheetsResource.ValuesResource.GetRequest request = service.Spreadsheets.Values.Get(SpredsheetsID, Klub);
            ValueRange response = request.Execute();

            List<string> spis = new List<string>();
            int i = 0;
            foreach (var value in response.Values[index])
            {
                spis.Add(value.ToString());
                i++;
            }
            return spis;
        }

        public void DeletRow()
        {
            List<Request> request = new List<Request>();
            request.Add(
                new Request
                {
                    DeleteDimension = new DeleteDimensionRequest
                    {
                        Range = new DimensionRange
                        {
                            SheetId = sheet,
                            Dimension = "ROWS",
                            StartIndex = int.Parse(listBox_spis.SelectedIndex.ToString()) + 2,
                            EndIndex = int.Parse(listBox_spis.SelectedIndex.ToString()) + 3
                        }
                    }
                }
                );

            BatchUpdateSpreadsheetRequest busr = new BatchUpdateSpreadsheetRequest { Requests = request };
            service.Spreadsheets.BatchUpdate(busr, SpredsheetsID).Execute();
            MessageBox.Show("Выбранный ученик удален!");
        }

        //######################## Выгрузка информации из Диска ############################################ MAIN

        public void Zapolnenie(string Klub)
        {
            UserCredential credential = GetSheetCredetionals();
            service = GetService(credential);
            listBox_spis.Items.AddRange(GetFirstCell(service, SpredsheetsID, Klub).ToArray());
        }

        //##################################### Добавление новго ученика №№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№
        private void but_new_Click(object sender, EventArgs e)
        {
            if (izmenit.Checked ==true)
            {
                List<Request> request = new List<Request>();

                List<CellData> values = new List<CellData>();
                values.Add(new CellData { UserEnteredValue = new ExtendedValue { StringValue = Child_Surname.Text + " " + Child_name.Text } });
                values.Add(new CellData { UserEnteredValue = new ExtendedValue { StringValue = Child_otch.Text } });
                values.Add(new CellData { UserEnteredValue = new ExtendedValue { StringValue = Child_datar.Text } });

                request.Add(
                    new Request
                    {
                        UpdateCells = new UpdateCellsRequest
                        {
                            Start = new GridCoordinate
                            { SheetId = sheet, RowIndex = listBox_spis.SelectedIndex+2, ColumnIndex = 0 },
                            Rows = new List<RowData> { new RowData { Values = values } },
                            Fields = "userEnteredValue"
                        }
                    }
                    );
                BatchUpdateSpreadsheetRequest busr = new BatchUpdateSpreadsheetRequest { Requests = request };
                service.Spreadsheets.BatchUpdate(busr, SpredsheetsID).Execute();
                MessageBox.Show("Изменения внесени успешно!");
            }

            if (newchild.Checked==true)
            {
                List<Request> request = new List<Request>();

                List<CellData> values = new List<CellData>();
                values.Add(new CellData { UserEnteredValue = new ExtendedValue { StringValue = Child_Surname.Text + " " + Child_name.Text } });
                values.Add(new CellData { UserEnteredValue = new ExtendedValue { StringValue = Child_otch.Text } });
                values.Add(new CellData { UserEnteredValue = new ExtendedValue { StringValue = Child_datar.Text } });
                int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
                int dr = int.Parse(Convert.ToDateTime(Child_datar.Text).ToString("yyyyMMdd"));
                int age = (now - dr) / 10000;
                values.Add(new CellData { UserEnteredValue = new ExtendedValue { StringValue = age.ToString()} });

                request.Add(
                    new Request
                    {
                        UpdateCells = new UpdateCellsRequest
                        {
                            Start = new GridCoordinate
                            { SheetId = sheet, RowIndex = listBox_spis.Items.Count + 2, ColumnIndex = 0 },
                            Rows = new List<RowData> { new RowData { Values = values } },
                            Fields = "userEnteredValue"
                        }
                    }
                    );
                BatchUpdateSpreadsheetRequest busr = new BatchUpdateSpreadsheetRequest { Requests = request };
                service.Spreadsheets.BatchUpdate(busr, SpredsheetsID).Execute();
                MessageBox.Show("Новый ученик успешно дабавлен!");
            }
        }

        //№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№ Действие при Checked_Change #######################
        private void newchild_CheckedChanged(object sender, EventArgs e)
        {
            if (groupBox_new.Enabled == false)
                groupBox_new.Enabled = true;
            else groupBox_new.Enabled = false;

            Child_datar.Text = "Дата рождения";
            Child_otch.Text = "Отчество";
            Child_name.Text = "Имя";
            Child_Surname.Text = "Фамилия";
        }

        private void izmenit_CheckedChanged(object sender, EventArgs e)
        {
            if (listBox_spis.Enabled == false)
                listBox_spis.Enabled = true;
            else listBox_spis.Enabled = false;
        }

        private void Delet_CheckedChanged(object sender, EventArgs e)
        {
            if (listBox_spis.Enabled == false)
                listBox_spis.Enabled = true;
            else listBox_spis.Enabled = false;
        }

        private void listBox_spis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (izmenit.Checked == true)
            {
                if (groupBox_new.Enabled == false)
                    groupBox_new.Enabled = true;
                else groupBox_new.Enabled = false;

                List<string> row = GetRow(int.Parse(listBox_spis.SelectedIndex.ToString()));

                Child_datar.Text = row[2];
                Child_otch.Text = row[1];
                Child_name.Text = row[0].Split(char.Parse(" "))[1];
                Child_Surname.Text = row[0].Split(char.Parse(" "))[0];
            }

            if (Delet.Checked == true)
                DeletRow();
        }
    }
}

