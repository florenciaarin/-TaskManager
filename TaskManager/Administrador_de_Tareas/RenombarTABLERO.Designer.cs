namespace Administrador_de_Tareas
{
    partial class RenombarTABLERO
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
            this.textBoxRenombrarTablero = new System.Windows.Forms.TextBox();
            this.buttonRenombrarTablero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxRenombrarTablero
            // 
            this.textBoxRenombrarTablero.Location = new System.Drawing.Point(24, 24);
            this.textBoxRenombrarTablero.Name = "textBoxRenombrarTablero";
            this.textBoxRenombrarTablero.Size = new System.Drawing.Size(202, 20);
            this.textBoxRenombrarTablero.TabIndex = 0;
            // 
            // buttonRenombrarTablero
            // 
            this.buttonRenombrarTablero.Location = new System.Drawing.Point(24, 68);
            this.buttonRenombrarTablero.Name = "buttonRenombrarTablero";
            this.buttonRenombrarTablero.Size = new System.Drawing.Size(102, 34);
            this.buttonRenombrarTablero.TabIndex = 1;
            this.buttonRenombrarTablero.Text = "Renombrar";
            this.buttonRenombrarTablero.UseVisualStyleBackColor = true;
            this.buttonRenombrarTablero.Click += new System.EventHandler(this.buttonRenombrarTablero_Click);
            // 
            // RenombarTABLERO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(250, 114);
            this.Controls.Add(this.buttonRenombrarTablero);
            this.Controls.Add(this.textBoxRenombrarTablero);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RenombarTABLERO";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renombra Tablero";
            this.Load += new System.EventHandler(this.RenombarTABLERO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRenombrarTablero;
        private System.Windows.Forms.Button buttonRenombrarTablero;
    }
}