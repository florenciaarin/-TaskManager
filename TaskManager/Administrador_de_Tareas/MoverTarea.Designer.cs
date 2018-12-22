namespace Administrador_de_Tareas
{
    partial class MoverTarea
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
            this.labelListasDelTablero = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.buttonMoverTarea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelListasDelTablero
            // 
            this.labelListasDelTablero.AutoSize = true;
            this.labelListasDelTablero.Location = new System.Drawing.Point(25, 20);
            this.labelListasDelTablero.Name = "labelListasDelTablero";
            this.labelListasDelTablero.Size = new System.Drawing.Size(32, 13);
            this.labelListasDelTablero.TabIndex = 5;
            this.labelListasDelTablero.Text = "Lista:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(28, 36);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(158, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // buttonMoverTarea
            // 
            this.buttonMoverTarea.Location = new System.Drawing.Point(62, 78);
            this.buttonMoverTarea.Name = "buttonMoverTarea";
            this.buttonMoverTarea.Size = new System.Drawing.Size(82, 27);
            this.buttonMoverTarea.TabIndex = 7;
            this.buttonMoverTarea.Text = "Mover";
            this.buttonMoverTarea.UseVisualStyleBackColor = true;
            this.buttonMoverTarea.Click += new System.EventHandler(this.buttonMoverTarea_Click);
            // 
            // MoverTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(226, 121);
            this.Controls.Add(this.buttonMoverTarea);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.labelListasDelTablero);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MoverTarea";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mover Tarea";
            this.Load += new System.EventHandler(this.MoverTarea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelListasDelTablero;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button buttonMoverTarea;
    }
}