using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using Module.AForge.Models;
using Module.AForge.Extensions;
using System.ComponentModel;
namespace ControlDeBrazo
{

    public partial class FrmPrincipal : Form
    {
        public CaptureDevice Camara { get; set; }
        public bool ActivarRastreoDeColor = false;
        public bool MostrarOriginal = false;
        public bool MultiOrSingleTracking = false;
        public int R, G, B;
        SerialPort port = new SerialPort { BaudRate = 9600, RtsEnable = true,ReadTimeout=200, };
        public FrmPrincipal()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void SetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Camara != null && Camara.IsRunning())
            {
                Camara.Dispose();
            }
            Camara = null;
            var frmSeleccionarCamara = new FrmSelectorDeCamara();
            if (frmSeleccionarCamara.ShowDialog() != DialogResult.OK) return;
            if (frmSeleccionarCamara != null)
            {
                Camara.NewFramEventHandler -= NewFrameEventHandler;
                Camara.NewFramEventHandler += NewFrameEventHandler;
            }
            StartToolStripMenuItem_Click(null,null);
        }

        private void StopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Camara == null)
            {
                MessageBox.Show("Iniciliza un dispositivo de video!", "Warning");
                return;
            }
            Camara.StopCapture();
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Camara == null)
            {
                MessageBox.Show("Iniciliza un dispositivo de video!", "Warning");
                return;
            }
            Camara.StopCapture();
            PbPantalla.Image = null;
            PbPantalla.BackColor = Color.Black;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void NewFrameEventHandler(object sender, Bitmap bitmap)
        {
            try
            {
                if (!ActivarRastreoDeColor)
                {
                    var clone = (Bitmap)bitmap.Clone();
                    PbPantalla.Image = clone;
                    return;

                }
                if (MostrarOriginal)
                {
                    var Imagenoriginal = bitmap.FindObjectsOnOrjinal(Color.Red,Color.FromArgb(R,G,B),multiple:MultiOrSingleTracking);
                    PbPantalla.Image = Imagenoriginal;
                    return;
                }
                var ImagenFiltrada = bitmap.EuclideanFilter(Color.FromArgb(R,G,B));
                var processedFilteredBitmap = ImagenFiltrada.FindObjectsOnFiltered(Color.Red, multiple: MultiOrSingleTracking);

                PbPantalla.Image = processedFilteredBitmap;
            }
            catch
            {

            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        { 
            Close();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowOrjinalOrProcessImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarOriginal = showOrjinalOrProcessImageToolStripMenuItem.Checked;
         
        }

        private void MultiOrSingleTrackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MultiOrSingleTracking = multiOrSingleTrackingToolStripMenuItem.Checked;
        }

        private void ColorTrackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmSetColor = (FrmSeleccionarColor)Application.OpenForms["FrmSeleccionarColor"];
            frmSetColor?.Focus();
            if (frmSetColor != null) return;
            frmSetColor = new FrmSeleccionarColor();
            frmSetColor.Show();
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(900, 1200);
        }

        void StartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Camara == null)
            {
                MessageBox.Show("Inicia un dispositivo de video!","Warning");
                return;
            }
            Camara.StartCapture();

            PbPantalla.Width = Camara.Width;
            PbPantalla.Height = Camara.Height + 65;
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            MessageBox.Show("Bye");
            if (Camara != null && Camara.IsRunning())
            {
                try
                {
                    Camara.StopCapture();
                    Camara = null;
                }
                catch
                {
                    // ignored
                }
            }

            base.OnClosing(e);
        }

    }
}
