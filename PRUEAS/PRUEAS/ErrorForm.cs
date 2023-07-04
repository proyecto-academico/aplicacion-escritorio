using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRUEAS
{
    public partial class ErrorForm : Form
    {
        public ErrorForm()
        {
            InitializeComponent();
        }

        #region botones
        #endregion

        #region Methods
        public void MensajeMostrar(bool valor)
        {
            if (valor)
            {
                Label label = new Label();
                label.Text = "Error";
            }
            else
            {
                Label label = new Label();
                label.Text = "cajeta";
            }
            #endregion
        }
    }
}
