namespace Administrador_de_Tareas
{
    partial class CrearOeditarTitDescDeEquipo
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
            this.textBoxCambiosParaEquipo = new System.Windows.Forms.TextBox();
            this.buttonGuardarCambioTitOdescEquipo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCambiosParaEquipo
            // 
            this.textBoxCambiosParaEquipo.Location = new System.Drawing.Point(4, 12);
            this.textBoxCambiosParaEquipo.Name = "textBoxCambiosParaEquipo";
            this.textBoxCambiosParaEquipo.Size = new System.Drawing.Size(312, 20);
            this.textBoxCambiosParaEquipo.TabIndex = 0;
            // 
            // buttonGuardarCambioTitOdescEquipo
            // 
            this.buttonGuardarCambioTitOdescEquipo.Location = new System.Drawing.Point(12, 49);
            this.buttonGuardarCambioTitOdescEquipo.Name = "buttonGuardarCambioTitOdescEquipo";
            this.buttonGuardarCambioTitOdescEquipo.Size = new System.Drawing.Size(88, 30);
            this.buttonGuardarCambioTitOdescEquipo.TabIndex = 1;
            this.buttonGuardarCambioTitOdescEquipo.Text = "Guardar";
            this.buttonGuardarCambioTitOdescEquipo.UseVisualStyleBackColor = true;
            // 
            // CrearOeditarTitDescDeEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(328, 88);
            this.Controls.Add(this.buttonGuardarCambioTitOdescEquipo);
            this.Controls.Add(this.textBoxCambiosParaEquipo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CrearOeditarTitDescDeEquipo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambios Equipo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCambiosParaEquipo;
        private System.Windows.Forms.Button buttonGuardarCambioTitOdescEquipo;
    }
}