namespace Administrador_de_Tareas
{
    partial class AddResponsable
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
            this.cbBoxMiembrosParaAddResponsable = new System.Windows.Forms.ComboBox();
            this.buttonAgregarResponsableAccion = new System.Windows.Forms.Button();
            this.labelMiembrosTeam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbBoxMiembrosParaAddResponsable
            // 
            this.cbBoxMiembrosParaAddResponsable.FormattingEnabled = true;
            this.cbBoxMiembrosParaAddResponsable.Location = new System.Drawing.Point(12, 33);
            this.cbBoxMiembrosParaAddResponsable.Name = "cbBoxMiembrosParaAddResponsable";
            this.cbBoxMiembrosParaAddResponsable.Size = new System.Drawing.Size(231, 21);
            this.cbBoxMiembrosParaAddResponsable.TabIndex = 0;
            // 
            // buttonAgregarResponsableAccion
            // 
            this.buttonAgregarResponsableAccion.Location = new System.Drawing.Point(249, 29);
            this.buttonAgregarResponsableAccion.Name = "buttonAgregarResponsableAccion";
            this.buttonAgregarResponsableAccion.Size = new System.Drawing.Size(34, 26);
            this.buttonAgregarResponsableAccion.TabIndex = 1;
            this.buttonAgregarResponsableAccion.Text = "+";
            this.buttonAgregarResponsableAccion.UseVisualStyleBackColor = true;
            this.buttonAgregarResponsableAccion.Click += new System.EventHandler(this.buttonAgregarResponsableAccion_Click);
            // 
            // labelMiembrosTeam
            // 
            this.labelMiembrosTeam.AutoSize = true;
            this.labelMiembrosTeam.Location = new System.Drawing.Point(12, 17);
            this.labelMiembrosTeam.Name = "labelMiembrosTeam";
            this.labelMiembrosTeam.Size = new System.Drawing.Size(107, 13);
            this.labelMiembrosTeam.TabIndex = 2;
            this.labelMiembrosTeam.Text = "Miembros Del Equipo";
            // 
            // AddResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(322, 82);
            this.Controls.Add(this.labelMiembrosTeam);
            this.Controls.Add(this.buttonAgregarResponsableAccion);
            this.Controls.Add(this.cbBoxMiembrosParaAddResponsable);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddResponsable";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Responsable";
            this.Load += new System.EventHandler(this.AddResponsable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBoxMiembrosParaAddResponsable;
        private System.Windows.Forms.Button buttonAgregarResponsableAccion;
        private System.Windows.Forms.Label labelMiembrosTeam;
    }
}