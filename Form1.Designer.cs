
namespace FormComplejos_G3_2022_I
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
            this.txtbComplejo1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbComplejo2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbResultadoComplejo1 = new System.Windows.Forms.Label();
            this.btnSumar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbComplejo1
            // 
            this.txtbComplejo1.Location = new System.Drawing.Point(92, 158);
            this.txtbComplejo1.Name = "txtbComplejo1";
            this.txtbComplejo1.Size = new System.Drawing.Size(198, 29);
            this.txtbComplejo1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "+";
            // 
            // txtbComplejo2
            // 
            this.txtbComplejo2.Location = new System.Drawing.Point(484, 155);
            this.txtbComplejo2.Name = "txtbComplejo2";
            this.txtbComplejo2.Size = new System.Drawing.Size(198, 29);
            this.txtbComplejo2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(761, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "=";
            // 
            // lbResultadoComplejo1
            // 
            this.lbResultadoComplejo1.AutoSize = true;
            this.lbResultadoComplejo1.Location = new System.Drawing.Point(904, 155);
            this.lbResultadoComplejo1.Name = "lbResultadoComplejo1";
            this.lbResultadoComplejo1.Size = new System.Drawing.Size(50, 25);
            this.lbResultadoComplejo1.TabIndex = 1;
            this.lbResultadoComplejo1.Text = "0+0i";
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(999, 127);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(193, 59);
            this.btnSumar.TabIndex = 2;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 500);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.lbResultadoComplejo1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbComplejo2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbComplejo1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbComplejo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbComplejo2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbResultadoComplejo1;
        private System.Windows.Forms.Button btnSumar;
    }
}

