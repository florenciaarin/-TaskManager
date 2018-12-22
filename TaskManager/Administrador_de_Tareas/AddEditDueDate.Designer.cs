namespace Administrador_de_Tareas
{
    partial class AddEditDueDate
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
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.buttonGuardarDueDate = new System.Windows.Forms.Button();
            this.buttonDeleteDueDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(18, 18);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            // 
            // buttonGuardarDueDate
            // 
            this.buttonGuardarDueDate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonGuardarDueDate.Location = new System.Drawing.Point(18, 186);
            this.buttonGuardarDueDate.Name = "buttonGuardarDueDate";
            this.buttonGuardarDueDate.Size = new System.Drawing.Size(89, 41);
            this.buttonGuardarDueDate.TabIndex = 1;
            this.buttonGuardarDueDate.Text = "Guardar";
            this.buttonGuardarDueDate.UseVisualStyleBackColor = false;
            this.buttonGuardarDueDate.Click += new System.EventHandler(this.buttonGuardarDueDate_Click);
            // 
            // buttonDeleteDueDate
            // 
            this.buttonDeleteDueDate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDeleteDueDate.Location = new System.Drawing.Point(170, 186);
            this.buttonDeleteDueDate.Name = "buttonDeleteDueDate";
            this.buttonDeleteDueDate.Size = new System.Drawing.Size(96, 41);
            this.buttonDeleteDueDate.TabIndex = 2;
            this.buttonDeleteDueDate.Text = "Eliminar";
            this.buttonDeleteDueDate.UseVisualStyleBackColor = false;
            this.buttonDeleteDueDate.Click += new System.EventHandler(this.buttonDeleteDueDate_Click);
            // 
            // AddEditDueDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(279, 239);
            this.Controls.Add(this.buttonDeleteDueDate);
            this.Controls.Add(this.buttonGuardarDueDate);
            this.Controls.Add(this.monthCalendar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditDueDate";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fecha Vencimiento";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button buttonGuardarDueDate;
        private System.Windows.Forms.Button buttonDeleteDueDate;
    }
}