using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace p_proyect.Utils.Rnc
{
    public partial class RNCFormHelper : MaterialForm
    {
        private string Rnc_;
        public RncLookupResult InfoRnc;
        public RNCFormHelper()
        {


            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            // Fondos blancos
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Tema rojizo empresarial
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red800,   // Color principal (barra superior)
                Primary.Red900,   // Dark Primary
                Primary.Red700,   // Light Primary
                Accent.Red200,    // Acento (buttons, sliders)
                TextShade.WHITE   // Color del texto de la barra
            );
        }

        public void setRnc(string Rnc)
        {
            Rnc_ = Rnc;
        }

        public RncLookupResult getInfoRnc()
        {
            return InfoRnc;
        }

        private void CargarRnc()
        {
            setRnc(RncDeLaEmpresa_txt.Text.Trim());
            BuscarRnc_();


        }

        private void BuscarRnc_()
        {
            InfoRnc = RncHelper.LookupRnc(Rnc_);
            if (InfoRnc == null)
            {
               MessageBox.Show("No se encontró información para el RNC/Cédula proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            
            NombreDeLaEmpresa_txt.Text = InfoRnc.Nombre;
        }

        private void RNCFormHelper_Load(object sender, EventArgs e)
        {

         

        }

        private void BuscarRnc_Click(object sender, EventArgs e)
        {
            

            CargarRnc();
        }



        private void materialButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (MessagesHelpers.MensajeDeConfirmacion("¿Está seguro de que desea Agregar la información del RNC/Cédula a la factura?", "Confirmación", MessageBoxIcon.Question))
            {   
                Close();
                return;
            }
        
        }
    }
}
