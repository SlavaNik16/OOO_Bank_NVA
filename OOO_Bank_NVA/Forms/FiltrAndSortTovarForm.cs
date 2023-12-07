using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using OOO_Bank_NVA.Colors;
using OOO_Bank_NVA.DB;
using OOO_Bank_NVA.DB.ReadDB;
using OOO_Bank_NVA.ModelsResponce;
using OOO_Bank_NVA.Nuget;
using System.Collections.Generic;
using System.ComponentModel.Composition.Primitives;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OOO_Bank_NVA.Forms
{
    public partial class FiltrAndSortTovarForm : MaterialForm
    {
        private DbContextOptions<DB.ApplicationContext> options;
        public FiltrAndSortTovarForm()
        {
            InitializeComponent();
            options = DataBaseHelper.Options();
            DataGridReset();
            listBoxSort.SelectedIndex = 0;
            ColorsHelp.ButtonSubmit(butSearch);
            ColorsHelp.ButtonSubmit(butExport);
            ColorsHelp.ButtonSubmit(butFiltr);

        }
        public DataGridView GetDataGridView()
            =>dataGridViewTovar;
        
        private IEnumerable<TovarResponce> GetTovarList()
        {
            var list = new List<TovarResponce>();
            using (var db = new DB.ApplicationContext(options))
            {
                list = db.Tovars.AsNoTracking().NotDeletedAt().OrderBy(x => x.Title).Select(x => new TovarResponce
                {
                    Id = x.Id,
                    MaxCount = x.MaxCount,
                    Price = x.Price,
                    Title = x.Title,
                    Description = x.Description,
                    Photo = x.Photo,
                }).ToList();
            }
            return list;
        }
        private void DataGridReset()
        {
            dataGridViewTovar.DataSource = GetTovarList();
        }
        private void butSort_Click(object sender, System.EventArgs e)
        {
            if (listBoxSort.SelectedIndex >= 0)
            {
                var list = GetTovarList();
                using (var db = new DB.ApplicationContext(options))
                {
                    switch (dataGridViewTovar.Columns[listBoxSort.SelectedIndex+1].DataPropertyName)
                    {
                        case "Title":
                            list = radioAsc.Checked ? list.OrderBy(x => x.Title).ToList() : list.OrderByDescending(x => x.Title).ToList();
                            break;
                        case "Price":
                            list = radioAsc.Checked ? list.OrderBy(x => x.Price).ToList() : list.OrderByDescending(x => x.Price).ToList();
                            break;
                        case "MaxCount":
                            list = radioAsc.Checked ? list.OrderBy(x => x.MaxCount).ToList() : list.OrderByDescending(x => x.MaxCount).ToList();
                            break;
                    }

                    dataGridViewTovar.DataSource = list;
                }
            }
        }

        private void butViewAll_Click(object sender, System.EventArgs e)
        {
            DataGridReset();
        }

        private void butSearch_Click(object sender, System.EventArgs e)
        {
            var isSearch = false;
            for (int i = 0; i < dataGridViewTovar.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridViewTovar.RowCount; j++)
                {
                    dataGridViewTovar[i, j].Style.BackColor = Color.FromArgb(255, 255, 251, 217);
                    dataGridViewTovar[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < dataGridViewTovar.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewTovar.ColumnCount; j++)
                {
                    if (dataGridViewTovar.Rows[i].Cells[j].Value.ToString().Contains(searchBox.Text))
                    {
                        isSearch = true;
                        dataGridViewTovar.Rows[i].Cells[j].Style.BackColor = Color.AliceBlue;
                        dataGridViewTovar.Rows[i].Cells[j].Style.ForeColor = Color.Blue;
                    }
                }
            }
            if (!isSearch)
            {
                MessageBox.Show("Ничего не найдено!");
            }
        }

        private void searchBox_TextChanged(object sender, System.EventArgs e)
        {
            butSearch.Enabled =
               !string.IsNullOrWhiteSpace(searchBox.Text);
        }

        private void butExport_Click(object sender, System.EventArgs e)
        {
            Nuget.Export.CreateExcelSheet(dataGridViewTovar, "Список товаров");
        }

        private void priceBox_TextChanged(object sender, System.EventArgs e)
        {
            butFiltr.Enabled =
               !string.IsNullOrWhiteSpace(priceBox.Text);
        }

        private void butFiltr_Click(object sender, System.EventArgs e)
        {
            var list = GetTovarList();
            dataGridViewTovar.DataSource=list.Where(x => x.Price >= int.Parse(priceBox.Text)).ToList();
        }

        private void priceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}
