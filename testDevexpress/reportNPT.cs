using Microsoft.Data.SqlClient;
using System.Data;
using DevExpress.XtraPrinting.HtmlExport.Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace testDevexpress
{
    public partial class reportNPT : DevExpress.XtraEditors.XtraForm
    {



        private readonly DatabaseHelper _db;
        private string _lastSearchText = "";
        private DateTime _lastSearchTime = DateTime.MinValue;

        public reportNPT()
        {
            InitializeComponent();

            _db = new DatabaseHelper();

            this.Load += ReportNPT_Load;
        }


        //временная переменная отвечаютщая за периоды  /////////////////Временно КОНЕЦ\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        private DataTable _periodsTable;

        private void ReportNPT_Load(object sender, EventArgs e)
        {
            // Пример данных – можно потом заменить на загрузку из БД           \\\\\\\\\ВРЕМЕННО(формирование подразделений/////////////
            var departments = new List<string>
                {
                    "Бухгалтерия",
                    "Отдел кадров",
                    "IT отдел",
                    "Маркетинг",
                    "Продажи",
                    "Склад",
                    "Производство",
                    "Безопасность",
                    "Юридический отдел",
                    "Финансы",
                    "Поддержка клиентов",
                    "Развитие",
                    "Логистика",
                    "Закупки",
                    "Администрация"
                };

            checkedListDepartments.Items.AddRange(departments.ToArray());

            /////////////////Временно КОНЕЦ\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

            /////////////////Временно (формироввание периодов)\\\\\\\\\\\\\\\\\\\\\\\\\\\\\


            // Настраиваем ComboBoxEdit
            comboPeriodicity.Properties.Items.AddRange(new[] { "День", "Неделя", "Месяц", "Год" });
            comboPeriodicity.SelectedIndex = 0;

            // Настраиваем таблицу DataTable
            _periodsTable = new DataTable();
            _periodsTable.Columns.Add("Дата начала", typeof(DateTime));
            _periodsTable.Columns.Add("Дата конца", typeof(DateTime));
            _periodsTable.Columns.Add("Периодичность", typeof(string));



            // Привязываем таблицу к GridControl
            gridPeriods.DataSource = _periodsTable;

            // Настраиваем внешний вид
            gridViewPeriods.OptionsBehavior.Editable = false;
            gridViewPeriods.OptionsView.ShowGroupPanel = false;

            /////////////////Временно (формироввание периодов) КОНЕЦ\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

            //LoadNomenclatureNames();
        }

        private void LoadNomenclatureNames()
        {
            try
            {
                using (var connection = _db.GetConnection())
                {
                    connection.Open();
                    Console.WriteLine("Подключение успешно!");

                    string query = "SELECT top 10 Name FROM dbo.Nomenclature"; // берем первые 10 для теста
                    using (var cmd = new SqlCommand(query, connection))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MessageBox.Show(reader["Name"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void btnAddNomenclature_Click(object sender, EventArgs e)
        {

        }


        // код под выбор подразделений 


        // код для выбора периода/переодичности

        private void BtnAddPeriod_Click(object sender, EventArgs e)
        {
            if (dateStartEdit.EditValue == null || dateEndEdit.EditValue == null)
            {
                XtraMessageBox.Show("Укажите даты начала и конца!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime startDate = (DateTime)dateStartEdit.EditValue;
            DateTime endDate = (DateTime)dateEndEdit.EditValue;
            string periodicity = comboPeriodicity.Text;

            if (endDate < startDate)
            {
                XtraMessageBox.Show("Дата конца не может быть раньше даты начала!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _periodsTable.Rows.Add(startDate, endDate, periodicity);
        }

        // Метод для получения данных из таблицы
        public List<(DateTime Start, DateTime End, string Periodicity)> GetPeriods()
        {
            return _periodsTable.AsEnumerable()
                .Select(row => (
                    Start: row.Field<DateTime>("Дата начала"),
                    End: row.Field<DateTime>("Дата конца"),
                    Periodicity: row.Field<string>("Периодичность")
                ))
                .ToList();
        }



        // код для формирования отчёта 
        private void BtnGenerateReport_Click(object sender, EventArgs e)
        {
            
        }
    }
}
