namespace Administrador_de_Tareas
{
    partial class EditarPerfilUsuario
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
            this.labelNewPassOne = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelPasswordActual = new System.Windows.Forms.Label();
            this.labelIniciales = new System.Windows.Forms.Label();
            this.labelNewPasswordRepit = new System.Windows.Forms.Label();
            this.textBoxInicialesUsuario = new System.Windows.Forms.TextBox();
            this.textBoxNameUser = new System.Windows.Forms.TextBox();
            this.textBoxMailUser = new System.Windows.Forms.TextBox();
            this.textBoxOldPasswordUser = new System.Windows.Forms.TextBox();
            this.textBoxNewPasswordUser = new System.Windows.Forms.TextBox();
            this.textBoxConfirmNewPassUser = new System.Windows.Forms.TextBox();
            this.buttonGuardarCambiosUser = new System.Windows.Forms.Button();
            this.linkLabelCambiarPassword = new System.Windows.Forms.LinkLabel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNewPassOne
            // 
            this.labelNewPassOne.AutoSize = true;
            this.labelNewPassOne.Location = new System.Drawing.Point(28, 202);
            this.labelNewPassOne.Name = "labelNewPassOne";
            this.labelNewPassOne.Size = new System.Drawing.Size(160, 13);
            this.labelNewPassOne.TabIndex = 0;
            this.labelNewPassOne.Text = "Introduzca su nueva contraseña";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(29, 48);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Nombre";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(28, 87);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(26, 13);
            this.labelMail.TabIndex = 2;
            this.labelMail.Text = "Mail";
            // 
            // labelPasswordActual
            // 
            this.labelPasswordActual.AutoSize = true;
            this.labelPasswordActual.Location = new System.Drawing.Point(29, 163);
            this.labelPasswordActual.Name = "labelPasswordActual";
            this.labelPasswordActual.Size = new System.Drawing.Size(159, 13);
            this.labelPasswordActual.TabIndex = 3;
            this.labelPasswordActual.Text = "Introduzca su contraseña actual";
            // 
            // labelIniciales
            // 
            this.labelIniciales.AutoSize = true;
            this.labelIniciales.Location = new System.Drawing.Point(27, 9);
            this.labelIniciales.Name = "labelIniciales";
            this.labelIniciales.Size = new System.Drawing.Size(45, 13);
            this.labelIniciales.TabIndex = 4;
            this.labelIniciales.Text = "Iniciales";
            // 
            // labelNewPasswordRepit
            // 
            this.labelNewPasswordRepit.AutoSize = true;
            this.labelNewPasswordRepit.Location = new System.Drawing.Point(28, 241);
            this.labelNewPasswordRepit.Name = "labelNewPasswordRepit";
            this.labelNewPasswordRepit.Size = new System.Drawing.Size(141, 13);
            this.labelNewPasswordRepit.TabIndex = 5;
            this.labelNewPasswordRepit.Text = "Repita su nueva contraseña";
            // 
            // textBoxInicialesUsuario
            // 
            this.textBoxInicialesUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxInicialesUsuario.Location = new System.Drawing.Point(30, 25);
            this.textBoxInicialesUsuario.MaxLength = 2;
            this.textBoxInicialesUsuario.Name = "textBoxInicialesUsuario";
            this.textBoxInicialesUsuario.Size = new System.Drawing.Size(53, 20);
            this.textBoxInicialesUsuario.TabIndex = 6;
            // 
            // textBoxNameUser
            // 
            this.textBoxNameUser.Location = new System.Drawing.Point(32, 64);
            this.textBoxNameUser.Name = "textBoxNameUser";
            this.textBoxNameUser.Size = new System.Drawing.Size(224, 20);
            this.textBoxNameUser.TabIndex = 7;
            // 
            // textBoxMailUser
            // 
            this.textBoxMailUser.Location = new System.Drawing.Point(30, 103);
            this.textBoxMailUser.Name = "textBoxMailUser";
            this.textBoxMailUser.Size = new System.Drawing.Size(224, 20);
            this.textBoxMailUser.TabIndex = 8;
            this.textBoxMailUser.Leave += new System.EventHandler(this.textBoxMailUser_Leave);
            // 
            // textBoxOldPasswordUser
            // 
            this.textBoxOldPasswordUser.Location = new System.Drawing.Point(31, 179);
            this.textBoxOldPasswordUser.Name = "textBoxOldPasswordUser";
            this.textBoxOldPasswordUser.PasswordChar = '°';
            this.textBoxOldPasswordUser.Size = new System.Drawing.Size(224, 20);
            this.textBoxOldPasswordUser.TabIndex = 9;
            this.textBoxOldPasswordUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOldPasswordUser_KeyPress);
            this.textBoxOldPasswordUser.Leave += new System.EventHandler(this.textBoxOldPasswordUser_Leave);
            // 
            // textBoxNewPasswordUser
            // 
            this.textBoxNewPasswordUser.Location = new System.Drawing.Point(31, 218);
            this.textBoxNewPasswordUser.Name = "textBoxNewPasswordUser";
            this.textBoxNewPasswordUser.PasswordChar = '°';
            this.textBoxNewPasswordUser.Size = new System.Drawing.Size(224, 20);
            this.textBoxNewPasswordUser.TabIndex = 10;
            this.textBoxNewPasswordUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewPasswordUser_KeyPress);
            this.textBoxNewPasswordUser.Leave += new System.EventHandler(this.textBoxNewPasswordUser_Leave);
            // 
            // textBoxConfirmNewPassUser
            // 
            this.textBoxConfirmNewPassUser.Location = new System.Drawing.Point(31, 257);
            this.textBoxConfirmNewPassUser.Name = "textBoxConfirmNewPassUser";
            this.textBoxConfirmNewPassUser.PasswordChar = '°';
            this.textBoxConfirmNewPassUser.Size = new System.Drawing.Size(224, 20);
            this.textBoxConfirmNewPassUser.TabIndex = 11;
            this.textBoxConfirmNewPassUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxConfirmNewPassUser_KeyPress);
            this.textBoxConfirmNewPassUser.Leave += new System.EventHandler(this.textBoxConfirmNewPassUser_Leave);
            // 
            // buttonGuardarCambiosUser
            // 
            this.buttonGuardarCambiosUser.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonGuardarCambiosUser.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardarCambiosUser.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonGuardarCambiosUser.Location = new System.Drawing.Point(180, 283);
            this.buttonGuardarCambiosUser.Name = "buttonGuardarCambiosUser";
            this.buttonGuardarCambiosUser.Size = new System.Drawing.Size(75, 32);
            this.buttonGuardarCambiosUser.TabIndex = 12;
            this.buttonGuardarCambiosUser.Text = "Guardar";
            this.buttonGuardarCambiosUser.UseVisualStyleBackColor = false;
            this.buttonGuardarCambiosUser.Click += new System.EventHandler(this.buttonGuardarCambiosUser_Click);
            // 
            // linkLabelCambiarPassword
            // 
            this.linkLabelCambiarPassword.AutoSize = true;
            this.linkLabelCambiarPassword.Location = new System.Drawing.Point(29, 139);
            this.linkLabelCambiarPassword.Name = "linkLabelCambiarPassword";
            this.linkLabelCambiarPassword.Size = new System.Drawing.Size(101, 13);
            this.linkLabelCambiarPassword.TabIndex = 14;
            this.linkLabelCambiarPassword.TabStop = true;
            this.linkLabelCambiarPassword.Text = "Cambiar contraseña";
            this.linkLabelCambiarPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCambiarPassword_LinkClicked);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonCancel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonCancel.Location = new System.Drawing.Point(30, 283);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 32);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // EditarPerfilUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(286, 327);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.linkLabelCambiarPassword);
            this.Controls.Add(this.buttonGuardarCambiosUser);
            this.Controls.Add(this.textBoxConfirmNewPassUser);
            this.Controls.Add(this.textBoxNewPasswordUser);
            this.Controls.Add(this.textBoxOldPasswordUser);
            this.Controls.Add(this.textBoxMailUser);
            this.Controls.Add(this.textBoxNameUser);
            this.Controls.Add(this.textBoxInicialesUsuario);
            this.Controls.Add(this.labelNewPasswordRepit);
            this.Controls.Add(this.labelIniciales);
            this.Controls.Add(this.labelPasswordActual);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelNewPassOne);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditarPerfilUsuario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editar Perfil";
            this.Load += new System.EventHandler(this.EditarPerfilUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNewPassOne;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelPasswordActual;
        private System.Windows.Forms.Label labelIniciales;
        private System.Windows.Forms.Label labelNewPasswordRepit;
        private System.Windows.Forms.TextBox textBoxInicialesUsuario;
        private System.Windows.Forms.TextBox textBoxNameUser;
        private System.Windows.Forms.TextBox textBoxMailUser;
        private System.Windows.Forms.TextBox textBoxOldPasswordUser;
        private System.Windows.Forms.TextBox textBoxNewPasswordUser;
        private System.Windows.Forms.TextBox textBoxConfirmNewPassUser;
        private System.Windows.Forms.Button buttonGuardarCambiosUser;
        private System.Windows.Forms.LinkLabel linkLabelCambiarPassword;
        private System.Windows.Forms.Button buttonCancel;
    }
}