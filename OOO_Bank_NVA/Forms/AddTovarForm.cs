using MaterialSkin.Controls;
using Microsoft.IdentityModel.Tokens;
using OOO_Bank_NVA.Models;
using OOO_Bank_NVA.ModelsResponce;
using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using File = System.IO.File;

namespace OOO_Bank_NVA.Forms
{
    public partial class AddTovarForm : MaterialForm
    {
        private Tovar tovar;
        public AddTovarForm()
        {
            InitializeComponent();
            this.Text = "Добавление товара";
            tovar = new Tovar();
            CultureInfo culture = (CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            culture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = culture;
        }
        public AddTovarForm(TovarResponce tovarEdit) : this()
        {
            this.Text = "Изменение товара";
            tovar.Id = tovarEdit.Id;
            tovar.Title = tovarEdit.Title;
            tovar.MaxCount = tovarEdit.MaxCount;
            tovar.Price = tovarEdit.Price;
            tovar.Description = tovarEdit.Description;
            tovar.Photo = tovarEdit.Photo;

            textBoxTittle.Text = tovarEdit.Title;
            textBoxPrice.Text = tovarEdit.Price.ToString();
            numericUpDownCount.Value = tovarEdit.MaxCount;
            textBoxDesc.Text = tovarEdit.Description;
            if (!string.IsNullOrEmpty(tovarEdit.Photo))
            {
                pictureBoxTovar.Image = Bitmap.FromFile(tovarEdit.Photo);
            }
        }
        public Tovar Tovar => tovar;
        private async void pictureBoxTovar_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;
            string filename = openFileDialog.FileName;
            tovar.Photo = filename;
            pictureBoxTovar.Image = Bitmap.FromFile(filename);
            try
            {


                using (var client = new HttpClient())
                {
                    // адрес сервера
                    var serverAddress = "https://localhost:7097/upload";

                    // создаем MultipartFormDataContent
                    using (var multipartFormContent = new MultipartFormDataContent())
                    {
                        // Загружаем отправляемый файл
                        var fileStreamContent = new StreamContent(File.OpenRead(filename));
                        // Устанавливаем заголовок Content-Type
                        fileStreamContent.Headers.ContentType =
                                    MediaTypeHeaderValue.Parse(MimeMapping.GetMimeMapping(filename));
                        // Добавляем загруженный файл в MultipartFormDataContent
                        multipartFormContent.Add(fileStreamContent, name: "file", fileName: openFileDialog.SafeFileName);

                        // Отправляем файл
                        using (var response = await client.PostAsync(serverAddress, multipartFormContent))
                        {
                            // считываем ответ
                            var responseText = await response.Content.ReadAsStringAsync();
                            Console.WriteLine(responseText);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message} ошибка с сервером");
            }

        }
        private void ValidatePerson()
        {
            butAdd.Enabled =
                !string.IsNullOrEmpty(tovar.Title) &&
                tovar.Price != 0;
        }
        private void textBoxTittle_TextChanged(object sender, EventArgs e)
        {
            tovar.Title = textBoxTittle.Text.Trim();
            ValidatePerson();
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            if(decimal.TryParse(textBoxPrice.Text.Trim(), out var price))
            {
                tovar.Price = Math.Round(price,2);
            }
            else
            {
                tovar.Price = 0;
            }
            ValidatePerson();
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8) && (e.KeyChar != 46))
            {
                e.Handled = true;
            }
        }

        private void numericUpDownCount_ValueChanged(object sender, EventArgs e)
        {
            tovar.MaxCount = (int)numericUpDownCount.Value;
        }

        private void textBoxDesc_TextChanged(object sender, EventArgs e)
        {
            tovar.Description = textBoxDesc.Text.Trim();
        }
    }
}
