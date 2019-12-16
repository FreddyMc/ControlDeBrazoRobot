using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeBrazo
{
    public partial class FrmSeleccionarColor : Form
    {
        private readonly FrmPrincipal _mainForm = (FrmPrincipal)Application.OpenForms["FrmPrincipal"];

        public FrmSeleccionarColor()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            chkActivePassive.Checked = _mainForm.ActivarRastreoDeColor;
            redTrackBar.Value = _mainForm.R;
            greenTrackBar.Value = _mainForm.G;
            blueTrackBar.Value = _mainForm.B;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkActivePassive_CheckedChanged(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                _mainForm.ActivarRastreoDeColor = chkActivePassive.Checked;
            });
        }

        private void redTrackBar_Scroll(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                _mainForm.R = redTrackBar.Value;
            });
        }

        private void greenTrackBar_Scroll(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                _mainForm.G = greenTrackBar.Value;
            });
        }

        private void blueTrackBar_Scroll(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                _mainForm.B = blueTrackBar.Value;
            });
        }
    }
}
