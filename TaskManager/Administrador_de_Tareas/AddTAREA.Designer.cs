namespace Administrador_de_Tareas
{
    partial class AddTAREA
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
            this.textBoxDataEntrada = new System.Windows.Forms.TextBox();
            this.buttonCrearTareaEnLista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDataEntrada
            // 
            this.textBoxDataEntrada.Location = new System.Drawing.Point(12, 12);
            this.textBoxDataEntrada.Name = "textBoxDataEntrada";
            this.textBoxDataEntrada.Size = new System.Drawing.Size(252, 20);
            this.textBoxDataEntrada.TabIndex = 0;
            this.textBoxDataEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDataEntrada_KeyPress);
            // 
            // buttonCrearTareaEnLista
            // 
            this.buttonCrearTareaEnLista.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCrearTareaEnLista.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonCrearTareaEnLista.Location = new System.Drawing.Point(12, 38);
            this.buttonCrearTareaEnLista.Name = "buttonCrearTareaEnLista";
            this.buttonCrearTareaEnLista.Size = new System.Drawing.Size(66, 35);
            this.buttonCrearTareaEnLista.TabIndex = 1;
            this.buttonCrearTareaEnLista.Text = "+ Agregar";
            this.buttonCrearTareaEnLista.UseVisualStyleBackColor = false;
            this.buttonCrearTareaEnLista.Click += new System.EventHandler(this.buttonCrearTareaEnLista_Click);
            // 
            // AddTAREA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(285, 82);
            this.Controls.Add(this.buttonCrearTareaEnLista);
            this.Controls.Add(this.textBoxDataEntrada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimizeBox = false;
            this.Name = "AddTAREA";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "+ New Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDataEntrada;
        private System.Windows.Forms.Button buttonCrearTareaEnLista;
    }
}