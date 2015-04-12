namespace conjuntos
{
    partial class SetInput
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_B = new System.Windows.Forms.GroupBox();
            this.listBox_B = new System.Windows.Forms.ListBox();
            this.button_B = new System.Windows.Forms.Button();
            this.textBox_B = new System.Windows.Forms.TextBox();
            this.groupBox_B.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_B
            // 
            this.groupBox_B.Controls.Add(this.listBox_B);
            this.groupBox_B.Controls.Add(this.button_B);
            this.groupBox_B.Controls.Add(this.textBox_B);
            this.groupBox_B.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_B.Location = new System.Drawing.Point(5, -2);
            this.groupBox_B.Name = "groupBox_B";
            this.groupBox_B.Size = new System.Drawing.Size(245, 241);
            this.groupBox_B.TabIndex = 7;
            this.groupBox_B.TabStop = false;
            this.groupBox_B.Text = "Conjunto B";
            // 
            // listBox_B
            // 
            this.listBox_B.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_B.FormattingEnabled = true;
            this.listBox_B.ItemHeight = 18;
            this.listBox_B.Location = new System.Drawing.Point(6, 24);
            this.listBox_B.Name = "listBox_B";
            this.listBox_B.Size = new System.Drawing.Size(232, 184);
            this.listBox_B.TabIndex = 1;
            this.listBox_B.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox_B_KeyDown);
            // 
            // button_B
            // 
            this.button_B.BackColor = System.Drawing.SystemColors.Info;
            this.button_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_B.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_B.Location = new System.Drawing.Point(205, 211);
            this.button_B.Name = "button_B";
            this.button_B.Size = new System.Drawing.Size(33, 26);
            this.button_B.TabIndex = 4;
            this.button_B.Text = "+";
            this.button_B.UseVisualStyleBackColor = false;
            this.button_B.Click += new System.EventHandler(this.button_B_Click);
            // 
            // textBox_B
            // 
            this.textBox_B.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_B.Location = new System.Drawing.Point(7, 210);
            this.textBox_B.Name = "textBox_B";
            this.textBox_B.Size = new System.Drawing.Size(191, 26);
            this.textBox_B.TabIndex = 3;
            this.textBox_B.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_B_KeyDown);
            // 
            // SetInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.groupBox_B);
            this.Name = "SetInput";
            this.Size = new System.Drawing.Size(253, 246);
            this.groupBox_B.ResumeLayout(false);
            this.groupBox_B.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_B;
        private System.Windows.Forms.ListBox listBox_B;
        private System.Windows.Forms.Button button_B;
        private System.Windows.Forms.TextBox textBox_B;


    }
}
