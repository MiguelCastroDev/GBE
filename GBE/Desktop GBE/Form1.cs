using Desktop_GBE.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_GBE
{
    public partial class menuPanel : Form
    {
        public menuPanel()
        {
            InitializeComponent();
            openDashboard();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openForm(object form)
        {
            if(this.viewPanel.Controls.Count > 0){
                this.viewPanel.Controls.RemoveAt(0);
            }
            Form view = form as Form;
            view.TopLevel = false;
            view.Dock = DockStyle.Fill;
            this.viewPanel.Controls.Add(view);
            this.viewPanel.Tag = view;
            view.Show();
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            openDashboard();
        }

        private void openDashboard()
        {
            openForm(new Dashboard());
        }

        private void clientsButton_Click(object sender, EventArgs e)
        {
            openForm(new ClientsForm());
        }

        private void workersButton_Click(object sender, EventArgs e)
        {
            openForm(new WorkersForm());
        }

        private void servicesButton_Click(object sender, EventArgs e)
        {
            openForm(new ServicesForm());
        }
    }
}
