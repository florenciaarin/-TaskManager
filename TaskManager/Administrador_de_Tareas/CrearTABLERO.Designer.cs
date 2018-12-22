namespace Administrador_de_Tareas
{
    partial class CrearTABLERO
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombreTablero = new System.Windows.Forms.TextBox();
            this.labelTeam = new System.Windows.Forms.Label();
            this.comboBoxTeamParaTablero = new System.Windows.Forms.ComboBox();
            this.buttonCrearTablero = new System.Windows.Forms.Button();
            this.checkBoxQuiereTableroPersonal = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(21, 18);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre:";
            // 
            // textBoxNombreTablero
            // 
            this.textBoxNombreTablero.Location = new System.Drawing.Point(24, 34);
            this.textBoxNombreTablero.Name = "textBoxNombreTablero";
            this.textBoxNombreTablero.Size = new System.Drawing.Size(217, 20);
            this.textBoxNombreTablero.TabIndex = 1;
            // 
            // labelTeam
            // 
            this.labelTeam.AutoSize = true;
            this.labelTeam.Location = new System.Drawing.Point(21, 68);
            this.labelTeam.Name = "labelTeam";
            this.labelTeam.Size = new System.Drawing.Size(43, 13);
            this.labelTeam.TabIndex = 2;
            this.labelTeam.Text = "Equipo:";
            // 
            // comboBoxTeamParaTablero
            // 
            this.comboBoxTeamParaTablero.FormattingEnabled = true;
            this.comboBoxTeamParaTablero.Location = new System.Drawing.Point(24, 84);
            this.comboBoxTeamParaTablero.Name = "comboBoxTeamParaTablero";
            this.comboBoxTeamParaTablero.Size = new System.Drawing.Size(217, 21);
            this.comboBoxTeamParaTablero.TabIndex = 3;
            // 
            // buttonCrearTablero
            // 
            this.buttonCrearTablero.BackColor = System.Drawing.SystemColors.Info;
            this.buttonCrearTablero.Location = new System.Drawing.Point(24, 146);
            this.buttonCrearTablero.Name = "buttonCrearTablero";
            this.buttonCrearTablero.Size = new System.Drawing.Size(75, 36);
            this.buttonCrearTablero.TabIndex = 4;
            this.buttonCrearTablero.Text = "Crear";
            this.buttonCrearTablero.UseVisualStyleBackColor = false;
            this.buttonCrearTablero.Click += new System.EventHandler(this.buttonCrearTablero_Click);
            // 
            // checkBoxQuiereTableroPersonal
            // 
            this.checkBoxQuiereTableroPersonal.AutoSize = true;
            this.checkBoxQuiereTableroPersonal.Location = new System.Drawing.Point(24, 123);
            this.checkBoxQuiereTableroPersonal.Name = "checkBoxQuiereTableroPersonal";
            this.checkBoxQuiereTableroPersonal.Size = new System.Drawing.Size(162, 17);
            this.checkBoxQuiereTableroPersonal.TabIndex = 5;
            this.checkBoxQuiereTableroPersonal.Text = "Tablero personal (sin equipo)";
            this.checkBoxQuiereTableroPersonal.UseVisualStyleBackColor = true;
            this.checkBoxQuiereTableroPersonal.CheckedChanged += new System.EventHandler(this.checkBoxQuiereTableroPersonal_CheckedChanged);
            // 
            // CrearTABLERO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(266, 201);
            this.Controls.Add(this.checkBoxQuiereTableroPersonal);
            this.Controls.Add(this.buttonCrearTablero);
            this.Controls.Add(this.comboBoxTeamParaTablero);
            this.Controls.Add(this.labelTeam);
            this.Controls.Add(this.textBoxNombreTablero);
            this.Controls.Add(this.labelNombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CrearTABLERO";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Tablero";
            this.Load += new System.EventHandler(this.CrearTABLERO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombreTablero;
        private System.Windows.Forms.Label labelTeam;
        private System.Windows.Forms.ComboBox comboBoxTeamParaTablero;
        private System.Windows.Forms.Button buttonCrearTablero;
        private System.Windows.Forms.CheckBox checkBoxQuiereTableroPersonal;
    }
}