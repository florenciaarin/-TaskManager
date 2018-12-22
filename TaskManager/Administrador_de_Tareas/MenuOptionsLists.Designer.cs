namespace Administrador_de_Tareas
{
    partial class MenuOptionsLists
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
            this.labelSort = new System.Windows.Forms.Label();
            this.labelMoverLista = new System.Windows.Forms.Label();
            this.buttonSortByNewestDate = new System.Windows.Forms.Button();
            this.buttonSortByDateOldestFirst = new System.Windows.Forms.Button();
            this.buttonSortByNextDueDates = new System.Windows.Forms.Button();
            this.comboBoxListasDisponibesParaMover = new System.Windows.Forms.ComboBox();
            this.buttonMoverTodoAotraList = new System.Windows.Forms.Button();
            this.buttonArchivarTodoDeLaList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSort
            // 
            this.labelSort.AutoSize = true;
            this.labelSort.Location = new System.Drawing.Point(24, 35);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(72, 13);
            this.labelSort.TabIndex = 0;
            this.labelSort.Text = "Ordenar por...";
            // 
            // labelMoverLista
            // 
            this.labelMoverLista.AutoSize = true;
            this.labelMoverLista.Location = new System.Drawing.Point(24, 170);
            this.labelMoverLista.Name = "labelMoverLista";
            this.labelMoverLista.Size = new System.Drawing.Size(158, 13);
            this.labelMoverLista.TabIndex = 1;
            this.labelMoverLista.Text = "Mover todas las tareas a la lista:";
            // 
            // buttonSortByNewestDate
            // 
            this.buttonSortByNewestDate.Location = new System.Drawing.Point(41, 69);
            this.buttonSortByNewestDate.Name = "buttonSortByNewestDate";
            this.buttonSortByNewestDate.Size = new System.Drawing.Size(232, 23);
            this.buttonSortByNewestDate.TabIndex = 2;
            this.buttonSortByNewestDate.Text = "Fecha de creación ( más nuevas primero )";
            this.buttonSortByNewestDate.UseVisualStyleBackColor = true;
            // 
            // buttonSortByDateOldestFirst
            // 
            this.buttonSortByDateOldestFirst.Location = new System.Drawing.Point(41, 98);
            this.buttonSortByDateOldestFirst.Name = "buttonSortByDateOldestFirst";
            this.buttonSortByDateOldestFirst.Size = new System.Drawing.Size(232, 23);
            this.buttonSortByDateOldestFirst.TabIndex = 3;
            this.buttonSortByDateOldestFirst.Text = "Fecha de creación ( más viejas primero )";
            this.buttonSortByDateOldestFirst.UseVisualStyleBackColor = true;
            // 
            // buttonSortByNextDueDates
            // 
            this.buttonSortByNextDueDates.Location = new System.Drawing.Point(41, 127);
            this.buttonSortByNextDueDates.Name = "buttonSortByNextDueDates";
            this.buttonSortByNextDueDates.Size = new System.Drawing.Size(232, 23);
            this.buttonSortByNextDueDates.TabIndex = 4;
            this.buttonSortByNextDueDates.Text = "Fecha Vencimiento ( próximas a vencer )";
            this.buttonSortByNextDueDates.UseVisualStyleBackColor = true;
            // 
            // comboBoxListasDisponibesParaMover
            // 
            this.comboBoxListasDisponibesParaMover.FormattingEnabled = true;
            this.comboBoxListasDisponibesParaMover.Location = new System.Drawing.Point(41, 198);
            this.comboBoxListasDisponibesParaMover.Name = "comboBoxListasDisponibesParaMover";
            this.comboBoxListasDisponibesParaMover.Size = new System.Drawing.Size(121, 21);
            this.comboBoxListasDisponibesParaMover.TabIndex = 5;
            // 
            // buttonMoverTodoAotraList
            // 
            this.buttonMoverTodoAotraList.Location = new System.Drawing.Point(175, 198);
            this.buttonMoverTodoAotraList.Name = "buttonMoverTodoAotraList";
            this.buttonMoverTodoAotraList.Size = new System.Drawing.Size(75, 23);
            this.buttonMoverTodoAotraList.TabIndex = 6;
            this.buttonMoverTodoAotraList.Text = "Mover";
            this.buttonMoverTodoAotraList.UseVisualStyleBackColor = true;
            // 
            // buttonArchivarTodoDeLaList
            // 
            this.buttonArchivarTodoDeLaList.Location = new System.Drawing.Point(41, 247);
            this.buttonArchivarTodoDeLaList.Name = "buttonArchivarTodoDeLaList";
            this.buttonArchivarTodoDeLaList.Size = new System.Drawing.Size(232, 23);
            this.buttonArchivarTodoDeLaList.TabIndex = 7;
            this.buttonArchivarTodoDeLaList.Text = "Archivar todas las tareas";
            this.buttonArchivarTodoDeLaList.UseVisualStyleBackColor = true;
            // 
            // MenuOptionsLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(311, 299);
            this.Controls.Add(this.buttonArchivarTodoDeLaList);
            this.Controls.Add(this.buttonMoverTodoAotraList);
            this.Controls.Add(this.comboBoxListasDisponibesParaMover);
            this.Controls.Add(this.buttonSortByNextDueDates);
            this.Controls.Add(this.buttonSortByDateOldestFirst);
            this.Controls.Add(this.buttonSortByNewestDate);
            this.Controls.Add(this.labelMoverLista);
            this.Controls.Add(this.labelSort);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuOptionsLists";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opciones Lista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSort;
        private System.Windows.Forms.Label labelMoverLista;
        private System.Windows.Forms.Button buttonSortByNewestDate;
        private System.Windows.Forms.Button buttonSortByDateOldestFirst;
        private System.Windows.Forms.Button buttonSortByNextDueDates;
        private System.Windows.Forms.ComboBox comboBoxListasDisponibesParaMover;
        private System.Windows.Forms.Button buttonMoverTodoAotraList;
        private System.Windows.Forms.Button buttonArchivarTodoDeLaList;
    }
}