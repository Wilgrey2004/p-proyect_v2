using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using p_proyect.Modules.Entidades.dtos.dtoAdeudos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p_proyect.Modules.Entidades.Formularios.AdeudosForms
{
    public partial class AgregarMontoAlADeudo : MaterialForm
    {
        public AdeudoMostrarDto adeudoActual;
        public AgregarMontoAlADeudo()
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

        private void AgregarMontoAlADeudo_Load(object sender, EventArgs e)
        {
            MontoTotalDelAdeudo.Text = adeudoActual.MontoTotalDelAdeudo.ToString();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void Agregar_usuarios_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("Quiers Agregar el monto al adeudo ?", "Pregunta sobre agregado", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.No)
            {
                return;
            }
            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                var adeudoBuscar = await  context.Adeudos.FirstOrDefaultAsync(a => a.Id == adeudoActual.Id);

                if( adeudoBuscar == null)
                {
                    MessageBox.Show("Error en el adeudo");
                    return ;
                }

                adeudoBuscar.MontoTotalAbonadoDelAdeudo += Convert.ToDecimal( AbonoDelAdeudo.Text.Trim());

                adeudoBuscar.FechaUltimaActualizacion = DateTime.Now;

                adeudoBuscar.MontoRestanteDelAdeudo =adeudoBuscar.MontoTotalAbonadoDelAdeudo - adeudoBuscar.MontoTotalAbonadoDelAdeudo; 

                context.Adeudos.Update( adeudoBuscar );

                context.SaveChanges();

                MessageBox.Show("Adeudo Actualizado!!!");

                Close();
            }
        }
    }
}
