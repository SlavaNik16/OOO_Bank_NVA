using MaterialSkin.Controls;
using OOO_Bank_NVA.Models;
using OOO_Bank_NVA.ModelsResponce;
using System;
using System.Drawing;

namespace OOO_Bank_NVA.Forms
{
    public partial class AddTovarBasketForm : MaterialForm
    {
        private Basket basket;
        private decimal price = 0;
        public AddTovarBasketForm(TovarResponce tovarResponce)
        {
            InitializeComponent();
            basket = new Basket();
            basket.PersonId = AuthorizationForm.user.Id;
            basket.Title = tovarResponce.Title;
            basket.Description = tovarResponce.Description;
            basket.Price = tovarResponce.Price;
            basket.Photo = tovarResponce.Photo;
            textBoxTitle.Text = tovarResponce.Title;
            labelPrice.Text = tovarResponce.Price.ToString();
            labelMaxCount.Text = tovarResponce.MaxCount.ToString();
            if (panelPicture.Visible = !string.IsNullOrEmpty(tovarResponce.Photo))
            {
                pictureBoxPhotoTovar.Image = Bitmap.FromFile(tovarResponce.Photo);
            }
            numericUpDownCount.Maximum = int.Parse(labelMaxCount.Text);
            price = decimal.Parse(labelPrice.Text);

        }
        public Basket Basket => basket;

        private void numericUpDownCount_ValueChanged(object sender, EventArgs e)
        {
            basket.Count = (int)numericUpDownCount.Value;
            labelPrice.Text = (price * (int)numericUpDownCount.Value).ToString();
        }
    }
}
