namespace Administrador_de_Tareas
{
    partial class ARCHIVADOS
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
            this.dgvArchivadosPorTablero = new System.Windows.Forms.DataGridView();
            this.buttonDevolverAEstadoAnterior = new System.Windows.Forms.Button();
            this.buttonEliminarTareaArchivada = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivadosPorTablero)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArchivadosPorTablero
            // 
            this.dgvArchivadosPorTablero.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvArchivadosPorTablero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArchivadosPorTablero.Location = new System.Drawing.Point(12, 27);
            this.dgvArchivadosPorTablero.Name = "dgvArchivadosPorTablero";
            this.dgvArchivadosPorTablero.Size = new System.Drawing.Size(166, 249);
            this.dgvArchivadosPorTablero.TabIndex = 0;
            // 
            // buttonDevolverAEstadoAnterior
            // 
            this.buttonDevolverAEstadoAnterior.Location = new System.Drawing.Point(189, 80);
            this.buttonDevolverAEstadoAnterior.Name = "buttonDevolverAEstadoAnterior";
            this.buttonDevolverAEstadoAnterior.Size = new System.Drawing.Size(84, 39);
            this.buttonDevolverAEstadoAnterior.TabIndex = 1;
            this.buttonDevolverAEstadoAnterior.Text = "Enviar a tablero";
            this.buttonDevolverAEstadoAnterior.UseVisualStyleBackColor = true;
            this.buttonDevolverAEstadoAnterior.Click += new System.EventHandler(this.buttonDevolverAEstadoAnterior_Click);
            // 
            // buttonEliminarTareaArchivada
            // 
            this.buttonEliminarTareaArchivada.Location = new System.Drawing.Point(189, 125);
            this.buttonEliminarTareaArchivada.Name = "buttonEliminarTareaArchivada";
            this.buttonEliminarTareaArchivada.Size = new System.Drawing.Size(84, 40);
            this.buttonEliminarTareaArchivada.TabIndex = 2;
            this.buttonEliminarTareaArchivada.Text = "Eliminar";
            this.buttonEliminarTareaArchivada.UseVisualStyleBackColor = true;
            // 
            // ARCHIVADOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(285, 312);
            this.Controls.Add(this.buttonEliminarTareaArchivada);
            this.Controls.Add(this.buttonDevolverAEstadoAnterior);
            this.Controls.Add(this.dgvArchivadosPorTablero);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ARCHIVADOS";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tareas Archivadas";
            this.Load += new System.EventHandler(this.ARCHIVADOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivadosPorTablero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArchivadosPorTablero;
        private System.Windows.Forms.Button buttonDevolverAEstadoAnterior;
        private System.Windows.Forms.Button buttonEliminarTareaArchivada;
    }
}