using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnIniciar_Click(object sender, EventArgs e)
        {
            // Operacion Sincrona. Esta operacion Bloquea el Hilo de ejecucion durante 5 segundos, por lo que Nada mas se puede usar hasta que termiane.
            // Thread.Sleep(5000);

            // Operacion Asincrona. No Bloquea el Hilo de ejecucion y se pueden realizar otras tareas mientras tanto. 
            picLoadingGif.Visible = true;
            await Task.Delay(TimeSpan.FromSeconds(5));

            picLoadingGif.Visible = false;

            //.. Cuando termina, siguen el resto de operaciones, pero no Bloquea la ejecucion.
        }

      
    }
}
