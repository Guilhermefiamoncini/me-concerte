namespace AlgoritmoInsercao
{
    partial class Form1
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
            this.lstaNaoOrdenada = new System.Windows.Forms.ListBox();
            this.lstaOrdenada = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstaNaoOrdenada
            // 
            this.lstaNaoOrdenada.FormattingEnabled = true;
            this.lstaNaoOrdenada.Location = new System.Drawing.Point(10, 29);
            this.lstaNaoOrdenada.Name = "lstaNaoOrdenada";
            this.lstaNaoOrdenada.Size = new System.Drawing.Size(201, 355);
            this.lstaNaoOrdenada.TabIndex = 0;
            // 
            // lstaOrdenada
            // 
            this.lstaOrdenada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lstaOrdenada.FormattingEnabled = true;
            this.lstaOrdenada.Location = new System.Drawing.Point(297, 29);
            this.lstaOrdenada.Name = "lstaOrdenada";
            this.lstaOrdenada.Size = new System.Drawing.Size(201, 355);
            this.lstaOrdenada.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Números a Ordenar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Números Ordenados";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "==>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(223, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 53);
            this.label3.TabIndex = 3;
            this.label3.Text = "Aplicar Algoritmo de Ordenação por inserção";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 408);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstaOrdenada);
            this.Controls.Add(this.lstaNaoOrdenada);
            this.Name = "Form1";
            this.Text = "Algoritmo de ordenação por inserção";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstaNaoOrdenada;
        private System.Windows.Forms.ListBox lstaOrdenada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

