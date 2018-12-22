namespace Administrador_de_Tareas
{
    partial class TABLERO
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
            this.buttonGoHome = new System.Windows.Forms.Button();
            this.buttonDosOpcionesSegunTableroTengaTeam = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelEtiquetas = new System.Windows.Forms.Label();
            this.buttonFiltrarPorEtiqueta = new System.Windows.Forms.Button();
            this.dgvTODO = new System.Windows.Forms.DataGridView();
            this.dgvDOING = new System.Windows.Forms.DataGridView();
            this.dgvDONE = new System.Windows.Forms.DataGridView();
            this.labelTODO = new System.Windows.Forms.Label();
            this.labelDOING = new System.Windows.Forms.Label();
            this.labelDONE = new System.Windows.Forms.Label();
            this.buttonAddTareaTODO = new System.Windows.Forms.Button();
            this.buttonGoArchivados = new System.Windows.Forms.Button();
            this.buttonAddTareaDOING = new System.Windows.Forms.Button();
            this.buttonAddTareaDONE = new System.Windows.Forms.Button();
            this.buttonOptionsTODO = new System.Windows.Forms.Button();
            this.buttonOptionDOING = new System.Windows.Forms.Button();
            this.buttonOptionsDONE = new System.Windows.Forms.Button();
            this.buttonCancelFilterEtiquetas = new System.Windows.Forms.Button();
            this.buttonParaCambiarNameTablero = new System.Windows.Forms.Button();
            this.buttonMenuPerfil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTODO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDOING)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDONE)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGoHome
            // 
            this.buttonGoHome.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonGoHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGoHome.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonGoHome.Location = new System.Drawing.Point(8, 10);
            this.buttonGoHome.Name = "buttonGoHome";
            this.buttonGoHome.Size = new System.Drawing.Size(47, 30);
            this.buttonGoHome.TabIndex = 0;
            this.buttonGoHome.Text = "HOME";
            this.buttonGoHome.UseVisualStyleBackColor = false;
            this.buttonGoHome.Click += new System.EventHandler(this.buttonGoHome_Click);
            // 
            // buttonDosOpcionesSegunTableroTengaTeam
            // 
            this.buttonDosOpcionesSegunTableroTengaTeam.BackColor = System.Drawing.SystemColors.Info;
            this.buttonDosOpcionesSegunTableroTengaTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDosOpcionesSegunTableroTengaTeam.ForeColor = System.Drawing.SystemColors.GrayText;
            this.buttonDosOpcionesSegunTableroTengaTeam.Location = new System.Drawing.Point(230, 11);
            this.buttonDosOpcionesSegunTableroTengaTeam.Name = "buttonDosOpcionesSegunTableroTengaTeam";
            this.buttonDosOpcionesSegunTableroTengaTeam.Size = new System.Drawing.Size(143, 29);
            this.buttonDosOpcionesSegunTableroTengaTeam.TabIndex = 2;
            this.buttonDosOpcionesSegunTableroTengaTeam.Text = "Tablero Personal";
            this.buttonDosOpcionesSegunTableroTengaTeam.UseVisualStyleBackColor = false;
            this.buttonDosOpcionesSegunTableroTengaTeam.Click += new System.EventHandler(this.buttonDosOpcionesSegunTableroTengaTeam_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(379, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(105, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Visible = false;
            // 
            // labelEtiquetas
            // 
            this.labelEtiquetas.AutoSize = true;
            this.labelEtiquetas.Location = new System.Drawing.Point(379, 9);
            this.labelEtiquetas.Name = "labelEtiquetas";
            this.labelEtiquetas.Size = new System.Drawing.Size(51, 13);
            this.labelEtiquetas.TabIndex = 4;
            this.labelEtiquetas.Text = "Etiquetas";
            this.labelEtiquetas.Visible = false;
            // 
            // buttonFiltrarPorEtiqueta
            // 
            this.buttonFiltrarPorEtiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFiltrarPorEtiqueta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonFiltrarPorEtiqueta.Location = new System.Drawing.Point(490, 46);
            this.buttonFiltrarPorEtiqueta.Name = "buttonFiltrarPorEtiqueta";
            this.buttonFiltrarPorEtiqueta.Size = new System.Drawing.Size(32, 29);
            this.buttonFiltrarPorEtiqueta.TabIndex = 5;
            this.buttonFiltrarPorEtiqueta.Text = "<--";
            this.buttonFiltrarPorEtiqueta.UseVisualStyleBackColor = true;
            this.buttonFiltrarPorEtiqueta.Visible = false;
            // 
            // dgvTODO
            // 
            this.dgvTODO.AllowUserToDeleteRows = false;
            this.dgvTODO.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvTODO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTODO.Location = new System.Drawing.Point(48, 130);
            this.dgvTODO.Name = "dgvTODO";
            this.dgvTODO.ReadOnly = true;
            this.dgvTODO.Size = new System.Drawing.Size(152, 242);
            this.dgvTODO.TabIndex = 6;
            this.dgvTODO.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTODO_CellContentClick);
            // 
            // dgvDOING
            // 
            this.dgvDOING.AllowUserToDeleteRows = false;
            this.dgvDOING.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDOING.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDOING.Location = new System.Drawing.Point(234, 130);
            this.dgvDOING.Name = "dgvDOING";
            this.dgvDOING.ReadOnly = true;
            this.dgvDOING.Size = new System.Drawing.Size(151, 242);
            this.dgvDOING.TabIndex = 7;
            this.dgvDOING.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDOING_CellContentClick);
            // 
            // dgvDONE
            // 
            this.dgvDONE.AllowUserToDeleteRows = false;
            this.dgvDONE.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDONE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDONE.Location = new System.Drawing.Point(422, 130);
            this.dgvDONE.Name = "dgvDONE";
            this.dgvDONE.ReadOnly = true;
            this.dgvDONE.Size = new System.Drawing.Size(152, 241);
            this.dgvDONE.TabIndex = 8;
            this.dgvDONE.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDONE_CellContentClick);
            // 
            // labelTODO
            // 
            this.labelTODO.AutoSize = true;
            this.labelTODO.BackColor = System.Drawing.SystemColors.Window;
            this.labelTODO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTODO.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelTODO.Location = new System.Drawing.Point(58, 108);
            this.labelTODO.Name = "labelTODO";
            this.labelTODO.Size = new System.Drawing.Size(46, 13);
            this.labelTODO.TabIndex = 9;
            this.labelTODO.Text = "TO DO";
            // 
            // labelDOING
            // 
            this.labelDOING.AutoSize = true;
            this.labelDOING.BackColor = System.Drawing.SystemColors.Window;
            this.labelDOING.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDOING.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelDOING.Location = new System.Drawing.Point(245, 108);
            this.labelDOING.Name = "labelDOING";
            this.labelDOING.Size = new System.Drawing.Size(47, 13);
            this.labelDOING.TabIndex = 10;
            this.labelDOING.Text = "DOING";
            // 
            // labelDONE
            // 
            this.labelDONE.AutoSize = true;
            this.labelDONE.BackColor = System.Drawing.SystemColors.Window;
            this.labelDONE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDONE.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelDONE.Location = new System.Drawing.Point(435, 108);
            this.labelDONE.Name = "labelDONE";
            this.labelDONE.Size = new System.Drawing.Size(42, 13);
            this.labelDONE.TabIndex = 11;
            this.labelDONE.Text = "DONE";
            // 
            // buttonAddTareaTODO
            // 
            this.buttonAddTareaTODO.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonAddTareaTODO.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddTareaTODO.Location = new System.Drawing.Point(48, 378);
            this.buttonAddTareaTODO.Name = "buttonAddTareaTODO";
            this.buttonAddTareaTODO.Size = new System.Drawing.Size(152, 25);
            this.buttonAddTareaTODO.TabIndex = 12;
            this.buttonAddTareaTODO.Text = "+ Agregar Tarea";
            this.buttonAddTareaTODO.UseVisualStyleBackColor = false;
            this.buttonAddTareaTODO.Click += new System.EventHandler(this.buttonAddTareaTODO_Click);
            // 
            // buttonGoArchivados
            // 
            this.buttonGoArchivados.Location = new System.Drawing.Point(597, 327);
            this.buttonGoArchivados.Name = "buttonGoArchivados";
            this.buttonGoArchivados.Size = new System.Drawing.Size(45, 44);
            this.buttonGoArchivados.TabIndex = 14;
            this.buttonGoArchivados.UseVisualStyleBackColor = true;
            this.buttonGoArchivados.Visible = false;
            // 
            // buttonAddTareaDOING
            // 
            this.buttonAddTareaDOING.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonAddTareaDOING.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddTareaDOING.Location = new System.Drawing.Point(234, 378);
            this.buttonAddTareaDOING.Name = "buttonAddTareaDOING";
            this.buttonAddTareaDOING.Size = new System.Drawing.Size(151, 25);
            this.buttonAddTareaDOING.TabIndex = 15;
            this.buttonAddTareaDOING.Text = "+ Agregar Tarea";
            this.buttonAddTareaDOING.UseVisualStyleBackColor = false;
            this.buttonAddTareaDOING.Click += new System.EventHandler(this.buttonAddTareaDOING_Click);
            // 
            // buttonAddTareaDONE
            // 
            this.buttonAddTareaDONE.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonAddTareaDONE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddTareaDONE.Location = new System.Drawing.Point(422, 377);
            this.buttonAddTareaDONE.Name = "buttonAddTareaDONE";
            this.buttonAddTareaDONE.Size = new System.Drawing.Size(152, 26);
            this.buttonAddTareaDONE.TabIndex = 16;
            this.buttonAddTareaDONE.Text = "+ Agregar Tarea";
            this.buttonAddTareaDONE.UseVisualStyleBackColor = false;
            this.buttonAddTareaDONE.Click += new System.EventHandler(this.buttonAddTareaDONE_Click);
            // 
            // buttonOptionsTODO
            // 
            this.buttonOptionsTODO.Location = new System.Drawing.Point(173, 103);
            this.buttonOptionsTODO.Name = "buttonOptionsTODO";
            this.buttonOptionsTODO.Size = new System.Drawing.Size(27, 23);
            this.buttonOptionsTODO.TabIndex = 17;
            this.buttonOptionsTODO.Text = "...";
            this.buttonOptionsTODO.UseVisualStyleBackColor = true;
            this.buttonOptionsTODO.Visible = false;
            // 
            // buttonOptionDOING
            // 
            this.buttonOptionDOING.Location = new System.Drawing.Point(358, 103);
            this.buttonOptionDOING.Name = "buttonOptionDOING";
            this.buttonOptionDOING.Size = new System.Drawing.Size(27, 23);
            this.buttonOptionDOING.TabIndex = 18;
            this.buttonOptionDOING.Text = "...";
            this.buttonOptionDOING.UseVisualStyleBackColor = true;
            this.buttonOptionDOING.Visible = false;
            // 
            // buttonOptionsDONE
            // 
            this.buttonOptionsDONE.Location = new System.Drawing.Point(548, 103);
            this.buttonOptionsDONE.Name = "buttonOptionsDONE";
            this.buttonOptionsDONE.Size = new System.Drawing.Size(26, 23);
            this.buttonOptionsDONE.TabIndex = 19;
            this.buttonOptionsDONE.Text = "...";
            this.buttonOptionsDONE.UseVisualStyleBackColor = true;
            this.buttonOptionsDONE.Visible = false;
            // 
            // buttonCancelFilterEtiquetas
            // 
            this.buttonCancelFilterEtiquetas.Location = new System.Drawing.Point(528, 46);
            this.buttonCancelFilterEtiquetas.Name = "buttonCancelFilterEtiquetas";
            this.buttonCancelFilterEtiquetas.Size = new System.Drawing.Size(18, 29);
            this.buttonCancelFilterEtiquetas.TabIndex = 20;
            this.buttonCancelFilterEtiquetas.Text = "X";
            this.buttonCancelFilterEtiquetas.UseVisualStyleBackColor = true;
            this.buttonCancelFilterEtiquetas.Visible = false;
            // 
            // buttonParaCambiarNameTablero
            // 
            this.buttonParaCambiarNameTablero.AccessibleName = "";
            this.buttonParaCambiarNameTablero.BackColor = System.Drawing.SystemColors.Info;
            this.buttonParaCambiarNameTablero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonParaCambiarNameTablero.ForeColor = System.Drawing.SystemColors.GrayText;
            this.buttonParaCambiarNameTablero.Location = new System.Drawing.Point(61, 11);
            this.buttonParaCambiarNameTablero.Name = "buttonParaCambiarNameTablero";
            this.buttonParaCambiarNameTablero.Size = new System.Drawing.Size(169, 29);
            this.buttonParaCambiarNameTablero.TabIndex = 22;
            this.buttonParaCambiarNameTablero.TabStop = false;
            this.buttonParaCambiarNameTablero.Text = "Nombre Tablero";
            this.buttonParaCambiarNameTablero.UseVisualStyleBackColor = false;
            this.buttonParaCambiarNameTablero.Click += new System.EventHandler(this.buttonParaCambiarNameTablero_Click);
            // 
            // buttonMenuPerfil
            // 
            this.buttonMenuPerfil.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonMenuPerfil.Font = new System.Drawing.Font("Farsi Simple Outline", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonMenuPerfil.ForeColor = System.Drawing.Color.White;
            this.buttonMenuPerfil.Location = new System.Drawing.Point(548, 11);
            this.buttonMenuPerfil.Name = "buttonMenuPerfil";
            this.buttonMenuPerfil.Size = new System.Drawing.Size(57, 35);
            this.buttonMenuPerfil.TabIndex = 24;
            this.buttonMenuPerfil.Text = "NN";
            this.buttonMenuPerfil.UseVisualStyleBackColor = false;
            this.buttonMenuPerfil.Click += new System.EventHandler(this.buttonMenuPerfil_Click);
            // 
            // TABLERO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Administrador_de_Tareas.Properties.Resources.diagonal;
            this.ClientSize = new System.Drawing.Size(621, 419);
            this.ControlBox = false;
            this.Controls.Add(this.buttonMenuPerfil);
            this.Controls.Add(this.buttonParaCambiarNameTablero);
            this.Controls.Add(this.buttonCancelFilterEtiquetas);
            this.Controls.Add(this.buttonOptionsDONE);
            this.Controls.Add(this.buttonOptionDOING);
            this.Controls.Add(this.buttonOptionsTODO);
            this.Controls.Add(this.buttonAddTareaDONE);
            this.Controls.Add(this.buttonAddTareaDOING);
            this.Controls.Add(this.buttonGoArchivados);
            this.Controls.Add(this.buttonAddTareaTODO);
            this.Controls.Add(this.labelDONE);
            this.Controls.Add(this.labelDOING);
            this.Controls.Add(this.labelTODO);
            this.Controls.Add(this.dgvDONE);
            this.Controls.Add(this.dgvDOING);
            this.Controls.Add(this.dgvTODO);
            this.Controls.Add(this.buttonFiltrarPorEtiqueta);
            this.Controls.Add(this.labelEtiquetas);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonDosOpcionesSegunTableroTengaTeam);
            this.Controls.Add(this.buttonGoHome);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TABLERO";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TABLERO";
            this.TransparencyKey = System.Drawing.Color.ForestGreen;
            this.Load += new System.EventHandler(this.TABLERO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTODO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDOING)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDONE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGoHome;
        private System.Windows.Forms.Button buttonDosOpcionesSegunTableroTengaTeam;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelEtiquetas;
        private System.Windows.Forms.Button buttonFiltrarPorEtiqueta;
        private System.Windows.Forms.DataGridView dgvTODO;
        private System.Windows.Forms.DataGridView dgvDOING;
        private System.Windows.Forms.DataGridView dgvDONE;
        private System.Windows.Forms.Label labelTODO;
        private System.Windows.Forms.Label labelDOING;
        private System.Windows.Forms.Label labelDONE;
        private System.Windows.Forms.Button buttonAddTareaTODO;
        private System.Windows.Forms.Button buttonGoArchivados;
        private System.Windows.Forms.Button buttonAddTareaDOING;
        private System.Windows.Forms.Button buttonAddTareaDONE;
        private System.Windows.Forms.Button buttonOptionsTODO;
        private System.Windows.Forms.Button buttonOptionDOING;
        private System.Windows.Forms.Button buttonOptionsDONE;
        private System.Windows.Forms.Button buttonCancelFilterEtiquetas;
        private System.Windows.Forms.Button buttonParaCambiarNameTablero;
        private System.Windows.Forms.Button buttonMenuPerfil;
    }
}