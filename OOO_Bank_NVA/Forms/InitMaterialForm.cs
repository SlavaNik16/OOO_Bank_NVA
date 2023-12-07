using MaterialSkin;
using MaterialSkin.Controls;

namespace OOO_Bank_NVA.Forms
{
    public partial class InitMaterialForm : MaterialForm
    {
        public InitMaterialForm()
        {
            InitializeComponent();
        }

        private void InitMaterialForm_Load(object sender, System.EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey500,
                Accent.LightBlue200,
                TextShade.WHITE);
        }
    }
}
