using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conjuntos
{
    public partial class main : Form
    {
        private SetInput setInputA;
        private SetInput setInputB;

        private string opIntersection = "Intersection /";
        private string opUnion = "Union +";
        private string opDifference = "Difference -";
        private string opProduct = "Cartesian Product *";

        public main()
        {
            InitializeComponent();
            this.setInputA = new SetInput("Conjunto A");
            this.setInputB = new SetInput("Conjunto B");
            this.panel_A.Controls.Add(this.setInputA);
            this.panel_B.Controls.Add(this.setInputB);

            this.comboBox_set1.Items.Add("A");
            this.comboBox_set1.Items.Add("B");
            this.comboBox_set2.Items.Add("A");
            this.comboBox_set2.Items.Add("B");

            this.comboBox_Operations.Items.Add("");
            this.comboBox_Operations.Items.Add(opIntersection);
            this.comboBox_Operations.Items.Add(opUnion);
            this.comboBox_Operations.Items.Add(opDifference);
            this.comboBox_Operations.Items.Add(opProduct);
        }

        //PRIVATE METHODS
        //***************************************************************************


        //PRIVATE EVENT METHODS
        //****************************************************************************
        private void button_calcular_Click(object sender, EventArgs e)
        {
            if ((this.comboBox_Operations.SelectedIndex >= 0) && (this.comboBox_set1.SelectedIndex >= 0) && (this.comboBox_set2.SelectedIndex >= 0))
            {
                Set set1;
                Set set2;

                //Choose what to use as set 1
                if(this.comboBox_set1.SelectedItem.ToString() == "A")
                    set1 = new Set(this.setInputA.getItems());
                else
                    set1 = new Set(this.setInputB.getItems());

                //Choose what to use as set 2
                if(this.comboBox_set2.SelectedItem.ToString() == "A")
                    set2 = new Set(this.setInputA.getItems());
                else
                    set2 = new Set(this.setInputB.getItems());                

                //Apply the selected operation
                if (this.comboBox_Operations.SelectedItem.ToString() == this.opIntersection)
                {
                    this.textBox_Resultado.Text = set1.intersection(set2).ToString();
                }
                else if (this.comboBox_Operations.SelectedItem.ToString() == this.opUnion)
                {
                    this.textBox_Resultado.Text = set1.union(set2).ToString();
                }
                else if (this.comboBox_Operations.SelectedItem.ToString() == this.opDifference)
                {
                    this.textBox_Resultado.Text = set1.difference(set2).ToString();
                }
                else if (this.comboBox_Operations.SelectedItem.ToString() == this.opProduct)
                {
                    this.textBox_Resultado.Text = set1.cartesianProduct(set2).ToString();
                }
            }
        }

        

    }
}
