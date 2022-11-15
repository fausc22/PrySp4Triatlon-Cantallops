namespace PrySp4Triatlon_Cantallops
{
    partial class FrmTriatlon
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnDeterminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.picGanadores = new System.Windows.Forms.PictureBox();
            this.dgvParticipantes = new System.Windows.Forms.DataGridView();
            this.Participante6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Participante5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Participante4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Participante3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Participante2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Participante1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prueba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPosiciones = new System.Windows.Forms.DataGridView();
            this.Puntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pais1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGanadores = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.País = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picGanadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosiciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGanadores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(814, 195);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(104, 37);
            this.btnAsignar.TabIndex = 4;
            this.btnAsignar.Text = "Asignar Participantes";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnDeterminar
            // 
            this.btnDeterminar.Location = new System.Drawing.Point(814, 248);
            this.btnDeterminar.Name = "btnDeterminar";
            this.btnDeterminar.Size = new System.Drawing.Size(104, 38);
            this.btnDeterminar.TabIndex = 5;
            this.btnDeterminar.Text = "Determinar Ganadores";
            this.btnDeterminar.UseVisualStyleBackColor = true;
            this.btnDeterminar.Click += new System.EventHandler(this.btnDeterminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(814, 310);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 35);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // picGanadores
            // 
            this.picGanadores.Location = new System.Drawing.Point(634, 411);
            this.picGanadores.Name = "picGanadores";
            this.picGanadores.Size = new System.Drawing.Size(100, 50);
            this.picGanadores.TabIndex = 7;
            this.picGanadores.TabStop = false;
            // 
            // dgvParticipantes
            // 
            this.dgvParticipantes.AllowUserToAddRows = false;
            this.dgvParticipantes.AllowUserToDeleteRows = false;
            this.dgvParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Nombre,
            this.País});
            this.dgvParticipantes.Location = new System.Drawing.Point(12, 27);
            this.dgvParticipantes.Name = "dgvParticipantes";
            this.dgvParticipantes.Size = new System.Drawing.Size(594, 160);
            this.dgvParticipantes.TabIndex = 0;
            this.dgvParticipantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Participante6
            // 
            this.Participante6.HeaderText = "Participante 6";
            this.Participante6.Name = "Participante6";
            // 
            // Participante5
            // 
            this.Participante5.HeaderText = "Participante 5";
            this.Participante5.Name = "Participante5";
            // 
            // Participante4
            // 
            this.Participante4.HeaderText = "Participante 4";
            this.Participante4.Name = "Participante4";
            // 
            // Participante3
            // 
            this.Participante3.HeaderText = "Participante 3";
            this.Participante3.Name = "Participante3";
            // 
            // Participante2
            // 
            this.Participante2.HeaderText = "Participante 2";
            this.Participante2.Name = "Participante2";
            // 
            // Participante1
            // 
            this.Participante1.HeaderText = "Participante 1";
            this.Participante1.Name = "Participante1";
            // 
            // Prueba
            // 
            this.Prueba.HeaderText = "Prueba";
            this.Prueba.Name = "Prueba";
            // 
            // dgvPosiciones
            // 
            this.dgvPosiciones.AllowUserToAddRows = false;
            this.dgvPosiciones.AllowUserToDeleteRows = false;
            this.dgvPosiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosiciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Prueba,
            this.Participante1,
            this.Participante2,
            this.Participante3,
            this.Participante4,
            this.Participante5,
            this.Participante6});
            this.dgvPosiciones.Location = new System.Drawing.Point(12, 242);
            this.dgvPosiciones.Name = "dgvPosiciones";
            this.dgvPosiciones.Size = new System.Drawing.Size(745, 94);
            this.dgvPosiciones.TabIndex = 1;
            // 
            // Puntos
            // 
            this.Puntos.HeaderText = "Puntos";
            this.Puntos.Name = "Puntos";
            // 
            // Pais1
            // 
            this.Pais1.HeaderText = "País";
            this.Pais1.Name = "Pais1";
            // 
            // Nombre1
            // 
            this.Nombre1.HeaderText = "Nombre";
            this.Nombre1.Name = "Nombre1";
            // 
            // Puesto
            // 
            this.Puesto.HeaderText = "Puesto";
            this.Puesto.Name = "Puesto";
            // 
            // dgvGanadores
            // 
            this.dgvGanadores.AllowUserToAddRows = false;
            this.dgvGanadores.AllowUserToDeleteRows = false;
            this.dgvGanadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGanadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Puesto,
            this.Nombre1,
            this.Pais1,
            this.Puntos});
            this.dgvGanadores.Location = new System.Drawing.Point(12, 363);
            this.dgvGanadores.Name = "dgvGanadores";
            this.dgvGanadores.Size = new System.Drawing.Size(443, 98);
            this.dgvGanadores.TabIndex = 2;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 250;
            // 
            // País
            // 
            this.País.HeaderText = "País";
            this.País.Name = "País";
            this.País.Width = 200;
            // 
            // FrmTriatlon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 575);
            this.Controls.Add(this.picGanadores);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDeterminar);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.dgvGanadores);
            this.Controls.Add(this.dgvPosiciones);
            this.Controls.Add(this.dgvParticipantes);
            this.Name = "FrmTriatlon";
            this.Text = "Triatlon";
            this.Load += new System.EventHandler(this.FrmTriatlon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGanadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosiciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGanadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnDeterminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox picGanadores;
        private System.Windows.Forms.DataGridView dgvParticipantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Participante6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Participante5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Participante4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Participante3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Participante2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Participante1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prueba;
        private System.Windows.Forms.DataGridView dgvPosiciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pais1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
        private System.Windows.Forms.DataGridView dgvGanadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn País;
    }
}

