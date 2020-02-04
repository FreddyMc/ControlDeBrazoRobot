using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using Module.AForge.Models;
using Module.AForge.Extensions;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Threading;
namespace ControlDeBrazo
{

    public partial class FrmPrincipal : Form
    {
        public CaptureDevice Camara { get; set; }
        public bool ActivarRastreoDeColor = false;
        public bool MostrarOriginal = false;
        public bool MultiOrSingleTracking = false;
        public int R, G, B;
        SerialPort port;

        bool detectectada = false;
        Pieza pieza;
        Pieza PiezaAnterior;
        Task PColor;
        Task PDetectada;
        Task PTamaño;

        Bitmap fotoNueva;
        Bitmap fotoAnterior;

        Bitmap nuevaGris;
        Bitmap anteriorGris;


        public FrmPrincipal()
        {
            port = new SerialPort();
            InitializeComponent();


            CheckForIllegalCrossThreadCalls = false;
            pieza = new Pieza();
            PiezaAnterior = new Pieza() {ColorPieza =Pieza.Colores.Azúl };
            PTamaño = new Task(() =>
            {
                while (detectectada)
                {
                    if (PiezaAnterior.ColorPieza==pieza.ColorPieza)
                    {

                    }
                    else 
                    {
                        PiezaAnterior.ColorPieza = pieza.ColorPieza;
                        string salida = "";
                        if (pieza.ColorPieza == Pieza.Colores.Verde)
                        {
                            salida = "1";
                        }
                        if (pieza.ColorPieza == Pieza.Colores.Roja)
                        {
                            salida = "2";
                        }
                        if (pieza.ColorPieza == Pieza.Colores.Azúl)
                        {
                            salida = "3";
                        }
                        port.WriteLine(salida);
                    }
                    Thread.Sleep(1500);
                }
            });
            PDetectada = new Task(() =>
            {
                detectectada = Procesar.Piezadetectada(anteriorGris, nuevaGris);
            });
            PColor = new Task(() =>
            {
                pieza.ColorPieza = Procesar.DetectarColorDePieza(fotoNueva);
            });
        }
        #region Métodos
        //private void IniciarProceso()
        //{
        //    Bitmap Clon = (Bitmap)fotoNueva.Clone();
        //    //PTamaño = new Task(() =>
        //    //{
        //    //    pieza.Tamaño = Procesar.DetectarTamaño(Clon);
        //    //});
        //    PColor = new Task(() =>
        //    {
        //        pieza.ColorPieza = Procesar.DetectarColorDePieza(Clon);
        //    });
        //    //PForma = new Task(() =>
        //    //{
        //    //    pieza.Forma = Procesar.detectarForma((Bitmap)nuevaGris.Clone());
        //    //});
        //    PColor.Start();
        //    //PForma.Start();
        //    //PTamaño.Start();
        //}
        void IniciarReconocimiento()
        {
            PColor.Start();
        }
        public void NuevoFrametHandler(object sender, Bitmap pfotoNueva)
        {
            if (fotoAnterior == null)
            {
                fotoAnterior = (Bitmap)pfotoNueva.Clone();
                anteriorGris = Procesar.EscalaDeGrises(fotoAnterior);
                //Pintar();
                return;
            }
            //if (PColor == null || !((PColor.Status == TaskStatus.Running) || (PForma.Status == TaskStatus.Running) || (PTamaño.Status == TaskStatus.Running)))
            //{
            fotoNueva = (Bitmap)pfotoNueva.Clone();
            nuevaGris = Procesar.EscalaDeGrises(fotoNueva);
            //Pintar();
            //bool x = Procesar.Piezadetectada(anteriorGris, nuevaGris);

            if (anteriorGris != null && nuevaGris != null)
            {
                ////IniciarProceso();
                ////Thread.Sleep(2000);
                pieza.ColorPieza = Procesar.DetectarColorDePieza(fotoNueva);
                ////pieza.Tamaño = Procesar.DetectarTamaño(ref fotoNueva);
                ////pieza.Forma = Procesar.detectarForma(ref fotoNueva);
                Pintar();

                //if (PDetectada.Status == TaskStatus.Created)
                //{
                //    if (PDetectada.Status != TaskStatus.Running)
                //    {
                //        Pintar();
                //        IniciarProceso();
                //    }
                //}
                //if (true)
                //{
                //    if (true)
                //    {
                //        Pintar();
                //        if (PColor.Status != TaskStatus.Running)
                //        {
                //            PColor.Start();
                //        }
                //        if (PColor.Status == TaskStatus.RanToCompletion)
                //        {
                //            PColor = Task.Run(()=> pieza.ColorPieza = Procesar.DetectarColorDePieza(fotoNueva));
                //        }
                //    }
                //}
            }
            //}

        }
        void Pintar()
        {
            lblPieza.Text = pieza.ToString();
            if (this.rdOriginal.Checked)
            {
                if (fotoNueva != null)
                {
                    PbPantalla.Image = (Bitmap)fotoNueva.Clone();

                }
            }
            if (this.rbGris.Checked)
            {

                if (nuevaGris != null)
                {
                    PbPantalla.Image = (Bitmap)nuevaGris.Clone();
                }
            }
            PbPantalla.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        #endregion
        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Conectando");
            if (port.IsOpen == false)
            {
                port.PortName = "COM5";
                //port.BaudRate = 9600;
                //port.DataBits = 8;
                //port.Parity = Parity.None;
                //port.StopBits = StopBits.One;
                port.Open();
                detectectada = true;
                MessageBox.Show("Conectado");
            }

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
            StartToolStripMenuItem_Click(null, null);
        }

        private void StopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            detectectada = false;
            if (Camara == null)
            {
                MessageBox.Show("Iniciliza un dispositivo de video!", "Advertencia");
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
            NuevoFrametHandler(sender, bitmap);
            //try
            //{
            //    if (!ActivarRastreoDeColor)
            //    {
            //        var clone = (Bitmap)bitmap.Clone();
            //        PbPantalla.Image = clone;
            //        return;

            //    }
            //    if (MostrarOriginal)
            //    {
            //        var Imagenoriginal = bitmap.FindObjectsOnOrjinal(Color.Red, Color.FromArgb(R, G, B), multiple: MultiOrSingleTracking);
            //        PbPantalla.Image = Imagenoriginal;
            //        return;
            //    }
            //    var ImagenFiltrada = bitmap.EuclideanFilter(Color.FromArgb(R, G, B));
            //    var ImagenProcesada = ImagenFiltrada.FindObjectsOnFiltered(Color.Red, multiple: MultiOrSingleTracking);

            //    PbPantalla.Image = ImagenProcesada;
            //}
            //catch
            //{

            //}
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
            var _frmSeleccionarColor = (FrmSeleccionarColor)Application.OpenForms["FrmSeleccionarColor"];
            _frmSeleccionarColor?.Focus();
            if (_frmSeleccionarColor != null) return;
            _frmSeleccionarColor = new FrmSeleccionarColor();
            _frmSeleccionarColor.Show();
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(900, 1200);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (var item in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(item);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            port.Write(textBox1.Text);
        }

        void StartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Camara == null)
            {
                MessageBox.Show("Inicia un dispositivo de video!", "Warning");
                return;
            }
            Camara.StartCapture();

            PbPantalla.Width = Camara.Width;
            PbPantalla.Height = Camara.Height + 65;
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            detectectada = false;

            if (Camara != null && Camara.IsRunning())
            {
                try
                {
                    if (port.IsOpen)
                    {
                        port.Close();
                    }
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
