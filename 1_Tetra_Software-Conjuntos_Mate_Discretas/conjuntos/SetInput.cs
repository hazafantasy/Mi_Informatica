using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace conjuntos
{
    public partial class SetInput : UserControl
    {
        public SetInput(string title)
        {
            InitializeComponent();
            this.groupBox_B.Text = title;
        }

        public List<string> getItems()
        {
            List<string> items = new List<string>();
            items.Add(" ");
            for (int i = 0; i < this.listBox_B.Items.Count; i++)
                items.Add(this.listBox_B.Items[i].ToString());
            return items;
        }

        private void listBox_B_KeyDown(object sender, KeyEventArgs e)
        {
            int selIndex = this.listBox_B.SelectedIndex;
            if (e.KeyCode == Keys.Delete)
            {
                if (selIndex > -1)
                    this.listBox_B.Items.RemoveAt(selIndex);
            }
        }

        private void button_B_Click(object sender, EventArgs e)
        {
            add();
        }

        private void add()
        {
            string item = this.textBox_B.Text;
            if (item != "")
                if (!listBox_B.Items.Contains(item))
                {
                    listBox_B.Items.Add(item);
                    textBox_B.Text = "";
                }
        }

        private void textBox_B_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                add();
        }

    }
}
