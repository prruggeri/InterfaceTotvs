using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceTotvs
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Interface List 1.0.\nWritten by Paula Ruggeri", "About");
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'totvsDBDataSet.TotvsTable'. Você pode movê-la ou removê-la conforme necessário.
            this.totvsTableTableAdapter.Fill(this.totvsDBDataSet.TotvsTable);
            MessageBox.Show("Interface List 1.0.\nWritten by Paula Ruggeri", "About");
        }

        private void totvsTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.totvsTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.totvsDBDataSet);

        }

        private void estadoLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
