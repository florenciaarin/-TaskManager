namespace Administrador_de_Tareas
{
    partial class EditarEliminarEtiqueta
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
            this.textBoxEditarEtiqueta = new System.Windows.Forms.TextBox();
            this.buttonEditarEtiqueta = new System.Windows.Forms.Button();
            this.buttonEliminarEtiqueta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxEditarEtiqueta
            // 
            this.textBoxEditarEtiqueta.Location = new System.Drawing.Point(12, 22);
            this.textBoxEditarEtiqueta.Name = "textBoxEditarEtiqueta";
            this.textBoxEditarEtiqueta.Size = new System.Drawing.Size(193, 20);
            this.textBoxEditarEtiqueta.TabIndex = 0;
            // 
            // buttonEditarEtiqueta
            // 
            this.buttonEditarEtiqueta.BackColor = System.Drawing.SystemColors.Info;
            this.buttonEditarEtiqueta.Location = new System.Drawing.Point(12, 60);
            this.buttonEditarEtiqueta.Name = "buttonEditarEtiqueta";
            this.buttonEditarEtiqueta.Size = new System.Drawing.Size(63, 28);
            this.buttonEditarEtiqueta.TabIndex = 1;
            this.buttonEditarEtiqueta.Text = "Guardar";
            this.buttonEditarEtiqueta.UseVisualStyleBackColor = false;
            // 
            // buttonEliminarEtiqueta
            // 
            this.buttonEliminarEtiqueta.BackColor = System.Drawing.SystemColors.Info;
            this.buttonEliminarEtiqueta.Location = new System.Drawing.Point(143, 58);
            this.buttonEliminarEtiqueta.Name = "buttonEliminarEtiqueta";
            this.buttonEliminarEtiqueta.Size = new System.Drawing.Size(62, 30);
            this.buttonEliminarEtiqueta.TabIndex = 2;
            this.buttonEliminarEtiqueta.Text = "Eliminar";
            this.buttonEliminarEtiqueta.UseVisualStyleBackColor = false;
            // 
            // EditarEliminarEtiqueta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(219, 101);
            this.Controls.Add(this.buttonEliminarEtiqueta);
            this.Controls.Add(this.buttonEditarEtiqueta);
            this.Controls.Add(this.textBoxEditarEtiqueta);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditarEliminarEtiqueta";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Etiqueta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEditarEtiqueta;
        private System.Windows.Forms.Button buttonEditarEtiqueta;
        private System.Windows.Forms.Button buttonEliminarEtiqueta;
    }
}