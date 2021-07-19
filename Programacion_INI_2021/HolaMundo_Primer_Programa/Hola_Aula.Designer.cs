
namespace HolaMundo_Primer_Programa
{
    partial class Hola_Aula
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
            this.LblEtiqueta = new System.Windows.Forms.Label();
            this.LblMensaje = new System.Windows.Forms.Label();
            this.TxtMateria = new System.Windows.Forms.TextBox();
            this.BtnClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblEtiqueta
            // 
            this.LblEtiqueta.AutoSize = true;
            this.LblEtiqueta.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEtiqueta.Location = new System.Drawing.Point(55, 22);
            this.LblEtiqueta.Name = "LblEtiqueta";
            this.LblEtiqueta.Size = new System.Drawing.Size(353, 31);
            this.LblEtiqueta.TabIndex = 1;
            this.LblEtiqueta.Text = "Ingrese nombre de materia:";
            this.LblEtiqueta.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblMensaje
            // 
            this.LblMensaje.AutoSize = true;
            this.LblMensaje.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMensaje.Location = new System.Drawing.Point(25, 109);
            this.LblMensaje.Name = "LblMensaje";
            this.LblMensaje.Size = new System.Drawing.Size(59, 27);
            this.LblMensaje.TabIndex = 2;
            this.LblMensaje.Text = "Hola";
            // 
            // TxtMateria
            // 
            this.TxtMateria.Location = new System.Drawing.Point(139, 73);
            this.TxtMateria.Name = "TxtMateria";
            this.TxtMateria.Size = new System.Drawing.Size(198, 20);
            this.TxtMateria.TabIndex = 3;
            // 
            // BtnClick
            // 
            this.BtnClick.BackColor = System.Drawing.Color.Aquamarine;
            this.BtnClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClick.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClick.ForeColor = System.Drawing.Color.DarkBlue;
            this.BtnClick.Location = new System.Drawing.Point(357, 152);
            this.BtnClick.Name = "BtnClick";
            this.BtnClick.Size = new System.Drawing.Size(103, 35);
            this.BtnClick.TabIndex = 4;
            this.BtnClick.Text = "Saludar";
            this.BtnClick.UseVisualStyleBackColor = false;
            this.BtnClick.Click += new System.EventHandler(this.BtnClick_Click);
            // 
            // Hola_Aula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(622, 256);
            this.Controls.Add(this.BtnClick);
            this.Controls.Add(this.TxtMateria);
            this.Controls.Add(this.LblMensaje);
            this.Controls.Add(this.LblEtiqueta);
            this.Name = "Hola_Aula";
            this.Text = "HolaMundo_primer_programa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblEtiqueta;
        private System.Windows.Forms.Label LblMensaje;
        private System.Windows.Forms.TextBox TxtMateria;
        private System.Windows.Forms.Button BtnClick;
    }
}

