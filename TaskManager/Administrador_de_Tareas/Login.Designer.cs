namespace Administrador_de_Tareas
{
    partial class Login
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
            this.textBoxLoginconmail = new System.Windows.Forms.TextBox();
            this.textBoxPassw = new System.Windows.Forms.TextBox();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.labeliniciarsesion = new System.Windows.Forms.Label();
            this.linkLabelNewUser = new System.Windows.Forms.LinkLabel();
            this.linkLabelSalirApp = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // textBoxLoginconmail
            // 
            this.textBoxLoginconmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxLoginconmail.Location = new System.Drawing.Point(236, 116);
            this.textBoxLoginconmail.Name = "textBoxLoginconmail";
            this.textBoxLoginconmail.Size = new System.Drawing.Size(219, 20);
            this.textBoxLoginconmail.TabIndex = 0;
            this.textBoxLoginconmail.Text = "ingresar mail";
            // 
            // textBoxPassw
            // 
            this.textBoxPassw.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxPassw.Location = new System.Drawing.Point(236, 159);
            this.textBoxPassw.Name = "textBoxPassw";
            this.textBoxPassw.Size = new System.Drawing.Size(219, 20);
            this.textBoxPassw.TabIndex = 1;
            this.textBoxPassw.Text = "ingresar contraseña";
            this.textBoxPassw.TextChanged += new System.EventHandler(this.textBoxPassw_TextChanged);
            this.textBoxPassw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPassw_KeyPress);
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIngresar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonIngresar.Location = new System.Drawing.Point(236, 196);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(75, 23);
            this.buttonIngresar.TabIndex = 2;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = false;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // labeliniciarsesion
            // 
            this.labeliniciarsesion.AutoSize = true;
            this.labeliniciarsesion.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.labeliniciarsesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeliniciarsesion.Location = new System.Drawing.Point(233, 89);
            this.labeliniciarsesion.Name = "labeliniciarsesion";
            this.labeliniciarsesion.Size = new System.Drawing.Size(88, 16);
            this.labeliniciarsesion.TabIndex = 3;
            this.labeliniciarsesion.Text = "Iniciar Sesión";
            // 
            // linkLabelNewUser
            // 
            this.linkLabelNewUser.AutoSize = true;
            this.linkLabelNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelNewUser.Location = new System.Drawing.Point(367, 200);
            this.linkLabelNewUser.Name = "linkLabelNewUser";
            this.linkLabelNewUser.Size = new System.Drawing.Size(88, 15);
            this.linkLabelNewUser.TabIndex = 4;
            this.linkLabelNewUser.TabStop = true;
            this.linkLabelNewUser.Text = "Nuevo Usuario";
            this.linkLabelNewUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelNewUser_LinkClicked);
            // 
            // linkLabelSalirApp
            // 
            this.linkLabelSalirApp.ActiveLinkColor = System.Drawing.Color.Gray;
            this.linkLabelSalirApp.AutoSize = true;
            this.linkLabelSalirApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelSalirApp.Location = new System.Drawing.Point(653, 9);
            this.linkLabelSalirApp.Name = "linkLabelSalirApp";
            this.linkLabelSalirApp.Size = new System.Drawing.Size(51, 18);
            this.linkLabelSalirApp.TabIndex = 5;
            this.linkLabelSalirApp.TabStop = true;
            this.linkLabelSalirApp.Text = "Salir X";
            this.linkLabelSalirApp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSalirApp_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Administrador_de_Tareas.Properties.Resources.holaPalmera;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.ControlBox = false;
            this.Controls.Add(this.linkLabelSalirApp);
            this.Controls.Add(this.linkLabelNewUser);
            this.Controls.Add(this.labeliniciarsesion);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.textBoxPassw);
            this.Controls.Add(this.textBoxLoginconmail);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLoginconmail;
        private System.Windows.Forms.TextBox textBoxPassw;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.Label labeliniciarsesion;
        private System.Windows.Forms.LinkLabel linkLabelNewUser;
        private System.Windows.Forms.LinkLabel linkLabelSalirApp;
    }
}