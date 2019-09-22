namespace TallerFinal1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtnota1 = new System.Windows.Forms.TextBox();
            this.txtnota2 = new System.Windows.Forms.TextBox();
            this.txtnota3 = new System.Windows.Forms.TextBox();
            this.txtnota4 = new System.Windows.Forms.TextBox();
            this.txtnota5 = new System.Windows.Forms.TextBox();
            this.lblpromedio = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ingrese la nota 1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingrese la nota 3:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ingrese la nota 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ingrese la nota 4:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ingrese la nota 5:";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(184, 177);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 9;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txtnota1
            // 
            this.txtnota1.Location = new System.Drawing.Point(276, 58);
            this.txtnota1.Name = "txtnota1";
            this.txtnota1.Size = new System.Drawing.Size(42, 20);
            this.txtnota1.TabIndex = 10;
            // 
            // txtnota2
            // 
            this.txtnota2.Location = new System.Drawing.Point(276, 81);
            this.txtnota2.Name = "txtnota2";
            this.txtnota2.Size = new System.Drawing.Size(42, 20);
            this.txtnota2.TabIndex = 11;
            // 
            // txtnota3
            // 
            this.txtnota3.Location = new System.Drawing.Point(276, 103);
            this.txtnota3.Name = "txtnota3";
            this.txtnota3.Size = new System.Drawing.Size(42, 20);
            this.txtnota3.TabIndex = 12;
            // 
            // txtnota4
            // 
            this.txtnota4.Location = new System.Drawing.Point(276, 126);
            this.txtnota4.Name = "txtnota4";
            this.txtnota4.Size = new System.Drawing.Size(42, 20);
            this.txtnota4.TabIndex = 13;
            // 
            // txtnota5
            // 
            this.txtnota5.Location = new System.Drawing.Point(276, 149);
            this.txtnota5.Name = "txtnota5";
            this.txtnota5.Size = new System.Drawing.Size(42, 20);
            this.txtnota5.TabIndex = 14;
            // 
            // lblpromedio
            // 
            this.lblpromedio.AutoSize = true;
            this.lblpromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblpromedio.Location = new System.Drawing.Point(273, 182);
            this.lblpromedio.Name = "lblpromedio";
            this.lblpromedio.Size = new System.Drawing.Size(68, 17);
            this.lblpromedio.TabIndex = 15;
            this.lblpromedio.Text = "Promedio";
            this.lblpromedio.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label7.Location = new System.Drawing.Point(135, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Calculo de 5 notas.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 260);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblpromedio);
            this.Controls.Add(this.txtnota5);
            this.Controls.Add(this.txtnota4);
            this.Controls.Add(this.txtnota3);
            this.Controls.Add(this.txtnota2);
            this.Controls.Add(this.txtnota1);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txtnota1;
        private System.Windows.Forms.TextBox txtnota2;
        private System.Windows.Forms.TextBox txtnota3;
        private System.Windows.Forms.TextBox txtnota4;
        private System.Windows.Forms.TextBox txtnota5;
        private System.Windows.Forms.Label lblpromedio;
        private System.Windows.Forms.Label label7;
    }
}

