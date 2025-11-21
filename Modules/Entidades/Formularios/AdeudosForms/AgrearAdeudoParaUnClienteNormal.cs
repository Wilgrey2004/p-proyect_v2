using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using p_proyect.Modules.Entidades.dtos.dtoClienteEspecial;
using p_proyect.Modules.Entidades.dtos.dtoClienteNormal;
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
    public partial class AgrearAdeudoParaUnClienteNormal : MaterialForm
    {
        public AgrearAdeudoParaUnClienteNormal()
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

        public Ventas ventaActual = new Ventas();

        public decimal montoDelAdeudo = 0;

        private void AgrearAdeudoParaUnClienteNormal_Load(object sender, EventArgs e)
        {
            if(montoDelAdeudo < 0)
            {
                montoDelAdeudo = montoDelAdeudo * -1;
            }
            MontoDelAdeudo.Text = montoDelAdeudo.ToString("N2");
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Generacion de adeudo cancelada!!");
            Close();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }
        ClienteNormalCrearDto clienteNormalCrearDto = new ClienteNormalCrearDto();

        private void CrearClienteNormal()
        {

            
            var respuesta = MessageBox.Show("Quieres Crear un Cliente?", "Pregunta sobre agregado", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.No)
            {
                return;
            }
            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {


                clienteNormalCrearDto.Nombre = NombreDelCliente.Text;
                clienteNormalCrearDto.Contacto = ContactoDelCliente.Text;
                clienteNormalCrearDto.FechaCreacion = DateTime.Now;

                context.ClientesNormales.Add(ClienteNormalMapper.ToEntity(clienteNormalCrearDto));

                context.SaveChanges();

                clienteNormalCrearDto = null;
            }

        }

        private ClienteNormal TraerClientePorNombreYContacto()
        {
            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                var clienteNormal = context.ClientesNormales.FirstOrDefault(x => x.Nombre == NombreDelCliente.Text && x.Contacto == ContactoDelCliente.Text);

                return clienteNormal ?? clienteNormal;
            }
        }

        private void CrearAdeudo()
        {
            var respuesta = MessageBox.Show("Queres agregar a Un adeudo?", "Pregunta sobre agregado", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.No)
            {
                return;
            }
            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            { 

                Adeudo nuevoAdeudo = new Adeudo();

                nuevoAdeudo.MontoTotalDelAdeudo = decimal.Parse(MontoDelAdeudo.Text);

                nuevoAdeudo.MontoTotalAbonadoDelAdeudo = 0;

                nuevoAdeudo.MontoRestanteDelAdeudo = nuevoAdeudo.MontoTotalDelAdeudo - nuevoAdeudo.MontoTotalAbonadoDelAdeudo;

                nuevoAdeudo.FechaCreacion = DateTime.Now;

                nuevoAdeudo.IdVenta = ventaActual.Id;

                var cliente = TraerClientePorNombreYContacto();

                nuevoAdeudo.IdCliente = cliente.Id ;

                nuevoAdeudo.ContactoDelCliente = cliente.Contacto;

                context.Adeudos.Add(nuevoAdeudo); 

                context.SaveChanges();

            }
        }

        private void Agregar_usuarios_Click(object sender, EventArgs e)
        {
            if(NombreDelCliente.Text == null)
            {
                MessageBox.Show("Necesitas Agregar un Nombre para el Cliente!!");
                return; 
            }

            if (ContactoDelCliente.Text == null)
            {
                MessageBox.Show("Necesitas Agregar un Numero para el Cliente!!");
                return;
            }

            CrearClienteNormal();
            CrearAdeudo();

            MessageBox.Show("Adeudo Generado!!");
            Close();
        }
    }
}
