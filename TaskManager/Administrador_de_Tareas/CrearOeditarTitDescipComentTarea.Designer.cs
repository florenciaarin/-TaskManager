namespace Administrador_de_Tareas
{
    partial class CrearOeditarTitDescipComentTarea
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
            this.textBoxEditarOcraerDescTitComent = new System.Windows.Forms.TextBox();
            this.buttonSaveCambiosTitComenDescr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxEditarOcraerDescTitComent
            // 
            this.textBoxEditarOcraerDescTitComent.Location = new System.Drawing.Point(12, 12);
            this.textBoxEditarOcraerDescTitComent.Name = "textBoxEditarOcraerDescTitComent";
            this.textBoxEditarOcraerDescTitComent.Size = new System.Drawing.Size(330, 20);
            this.textBoxEditarOcraerDescTitComent.TabIndex = 0;
            // 
            // buttonSaveCambiosTitComenDescr
            // 
            this.buttonSaveCambiosTitComenDescr.Location = new System.Drawing.Point(12, 48);
            this.buttonSaveCambiosTitComenDescr.Name = "buttonSaveCambiosTitComenDescr";
            this.buttonSaveCambiosTitComenDescr.Size = new System.Drawing.Size(75, 29);
            this.buttonSaveCambiosTitComenDescr.TabIndex = 1;
            this.buttonSaveCambiosTitComenDescr.Text = "Guardar";
            this.buttonSaveCambiosTitComenDescr.UseVisualStyleBackColor = true;
            this.buttonSaveCambiosTitComenDescr.Click += new System.EventHandler(this.buttonSaveCambiosTitComenDescr_Click);
            // 
            // CrearOeditarTitDescipComentTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(354, 88);
            this.Controls.Add(this.buttonSaveCambiosTitComenDescr);
            this.Controls.Add(this.textBoxEditarOcraerDescTitComent);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CrearOeditarTitDescipComentTarea";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...";
            this.Load += new System.EventHandler(this.CrearOeditarTitDescipComentTarea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEditarOcraerDescTitComent;
        private System.Windows.Forms.Button buttonSaveCambiosTitComenDescr;
    }
}