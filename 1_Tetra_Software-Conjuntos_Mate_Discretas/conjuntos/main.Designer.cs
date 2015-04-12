namespace conjuntos
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.comboBox_Operations = new System.Windows.Forms.ComboBox();
            this.textBox_Resultado = new System.Windows.Forms.TextBox();
            this.groupBox_Operaciones = new System.Windows.Forms.GroupBox();
            this.comboBox_set2 = new System.Windows.Forms.ComboBox();
            this.comboBox_set1 = new System.Windows.Forms.ComboBox();
            this.button_calcular = new System.Windows.Forms.Button();
            this.panel_B = new System.Windows.Forms.Panel();
            this.panel_A = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.groupBox_Operaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 637);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(543, 24);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(283, 19);
            this.toolStripStatusLabel1.Text = "Hazael Fernando Mojica García - 1500724";
            // 
            // comboBox_Operations
            // 
            this.comboBox_Operations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Operations.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Operations.FormattingEnabled = true;
            this.comboBox_Operations.Location = new System.Drawing.Point(202, 24);
            this.comboBox_Operations.Name = "comboBox_Operations";
            this.comboBox_Operations.Size = new System.Drawing.Size(110, 26);
            this.comboBox_Operations.TabIndex = 4;
            // 
            // textBox_Resultado
            // 
            this.textBox_Resultado.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Resultado.Location = new System.Drawing.Point(12, 362);
            this.textBox_Resultado.Multiline = true;
            this.textBox_Resultado.Name = "textBox_Resultado";
            this.textBox_Resultado.ReadOnly = true;
            this.textBox_Resultado.Size = new System.Drawing.Size(523, 265);
            this.textBox_Resultado.TabIndex = 7;
            // 
            // groupBox_Operaciones
            // 
            this.groupBox_Operaciones.Controls.Add(this.comboBox_set2);
            this.groupBox_Operaciones.Controls.Add(this.comboBox_set1);
            this.groupBox_Operaciones.Controls.Add(this.button_calcular);
            this.groupBox_Operaciones.Controls.Add(this.comboBox_Operations);
            this.groupBox_Operaciones.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Operaciones.Location = new System.Drawing.Point(12, 291);
            this.groupBox_Operaciones.Name = "groupBox_Operaciones";
            this.groupBox_Operaciones.Size = new System.Drawing.Size(523, 65);
            this.groupBox_Operaciones.TabIndex = 11;
            this.groupBox_Operaciones.TabStop = false;
            this.groupBox_Operaciones.Text = "Operaciones";
            // 
            // comboBox_set2
            // 
            this.comboBox_set2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_set2.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_set2.FormattingEnabled = true;
            this.comboBox_set2.Location = new System.Drawing.Point(318, 23);
            this.comboBox_set2.Name = "comboBox_set2";
            this.comboBox_set2.Size = new System.Drawing.Size(76, 26);
            this.comboBox_set2.TabIndex = 5;
            // 
            // comboBox_set1
            // 
            this.comboBox_set1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_set1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_set1.FormattingEnabled = true;
            this.comboBox_set1.Location = new System.Drawing.Point(120, 23);
            this.comboBox_set1.Name = "comboBox_set1";
            this.comboBox_set1.Size = new System.Drawing.Size(76, 26);
            this.comboBox_set1.TabIndex = 3;
            // 
            // button_calcular
            // 
            this.button_calcular.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_calcular.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_calcular.Location = new System.Drawing.Point(410, 23);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(30, 27);
            this.button_calcular.TabIndex = 6;
            this.button_calcular.Text = "=";
            this.button_calcular.UseVisualStyleBackColor = false;
            this.button_calcular.Click += new System.EventHandler(this.button_calcular_Click);
            // 
            // panel_B
            // 
            this.panel_B.Location = new System.Drawing.Point(282, 15);
            this.panel_B.Name = "panel_B";
            this.panel_B.Size = new System.Drawing.Size(253, 270);
            this.panel_B.TabIndex = 2;
            // 
            // panel_A
            // 
            this.panel_A.Location = new System.Drawing.Point(12, 15);
            this.panel_A.Name = "panel_A";
            this.panel_A.Size = new System.Drawing.Size(264, 270);
            this.panel_A.TabIndex = 1;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(543, 661);
            this.Controls.Add(this.panel_A);
            this.Controls.Add(this.panel_B);
            this.Controls.Add(this.groupBox_Operaciones);
            this.Controls.Add(this.textBox_Resultado);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "main";
            this.Text = "Operaciones de Conjuntos - Matematicas Discretas";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox_Operaciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ComboBox comboBox_Operations;
        private System.Windows.Forms.TextBox textBox_Resultado;
        private System.Windows.Forms.GroupBox groupBox_Operaciones;
        private System.Windows.Forms.Button button_calcular;
        private System.Windows.Forms.Panel panel_B;
        private System.Windows.Forms.Panel panel_A;
        private System.Windows.Forms.ComboBox comboBox_set2;
        private System.Windows.Forms.ComboBox comboBox_set1;
    }
}

