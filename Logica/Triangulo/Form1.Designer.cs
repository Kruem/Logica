namespace Triangulo
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
            this.txtl1 = new System.Windows.Forms.TextBox();
            this.txtl3 = new System.Windows.Forms.TextBox();
            this.txtsolucion = new System.Windows.Forms.TextBox();
            this.txtl2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtl1
            // 
            this.txtl1.Location = new System.Drawing.Point(125, 67);
            this.txtl1.Name = "txtl1";
            this.txtl1.Size = new System.Drawing.Size(100, 20);
            this.txtl1.TabIndex = 0;
            // 
            // txtl3
            // 
            this.txtl3.Location = new System.Drawing.Point(125, 161);
            this.txtl3.Name = "txtl3";
            this.txtl3.Size = new System.Drawing.Size(100, 20);
            this.txtl3.TabIndex = 1;
            // 
            // txtsolucion
            // 
            this.txtsolucion.Location = new System.Drawing.Point(125, 208);
            this.txtsolucion.Name = "txtsolucion";
            this.txtsolucion.Size = new System.Drawing.Size(100, 20);
            this.txtsolucion.TabIndex = 2;
            // 
            // txtl2
            // 
            this.txtl2.Location = new System.Drawing.Point(125, 114);
            this.txtl2.Name = "txtl2";
            this.txtl2.Size = new System.Drawing.Size(100, 20);
            this.txtl2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lado 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lado 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lado 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Solucion";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(125, 264);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 9;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 323);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtl2);
            this.Controls.Add(this.txtsolucion);
            this.Controls.Add(this.txtl3);
            this.Controls.Add(this.txtl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtl1;
        private System.Windows.Forms.TextBox txtl3;
        private System.Windows.Forms.TextBox txtsolucion;
        private System.Windows.Forms.TextBox txtl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncalcular;
    }
}

