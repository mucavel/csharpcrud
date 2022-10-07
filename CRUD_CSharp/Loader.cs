using System;
using System.Windows.Forms;

namespace CRUD_CSharp
{
    public partial class Loader : Form
    {
        public Loader()
        {
            InitializeComponent();
        }
        int startPoint = 0;
        private void Loader_Load(object sender, EventArgs e)
        {
            ProgressTimer.Start();
        }

        private void ProgressTimerTick(object sender, EventArgs e)
        {
            startPoint++;
            GunaProgressBar.Value = startPoint;
            if (GunaProgressBar.Value == 100)
            {
                GunaProgressBar.Value = 0;
                ProgressTimer.Stop();
                crud crudForm = new crud();
                this.Hide();
                crudForm.Show();
            }
        }
    }
}
