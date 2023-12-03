using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using File = System.IO.File;

namespace OOO_Bank_NVA.Forms
{
    public partial class AddTovarForm : Form
    {
        public AddTovarForm()
        {
            InitializeComponent();
        }

        private async void pictureBoxTovar_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;
            string filename = openFileDialog.FileName;
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
            }catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message} ошибка с сервером");
            }




        }
    }
}
