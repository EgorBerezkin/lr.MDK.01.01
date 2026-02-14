using ModelViewBiblioteka.Model;
using ModelViewBiblioteka.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelViewMyForms
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
            UsersTableView usertable = new UsersTableView();
            Controls.Add(usertable);
            usertable.Dock = DockStyle.Top;

            UserPresenter userPresenter = new UserPresenter(new MemoryUserModel(), usertable);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
