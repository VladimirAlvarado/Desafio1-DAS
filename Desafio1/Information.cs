using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio1
{
    public partial class FormInformation : Form
    {
        private User user;
        public FormInformation(User user)
        {
            InitializeComponent();
            this.user = user;

            ShowInformation();
        }

        private void ShowInformation()
        {
            if (user.Theme == "Programas de Entretenimiento")
            {
                tabControlInfo.SelectedTab = tabPage1;

                lblSocial.Text = "GAME OF THRONES";
                pictureBoxSocial.Image = Image.FromFile("C:\\Users\\GUASI\\Documents\\GitHub\\Desafio1-DAS\\Desafio1\\img\\Game1.jpg");
                lblSocialNum.Text = "Idioma en Español: JUEGO DE TRONOS";
                lblCountry.Text = "Creado Por: David Benioff D. B. Weiss";
                lblOrigen.Text = "País de Origen: ESTADOS UNIDOS";
                lblTemporada.Text = "Temporadas: 8";
                lblEpisodios.Text = "Episodios: 73";

                tabControlInfo.SelectedTab = tabPage2;
                lblStreaming.Text = "CHERNOBYL";
                pictureBoxStreming.Image = Image.FromFile("C:\\Users\\GUASI\\Documents\\GitHub\\Desafio1-DAS\\Desafio1\\img\\Cherno.jpg");
                lblnumS.Text = "Idioma en Español: CHERNÓBIL";
                lblP.Text = "Creado Por: Craig Mazin";
                lblOrigen2.Text = "País de Origen: ESTADOS UNIDOS Y REINO UNIDO";
                lblTemp.Text = "Temporadas: 1";
                lblEpisod.Text = "Episodios: 5";

                tabControlInfo.SelectedTab = tabPage3;


                // Datos de ejemplo para el gráfico de pastel
                double[] valores = { 50, 50 };
                string[] categ = { "GAME OF THRONES", "CHERNOBYL" };

                // Crear un nuevo gráfico con ScottPlot
                var plt = new ScottPlot.Plot(500, 400);

                // Agregar un gráfico de pastel
                var pie = plt.AddPie(valores);

                // Personalizar el gráfico de pastel
                pie.SliceLabels = categ;
                pie.ShowPercentages = true;
                pie.ShowValues = true;
                pie.ShowLabels = true;

                

                // Guardar la imagen en un archivo PNG temporal
                string tempImagePath = Path.Combine(Path.GetTempPath(), "pie_chart.png");
                plt.SaveFig(tempImagePath);

                // Cargar la imagen desde el archivo y mostrarla en el PictureBox
                pictureBox1.Image = Image.FromFile(tempImagePath);

                // Limpiar la imagen temporal cuando ya no sea necesaria
                FormClosed += (s, e) => File.Delete(tempImagePath);

                tabControlInfo.SelectedTab = tabPage1;

            }
            if (user.Theme == "Lenguajes de Programacion")
            {

                tabControlInfo.SelectedTab = tabPage1;
                lblSocial.Text = "PHYTON";
                pictureBoxSocial.Image = Image.FromFile("C:\\Users\\GUASI\\Documents\\GitHub\\Desafio1-DAS\\Desafio1\\img\\Phyton.png");
                lblSocialNum.Text = "Desarrollador: Phyton Software Foundation";
                lblCountry.Text = "Extensiones: .py, .pyc, .pyd, .pyw, .pyz";
                lblOrigen.Text = "Sistema Operativo: Multiplataforma";
                lblTemporada.Text = "Año de Aparición: 1991";
                lblEpisodios.Text = "Ultima Versión Estable: 3.8.3";


                tabControlInfo.SelectedTab = tabPage2;
                lblStreaming.Text = "JAVA";
                pictureBoxStreming.Image = Image.FromFile("C:\\Users\\GUASI\\Documents\\GitHub\\Desafio1-DAS\\Desafio1\\img\\Java.png");
                lblnumS.Text = "Desarrollador: James Gosling y Sun Microsystems";
                lblP.Text = "Extensiones: java, class, jar, jad y jmod";
                lblOrigen2.Text = "Sistema Operativo: Multiplataforma";
                lblTemp.Text = "Año de Aparición: 1996";
                lblEpisod.Text = "Ultima Versión Estable: 14.01";

                tabControlInfo.SelectedTab = tabPage3;

                // Datos de ejemplo para el gráfico de pastel
                double[] valor = { 50, 50 };
                string[] cate = { "PHYTON", "JAVA" };

                // Crear un nuevo gráfico con ScottPlot
                var plt = new ScottPlot.Plot(600, 400);

                // Agregar un gráfico de pastel
                var pie = plt.AddPie(valor);

                // Personalizar el gráfico de pastel
                pie.SliceLabels = cate;
                pie.ShowPercentages = true;
                pie.ShowValues = true;
                pie.ShowLabels = true;

                

                // Guardar la imagen en un archivo PNG temporal
                string tempImagePath = Path.Combine(Path.GetTempPath(), "pie_chart2.png");
                plt.SaveFig(tempImagePath);

                // Cargar la imagen desde el archivo y mostrarla en el PictureBox
                pictureBox1.Image = Image.FromFile(tempImagePath);

                // Limpiar la imagen temporal cuando ya no sea necesaria
                FormClosed += (s, e) => File.Delete(tempImagePath);

                tabControlInfo.SelectedTab = tabPage1;
            }
        }
        private void FormInformation_Load(object sender, EventArgs e)
        {

        }

        private void lblSocialNum_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblP_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
