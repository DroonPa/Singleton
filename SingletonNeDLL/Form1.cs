using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySingletonLibrary;

namespace SingletonNeDLL
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            Logger.Instance.Log("Мейн форма запущена");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOpenSecondForm_Click(object sender, EventArgs e)
        {
            Logger.Instance.Log("Друга форма відкрита");
            new SecondForm().Show();
        }

        private void btnSaveDoc_Click(object sender, EventArgs e)
        {
            var result = DocumentSaver.Instance.SaveDocument("Документ збережено!");
            MessageBox.Show(result);
            Logger.Instance.Log("Документ збережено");
        }

        private void btnCheckDb_Click(object sender, EventArgs e)
        {
            var result = DbManager.Instance.GetConnectionStatus();
            MessageBox.Show(result);
            Logger.Instance.Log("Провірка з'єднання");
        }
    }
}
