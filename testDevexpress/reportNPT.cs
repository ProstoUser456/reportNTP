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

        private void ReportNPT_Load(object sender, EventArgs e)
        {
            //LoadNomenclatureNames();

            // Настройка поискового элемента
            searchLookUpEdit1.Properties.NullText = "Введите название номенклатуры...";
            searchLookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            searchLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;

            // Подписка на изменение текста
            searchLookUpEdit1.TextChanged += SearchLookUpEdit1_TextChanged;

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

        private async void SearchLookUpEdit1_TextChanged(object sender, EventArgs e)
        {
            string text = searchLookUpEdit1.Text.Trim();

            // Не дергать базу слишком часто
            if (text == _lastSearchText) return;
            if ((DateTime.Now - _lastSearchTime).TotalMilliseconds < 500) return;

            _lastSearchText = text;
            _lastSearchTime = DateTime.Now;

            if (text.Length < 2)
            {
                // Не искать при коротком вводе
                searchLookUpEdit1.Properties.DataSource = null;
                return;
            }

            try
            {
                DataTable dt = new DataTable();
                using (var conn = _db.GetConnection())
                {
                    await conn.OpenAsync();

                    string query = @"
                    SELECT TOP 50 Name 
                    FROM dbo.Nomenclature 
                    WHERE Name LIKE @search + '%' 
                    ORDER BY Name";

                    MessageBox.Show("Запрос выполнен");

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@search", text);
                        using (var da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }

                searchLookUpEdit1.Properties.DataSource = dt;
                searchLookUpEdit1.Properties.DisplayMember = "Name";
                searchLookUpEdit1.Properties.ValueMember = "Id";
                searchLookUpEdit1.ShowPopup();
            }
            catch (Exception ex)
            {
               MessageBox.Show("Ошибка при поиске: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (searchLookUpEdit1.EditValue == null) return;

            string name = searchLookUpEdit1.Text;
            listBoxControl1.Items.Add(name);
        }
    }
}
