using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorDrivingSchool.Components
{
    public partial class frmYesOrNo : Form
    {

        public class clsConfirmationEventArgs: EventArgs
        {
            public bool isConfirmed { set; get; }

            public clsConfirmationEventArgs(bool isConfirmed)
            {
                this.isConfirmed = isConfirmed;
            }
        }

        public event EventHandler<clsConfirmationEventArgs> onConfirmation;

        private void _handleUserChoice(bool isConfirmed)
        {
            this._handleUserChoice(new clsConfirmationEventArgs(isConfirmed));
        } 

        protected virtual void _handleUserChoice(clsConfirmationEventArgs e)
        {
            this.onConfirmation?.Invoke(this, e);
        }

        public frmYesOrNo()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this._handleUserChoice(new clsConfirmationEventArgs(true)); 
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this._handleUserChoice(new clsConfirmationEventArgs(false));
            this.Close();
        }
    }
}
