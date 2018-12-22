namespace Administrador_de_Tareas
{
    partial class VerEditarTAREA
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
            this.labelTituloTarea = new System.Windows.Forms.Label();
            this.labelEnLista = new System.Windows.Forms.Label();
            this.labelNombreListaDeTarea = new System.Windows.Forms.Label();
            this.buttonEditarTitulo = new System.Windows.Forms.Button();
            this.labelDescripTarea = new System.Windows.Forms.Label();
            this.buttonEditarDescripcion = new System.Windows.Forms.Button();
            this.labelDescripcionTarea = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAgregarComent = new System.Windows.Forms.TextBox();
            this.buttonAgregarComent = new System.Windows.Forms.Button();
            this.labelComentarios = new System.Windows.Forms.Label();
            this.dgvComentariosTarea = new System.Windows.Forms.DataGridView();
            this.buttonVerComentario = new System.Windows.Forms.Button();
            this.buttonEditComent = new System.Windows.Forms.Button();
            this.buttonDeleteComent = new System.Windows.Forms.Button();
            this.labelActividades = new System.Windows.Forms.Label();
            this.dgvActividades = new System.Windows.Forms.DataGridView();
            this.cmBoxResponsablesTarea = new System.Windows.Forms.ComboBox();
            this.buttonAddResponsable = new System.Windows.Forms.Button();
            this.labelResponsables = new System.Windows.Forms.Label();
            this.labelEtiquetas = new System.Windows.Forms.Label();
            this.cmBoxEtiquetas = new System.Windows.Forms.ComboBox();
            this.buttonAddEtiquetaAtarea = new System.Windows.Forms.Button();
            this.labelFechaVen = new System.Windows.Forms.Label();
            this.labelFechaVenTextFormato = new System.Windows.Forms.Label();
            this.buttonCraerEditarFechaVenc = new System.Windows.Forms.Button();
            this.labelAcciones = new System.Windows.Forms.Label();
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonArchivar = new System.Windows.Forms.Button();
            this.buttonEliminarTarea = new System.Windows.Forms.Button();
            this.buttonSeguir = new System.Windows.Forms.Button();
            this.labelOnOrOffSeguirTarea = new System.Windows.Forms.Label();
            this.buttonVolverAtablero = new System.Windows.Forms.Button();
            this.buttonEliminarResponsable = new System.Windows.Forms.Button();
            this.buttonEnviar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComentariosTarea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTituloTarea
            // 
            this.labelTituloTarea.AutoSize = true;
            this.labelTituloTarea.BackColor = System.Drawing.SystemColors.Window;
            this.labelTituloTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloTarea.Location = new System.Drawing.Point(64, 18);
            this.labelTituloTarea.Name = "labelTituloTarea";
            this.labelTituloTarea.Size = new System.Drawing.Size(116, 24);
            this.labelTituloTarea.TabIndex = 0;
            this.labelTituloTarea.Text = "TituloTarea";
            // 
            // labelEnLista
            // 
            this.labelEnLista.AutoSize = true;
            this.labelEnLista.BackColor = System.Drawing.SystemColors.Window;
            this.labelEnLista.Location = new System.Drawing.Point(64, 44);
            this.labelEnLista.Name = "labelEnLista";
            this.labelEnLista.Size = new System.Drawing.Size(45, 13);
            this.labelEnLista.TabIndex = 1;
            this.labelEnLista.Text = "En Lista";
            // 
            // labelNombreListaDeTarea
            // 
            this.labelNombreListaDeTarea.AutoSize = true;
            this.labelNombreListaDeTarea.BackColor = System.Drawing.SystemColors.Window;
            this.labelNombreListaDeTarea.Location = new System.Drawing.Point(115, 44);
            this.labelNombreListaDeTarea.Name = "labelNombreListaDeTarea";
            this.labelNombreListaDeTarea.Size = new System.Drawing.Size(94, 13);
            this.labelNombreListaDeTarea.TabIndex = 2;
            this.labelNombreListaDeTarea.Text = "NombreListaTarea";
            // 
            // buttonEditarTitulo
            // 
            this.buttonEditarTitulo.BackColor = System.Drawing.SystemColors.Info;
            this.buttonEditarTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarTitulo.Location = new System.Drawing.Point(25, 19);
            this.buttonEditarTitulo.Name = "buttonEditarTitulo";
            this.buttonEditarTitulo.Size = new System.Drawing.Size(33, 25);
            this.buttonEditarTitulo.TabIndex = 3;
            this.buttonEditarTitulo.Text = "-->";
            this.buttonEditarTitulo.UseVisualStyleBackColor = false;
            this.buttonEditarTitulo.Click += new System.EventHandler(this.buttonEditarTitulo_Click);
            // 
            // labelDescripTarea
            // 
            this.labelDescripTarea.AutoSize = true;
            this.labelDescripTarea.BackColor = System.Drawing.SystemColors.Window;
            this.labelDescripTarea.Location = new System.Drawing.Point(64, 69);
            this.labelDescripTarea.Name = "labelDescripTarea";
            this.labelDescripTarea.Size = new System.Drawing.Size(63, 13);
            this.labelDescripTarea.TabIndex = 4;
            this.labelDescripTarea.Text = "Descripcion";
            // 
            // buttonEditarDescripcion
            // 
            this.buttonEditarDescripcion.BackColor = System.Drawing.SystemColors.Info;
            this.buttonEditarDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarDescripcion.Location = new System.Drawing.Point(25, 65);
            this.buttonEditarDescripcion.Name = "buttonEditarDescripcion";
            this.buttonEditarDescripcion.Size = new System.Drawing.Size(33, 25);
            this.buttonEditarDescripcion.TabIndex = 5;
            this.buttonEditarDescripcion.Text = "-->";
            this.buttonEditarDescripcion.UseVisualStyleBackColor = false;
            this.buttonEditarDescripcion.Click += new System.EventHandler(this.buttonEditarDescripcion_Click);
            // 
            // labelDescripcionTarea
            // 
            this.labelDescripcionTarea.AutoSize = true;
            this.labelDescripcionTarea.BackColor = System.Drawing.SystemColors.Window;
            this.labelDescripcionTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcionTarea.Location = new System.Drawing.Point(64, 92);
            this.labelDescripcionTarea.Name = "labelDescripcionTarea";
            this.labelDescripcionTarea.Size = new System.Drawing.Size(276, 16);
            this.labelDescripcionTarea.TabIndex = 6;
            this.labelDescripcionTarea.Text = "aca aparece descripcion tarea o vacio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(64, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "+ Agregar Comentario";
            // 
            // textBoxAgregarComent
            // 
            this.textBoxAgregarComent.Location = new System.Drawing.Point(67, 160);
            this.textBoxAgregarComent.Name = "textBoxAgregarComent";
            this.textBoxAgregarComent.Size = new System.Drawing.Size(235, 20);
            this.textBoxAgregarComent.TabIndex = 8;
            // 
            // buttonAgregarComent
            // 
            this.buttonAgregarComent.BackColor = System.Drawing.SystemColors.Info;
            this.buttonAgregarComent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarComent.Location = new System.Drawing.Point(308, 158);
            this.buttonAgregarComent.Name = "buttonAgregarComent";
            this.buttonAgregarComent.Size = new System.Drawing.Size(33, 23);
            this.buttonAgregarComent.TabIndex = 9;
            this.buttonAgregarComent.Text = "+";
            this.buttonAgregarComent.UseVisualStyleBackColor = false;
            this.buttonAgregarComent.Click += new System.EventHandler(this.buttonAgregarComent_Click);
            // 
            // labelComentarios
            // 
            this.labelComentarios.AutoSize = true;
            this.labelComentarios.BackColor = System.Drawing.SystemColors.Window;
            this.labelComentarios.Location = new System.Drawing.Point(25, 212);
            this.labelComentarios.Name = "labelComentarios";
            this.labelComentarios.Size = new System.Drawing.Size(65, 13);
            this.labelComentarios.TabIndex = 10;
            this.labelComentarios.Text = "Comentarios";
            // 
            // dgvComentariosTarea
            // 
            this.dgvComentariosTarea.AllowUserToDeleteRows = false;
            this.dgvComentariosTarea.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvComentariosTarea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComentariosTarea.Location = new System.Drawing.Point(25, 228);
            this.dgvComentariosTarea.Name = "dgvComentariosTarea";
            this.dgvComentariosTarea.ReadOnly = true;
            this.dgvComentariosTarea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComentariosTarea.Size = new System.Drawing.Size(404, 108);
            this.dgvComentariosTarea.TabIndex = 11;
            this.dgvComentariosTarea.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComentariosTarea_CellClick);
            this.dgvComentariosTarea.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComentariosTarea_CellContentDoubleClick);
            // 
            // buttonVerComentario
            // 
            this.buttonVerComentario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonVerComentario.Location = new System.Drawing.Point(435, 234);
            this.buttonVerComentario.Name = "buttonVerComentario";
            this.buttonVerComentario.Size = new System.Drawing.Size(51, 23);
            this.buttonVerComentario.TabIndex = 12;
            this.buttonVerComentario.Text = "Ver";
            this.buttonVerComentario.UseVisualStyleBackColor = false;
            this.buttonVerComentario.Click += new System.EventHandler(this.buttonVerComentario_Click);
            // 
            // buttonEditComent
            // 
            this.buttonEditComent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonEditComent.Location = new System.Drawing.Point(437, 263);
            this.buttonEditComent.Name = "buttonEditComent";
            this.buttonEditComent.Size = new System.Drawing.Size(49, 23);
            this.buttonEditComent.TabIndex = 13;
            this.buttonEditComent.Text = "Editar";
            this.buttonEditComent.UseVisualStyleBackColor = false;
            this.buttonEditComent.Click += new System.EventHandler(this.buttonEditComent_Click);
            // 
            // buttonDeleteComent
            // 
            this.buttonDeleteComent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonDeleteComent.Location = new System.Drawing.Point(435, 292);
            this.buttonDeleteComent.Name = "buttonDeleteComent";
            this.buttonDeleteComent.Size = new System.Drawing.Size(51, 23);
            this.buttonDeleteComent.TabIndex = 14;
            this.buttonDeleteComent.Text = "Eliminar";
            this.buttonDeleteComent.UseVisualStyleBackColor = false;
            this.buttonDeleteComent.Click += new System.EventHandler(this.buttonDeleteComent_Click);
            // 
            // labelActividades
            // 
            this.labelActividades.AutoSize = true;
            this.labelActividades.BackColor = System.Drawing.SystemColors.Window;
            this.labelActividades.Location = new System.Drawing.Point(28, 358);
            this.labelActividades.Name = "labelActividades";
            this.labelActividades.Size = new System.Drawing.Size(62, 13);
            this.labelActividades.TabIndex = 15;
            this.labelActividades.Text = "Actividades";
            // 
            // dgvActividades
            // 
            this.dgvActividades.AllowUserToDeleteRows = false;
            this.dgvActividades.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActividades.Location = new System.Drawing.Point(28, 374);
            this.dgvActividades.Name = "dgvActividades";
            this.dgvActividades.ReadOnly = true;
            this.dgvActividades.Size = new System.Drawing.Size(401, 120);
            this.dgvActividades.TabIndex = 16;
            // 
            // cmBoxResponsablesTarea
            // 
            this.cmBoxResponsablesTarea.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmBoxResponsablesTarea.FormattingEnabled = true;
            this.cmBoxResponsablesTarea.Location = new System.Drawing.Point(383, 36);
            this.cmBoxResponsablesTarea.Name = "cmBoxResponsablesTarea";
            this.cmBoxResponsablesTarea.Size = new System.Drawing.Size(121, 21);
            this.cmBoxResponsablesTarea.TabIndex = 17;
            // 
            // buttonAddResponsable
            // 
            this.buttonAddResponsable.BackColor = System.Drawing.SystemColors.Info;
            this.buttonAddResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddResponsable.Location = new System.Drawing.Point(510, 22);
            this.buttonAddResponsable.Name = "buttonAddResponsable";
            this.buttonAddResponsable.Size = new System.Drawing.Size(24, 21);
            this.buttonAddResponsable.TabIndex = 18;
            this.buttonAddResponsable.Text = "+";
            this.buttonAddResponsable.UseVisualStyleBackColor = false;
            this.buttonAddResponsable.Click += new System.EventHandler(this.buttonAddResponsable_Click_1);
            // 
            // labelResponsables
            // 
            this.labelResponsables.AutoSize = true;
            this.labelResponsables.BackColor = System.Drawing.SystemColors.Window;
            this.labelResponsables.Location = new System.Drawing.Point(380, 19);
            this.labelResponsables.Name = "labelResponsables";
            this.labelResponsables.Size = new System.Drawing.Size(74, 13);
            this.labelResponsables.TabIndex = 19;
            this.labelResponsables.Text = "Responsables";
            // 
            // labelEtiquetas
            // 
            this.labelEtiquetas.AutoSize = true;
            this.labelEtiquetas.BackColor = System.Drawing.SystemColors.Window;
            this.labelEtiquetas.Location = new System.Drawing.Point(555, 18);
            this.labelEtiquetas.Name = "labelEtiquetas";
            this.labelEtiquetas.Size = new System.Drawing.Size(51, 13);
            this.labelEtiquetas.TabIndex = 20;
            this.labelEtiquetas.Text = "Etiquetas";
            this.labelEtiquetas.Visible = false;
            // 
            // cmBoxEtiquetas
            // 
            this.cmBoxEtiquetas.FormattingEnabled = true;
            this.cmBoxEtiquetas.Location = new System.Drawing.Point(548, 36);
            this.cmBoxEtiquetas.Name = "cmBoxEtiquetas";
            this.cmBoxEtiquetas.Size = new System.Drawing.Size(92, 21);
            this.cmBoxEtiquetas.TabIndex = 21;
            this.cmBoxEtiquetas.Visible = false;
            // 
            // buttonAddEtiquetaAtarea
            // 
            this.buttonAddEtiquetaAtarea.BackColor = System.Drawing.SystemColors.Info;
            this.buttonAddEtiquetaAtarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddEtiquetaAtarea.Location = new System.Drawing.Point(646, 34);
            this.buttonAddEtiquetaAtarea.Name = "buttonAddEtiquetaAtarea";
            this.buttonAddEtiquetaAtarea.Size = new System.Drawing.Size(30, 23);
            this.buttonAddEtiquetaAtarea.TabIndex = 22;
            this.buttonAddEtiquetaAtarea.Text = "+";
            this.buttonAddEtiquetaAtarea.UseVisualStyleBackColor = false;
            this.buttonAddEtiquetaAtarea.Visible = false;
            // 
            // labelFechaVen
            // 
            this.labelFechaVen.AutoSize = true;
            this.labelFechaVen.BackColor = System.Drawing.SystemColors.Window;
            this.labelFechaVen.Location = new System.Drawing.Point(434, 102);
            this.labelFechaVen.Name = "labelFechaVen";
            this.labelFechaVen.Size = new System.Drawing.Size(119, 13);
            this.labelFechaVen.TabIndex = 23;
            this.labelFechaVen.Text = "Fecha de Vencimiento: ";
            // 
            // labelFechaVenTextFormato
            // 
            this.labelFechaVenTextFormato.AutoSize = true;
            this.labelFechaVenTextFormato.BackColor = System.Drawing.SystemColors.Window;
            this.labelFechaVenTextFormato.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaVenTextFormato.Location = new System.Drawing.Point(432, 125);
            this.labelFechaVenTextFormato.Name = "labelFechaVenTextFormato";
            this.labelFechaVenTextFormato.Size = new System.Drawing.Size(292, 24);
            this.labelFechaVenTextFormato.TabIndex = 24;
            this.labelFechaVenTextFormato.Text = "aparece fecha de vencimiento";
            // 
            // buttonCraerEditarFechaVenc
            // 
            this.buttonCraerEditarFechaVenc.BackColor = System.Drawing.SystemColors.Info;
            this.buttonCraerEditarFechaVenc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCraerEditarFechaVenc.Location = new System.Drawing.Point(385, 125);
            this.buttonCraerEditarFechaVenc.Name = "buttonCraerEditarFechaVenc";
            this.buttonCraerEditarFechaVenc.Size = new System.Drawing.Size(41, 24);
            this.buttonCraerEditarFechaVenc.TabIndex = 25;
            this.buttonCraerEditarFechaVenc.Text = "-->";
            this.buttonCraerEditarFechaVenc.UseVisualStyleBackColor = false;
            this.buttonCraerEditarFechaVenc.Click += new System.EventHandler(this.buttonCraerEditarFechaVenc_Click);
            // 
            // labelAcciones
            // 
            this.labelAcciones.AutoSize = true;
            this.labelAcciones.BackColor = System.Drawing.SystemColors.Window;
            this.labelAcciones.Location = new System.Drawing.Point(555, 200);
            this.labelAcciones.Name = "labelAcciones";
            this.labelAcciones.Size = new System.Drawing.Size(51, 13);
            this.labelAcciones.TabIndex = 26;
            this.labelAcciones.Text = "Acciones";
            // 
            // buttonMove
            // 
            this.buttonMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonMove.Location = new System.Drawing.Point(537, 217);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(94, 28);
            this.buttonMove.TabIndex = 27;
            this.buttonMove.Text = "Mover";
            this.buttonMove.UseVisualStyleBackColor = false;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonArchivar
            // 
            this.buttonArchivar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonArchivar.Location = new System.Drawing.Point(537, 263);
            this.buttonArchivar.Name = "buttonArchivar";
            this.buttonArchivar.Size = new System.Drawing.Size(94, 28);
            this.buttonArchivar.TabIndex = 28;
            this.buttonArchivar.Text = "Archivar";
            this.buttonArchivar.UseVisualStyleBackColor = false;
            this.buttonArchivar.Click += new System.EventHandler(this.buttonArchivar_Click);
            // 
            // buttonEliminarTarea
            // 
            this.buttonEliminarTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonEliminarTarea.Location = new System.Drawing.Point(537, 350);
            this.buttonEliminarTarea.Name = "buttonEliminarTarea";
            this.buttonEliminarTarea.Size = new System.Drawing.Size(94, 28);
            this.buttonEliminarTarea.TabIndex = 29;
            this.buttonEliminarTarea.Text = "Eliminar";
            this.buttonEliminarTarea.UseVisualStyleBackColor = false;
            this.buttonEliminarTarea.Click += new System.EventHandler(this.buttonEliminarTarea_Click);
            // 
            // buttonSeguir
            // 
            this.buttonSeguir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonSeguir.Enabled = false;
            this.buttonSeguir.Location = new System.Drawing.Point(630, 257);
            this.buttonSeguir.Name = "buttonSeguir";
            this.buttonSeguir.Size = new System.Drawing.Size(94, 29);
            this.buttonSeguir.TabIndex = 31;
            this.buttonSeguir.Text = "Seguir";
            this.buttonSeguir.UseVisualStyleBackColor = false;
            this.buttonSeguir.Visible = false;
            this.buttonSeguir.Click += new System.EventHandler(this.buttonSeguir_Click);
            // 
            // labelOnOrOffSeguirTarea
            // 
            this.labelOnOrOffSeguirTarea.AutoSize = true;
            this.labelOnOrOffSeguirTarea.BackColor = System.Drawing.SystemColors.Window;
            this.labelOnOrOffSeguirTarea.Location = new System.Drawing.Point(637, 259);
            this.labelOnOrOffSeguirTarea.Name = "labelOnOrOffSeguirTarea";
            this.labelOnOrOffSeguirTarea.Size = new System.Drawing.Size(21, 13);
            this.labelOnOrOffSeguirTarea.TabIndex = 32;
            this.labelOnOrOffSeguirTarea.Text = "Off";
            this.labelOnOrOffSeguirTarea.Visible = false;
            // 
            // buttonVolverAtablero
            // 
            this.buttonVolverAtablero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonVolverAtablero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolverAtablero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonVolverAtablero.Location = new System.Drawing.Point(533, 411);
            this.buttonVolverAtablero.Name = "buttonVolverAtablero";
            this.buttonVolverAtablero.Size = new System.Drawing.Size(125, 43);
            this.buttonVolverAtablero.TabIndex = 33;
            this.buttonVolverAtablero.Text = "<-- Volver";
            this.buttonVolverAtablero.UseVisualStyleBackColor = false;
            this.buttonVolverAtablero.Click += new System.EventHandler(this.buttonVolverAtablero_Click);
            // 
            // buttonEliminarResponsable
            // 
            this.buttonEliminarResponsable.BackColor = System.Drawing.SystemColors.Info;
            this.buttonEliminarResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarResponsable.Location = new System.Drawing.Point(510, 44);
            this.buttonEliminarResponsable.Name = "buttonEliminarResponsable";
            this.buttonEliminarResponsable.Size = new System.Drawing.Size(24, 21);
            this.buttonEliminarResponsable.TabIndex = 34;
            this.buttonEliminarResponsable.Text = "-";
            this.buttonEliminarResponsable.UseVisualStyleBackColor = false;
            this.buttonEliminarResponsable.Click += new System.EventHandler(this.buttonEliminarResponsable_Click);
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonEnviar.Location = new System.Drawing.Point(537, 308);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(94, 28);
            this.buttonEnviar.TabIndex = 35;
            this.buttonEnviar.Text = "Enviar";
            this.buttonEnviar.UseVisualStyleBackColor = false;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonEnviar_Click);
            // 
            // VerEditarTAREA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Administrador_de_Tareas.Properties.Resources.muchasPalmeras;
            this.ClientSize = new System.Drawing.Size(688, 506);
            this.ControlBox = false;
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.buttonEliminarResponsable);
            this.Controls.Add(this.buttonVolverAtablero);
            this.Controls.Add(this.labelOnOrOffSeguirTarea);
            this.Controls.Add(this.buttonSeguir);
            this.Controls.Add(this.buttonEliminarTarea);
            this.Controls.Add(this.buttonArchivar);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.labelAcciones);
            this.Controls.Add(this.buttonCraerEditarFechaVenc);
            this.Controls.Add(this.labelFechaVenTextFormato);
            this.Controls.Add(this.labelFechaVen);
            this.Controls.Add(this.buttonAddEtiquetaAtarea);
            this.Controls.Add(this.cmBoxEtiquetas);
            this.Controls.Add(this.labelEtiquetas);
            this.Controls.Add(this.labelResponsables);
            this.Controls.Add(this.buttonAddResponsable);
            this.Controls.Add(this.cmBoxResponsablesTarea);
            this.Controls.Add(this.dgvActividades);
            this.Controls.Add(this.labelActividades);
            this.Controls.Add(this.buttonDeleteComent);
            this.Controls.Add(this.buttonEditComent);
            this.Controls.Add(this.buttonVerComentario);
            this.Controls.Add(this.dgvComentariosTarea);
            this.Controls.Add(this.labelComentarios);
            this.Controls.Add(this.buttonAgregarComent);
            this.Controls.Add(this.textBoxAgregarComent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDescripcionTarea);
            this.Controls.Add(this.buttonEditarDescripcion);
            this.Controls.Add(this.labelDescripTarea);
            this.Controls.Add(this.buttonEditarTitulo);
            this.Controls.Add(this.labelNombreListaDeTarea);
            this.Controls.Add(this.labelEnLista);
            this.Controls.Add(this.labelTituloTarea);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VerEditarTAREA";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TAREA";
            this.Load += new System.EventHandler(this.VerEditarTAREA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComentariosTarea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTituloTarea;
        private System.Windows.Forms.Label labelEnLista;
        private System.Windows.Forms.Label labelNombreListaDeTarea;
        private System.Windows.Forms.Button buttonEditarTitulo;
        private System.Windows.Forms.Label labelDescripTarea;
        private System.Windows.Forms.Button buttonEditarDescripcion;
        private System.Windows.Forms.Label labelDescripcionTarea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAgregarComent;
        private System.Windows.Forms.Button buttonAgregarComent;
        private System.Windows.Forms.Label labelComentarios;
        private System.Windows.Forms.DataGridView dgvComentariosTarea;
        private System.Windows.Forms.Button buttonVerComentario;
        private System.Windows.Forms.Button buttonEditComent;
        private System.Windows.Forms.Button buttonDeleteComent;
        private System.Windows.Forms.Label labelActividades;
        private System.Windows.Forms.DataGridView dgvActividades;
        private System.Windows.Forms.ComboBox cmBoxResponsablesTarea;
        private System.Windows.Forms.Button buttonAddResponsable;
        private System.Windows.Forms.Label labelResponsables;
        private System.Windows.Forms.Label labelEtiquetas;
        private System.Windows.Forms.ComboBox cmBoxEtiquetas;
        private System.Windows.Forms.Button buttonAddEtiquetaAtarea;
        private System.Windows.Forms.Label labelFechaVen;
        private System.Windows.Forms.Label labelFechaVenTextFormato;
        private System.Windows.Forms.Button buttonCraerEditarFechaVenc;
        private System.Windows.Forms.Label labelAcciones;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button buttonArchivar;
        private System.Windows.Forms.Button buttonEliminarTarea;
        private System.Windows.Forms.Button buttonSeguir;
        private System.Windows.Forms.Label labelOnOrOffSeguirTarea;
        private System.Windows.Forms.Button buttonVolverAtablero;
        private System.Windows.Forms.Button buttonEliminarResponsable;
        private System.Windows.Forms.Button buttonEnviar;
    }
}