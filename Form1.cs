using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using Excel = Microsoft.Office.Interop.Excel;


namespace Курсовой2
{
    public partial class Osnova : Form
    {
        public Osnova()
        {
            InitializeComponent();
        }

        private void but_tell_Click(object sender, EventArgs e)
        {
            if (check_AB.Checked == false && check_Z.Checked == false)
            {
                MessageBox.Show("Не выбран клуб!");
                return;
            }
            this.Size = new Size(410, 480);
            Excel.Application ObjWorkExcel = new Excel.Application(); //открыть эксель
            Excel.Workbook ObjWorkBook = ObjWorkExcel.Workbooks.Open("C:\\Users\\uzer\\Downloads\\Телефон.xlsx");
            int nombersheet = 0;
            if (check_AB.Checked == true) nombersheet = 1;
            if (check_Z.Checked == true) nombersheet = 2;
            Excel.Worksheet ObjWorkSheet = (Excel.Worksheet)ObjWorkBook.Sheets[nombersheet]; // получить лист соотвествующий клубу
            var lastCell = ObjWorkSheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell);//1 ячейку
            string[] list = new string[lastCell.Row]; // массив значений с листа равен по размеру листу
            for (int i = 0; i < 1; i++) //по всем колонкам
                for (int j = 0; j < lastCell.Row; j++) // по всем строкам
                {
                    if (ObjWorkSheet.Cells[j + 1, i + 1].Text.ToString() == null) break;
                    list[j] = ObjWorkSheet.Cells[j + 1, i + 1].Text.ToString();//считываем текст в строку
                }
            ObjWorkBook.Close(false, Type.Missing, Type.Missing); //закрыть не сохраняя
            ObjWorkExcel.Quit(); // выйти из экселя
            vvodFIO.AutoCompleteCustomSource.AddRange(list);
            GC.Collect();
        }

        private void okFIO_Click(object sender, EventArgs e)
        {
            Excel.Application ObjWorkExcel = new Excel.Application();
            Excel.Workbook ObjWorkBook = ObjWorkExcel.Workbooks.Open("C:\\Users\\uzer\\Downloads\\Телефон.xlsx");
            int nombersheet = 0;
            if (check_AB.Checked == true) nombersheet = 1;
            if (check_Z.Checked == true) nombersheet = 2;
            Excel.Worksheet ObjWorkSheet = (Excel.Worksheet)ObjWorkBook.Sheets[nombersheet];
            var lastCell = ObjWorkSheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell);
            string[,] list = new string[lastCell.Column, lastCell.Row];
            int index = 0;
            for (int i = 0; i < lastCell.Column; i++)
                for (int j = 0; j < lastCell.Row; j++)
                {
                    if (ObjWorkSheet.Cells[j + 1, i + 1].Text.ToString() == vvodFIO.Text)
                        index = j;
                    list[i, j] = ObjWorkSheet.Cells[j + 1, i + 1].Text.ToString();
                }
            Rezult.Text = list[1, index] + ' ' + list[2, index];

            ObjWorkBook.Close(false, Type.Missing, Type.Missing);
            ObjWorkExcel.Quit();
            GC.Collect();
        }

        // ################################# Изменение размера для доступа к новым элементам
        private void but_redact_Click(object sender, EventArgs e)
        {
            if (check_AB.Checked == false && check_Z.Checked == false)
                {
                MessageBox.Show("Не выбран клуб!");
                return;
            }
            Izmeneniya one = new Izmeneniya(check_AB.Checked, check_Z.Checked);
            one.ShowDialog();
        }
    }
}
