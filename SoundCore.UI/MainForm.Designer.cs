#nullable disable
// Archivo generado por el Diseñador: declara y posiciona los controles.
// La lógica de negocio vive en MainForm.cs (con Nullable habilitado).
namespace SoundCore.UI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        // --- Panel superior: registro de pista ---
        private GroupBox grpRegistro;
        private Label lblTitulo;
        private TextBox txtTitle;
        private Label lblArtista;
        private TextBox txtArtista;
        private Label lblBpm;
        private NumericUpDown numBpm;
        private Label lblDuracion;
        private NumericUpDown numDuracion;
        private RadioButton OwnRB;
        private RadioButton rbLinkedList;
        private RadioButton rbList;

        // --- Panel izquierdo: acciones de cola ---
        private GroupBox grpAcciones;
        private Button btnEncolarFinal;
        private Button btnReproducirSiguiente;
        private Button btnAvanzar;
        private Button btnInvertir;
        private Button btnOrdenarBpm;
        private Button btnPurgar;

        // --- Panel derecho: playlist visual / cola en vivo ---
        private GroupBox grpPlaylist;
        private Label lblNowPlaying;
        private DataGridView dgvQueue;
        private Label lblEstadisticas;

        // --- Panel inferior: benchmark y telemetría ---
        private GroupBox grpBenchmark;
        private Label lblCantidadStress;
        private NumericUpDown numStress;
        private Button btnBenchmark;
        private TextBox txtResultadosBenchmark;

        private void InitializeComponent()
        {
            grpRegistro = new GroupBox();
            lblTitulo = new Label();
            txtTitle = new TextBox();
            lblArtista = new Label();
            txtArtista = new TextBox();
            lblBpm = new Label();
            numBpm = new NumericUpDown();
            lblDuracion = new Label();
            numDuracion = new NumericUpDown();
            OwnRB = new RadioButton();
            rbLinkedList = new RadioButton();
            rbList = new RadioButton();
            grpAcciones = new GroupBox();
            btnEncolarFinal = new Button();
            btnReproducirSiguiente = new Button();
            btnAvanzar = new Button();
            btnInvertir = new Button();
            btnOrdenarBpm = new Button();
            btnPurgar = new Button();
            grpPlaylist = new GroupBox();
            lblNowPlaying = new Label();
            dgvQueue = new DataGridView();
            lblEstadisticas = new Label();
            grpBenchmark = new GroupBox();
            lblCantidadStress = new Label();
            numStress = new NumericUpDown();
            btnBenchmark = new Button();
            txtResultadosBenchmark = new TextBox();
            grpRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numBpm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDuracion).BeginInit();
            grpAcciones.SuspendLayout();
            grpPlaylist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQueue).BeginInit();
            grpBenchmark.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numStress).BeginInit();
            SuspendLayout();
            // 
            // grpRegistro
            // 
            grpRegistro.Controls.Add(lblTitulo);
            grpRegistro.Controls.Add(txtTitle);
            grpRegistro.Controls.Add(lblArtista);
            grpRegistro.Controls.Add(txtArtista);
            grpRegistro.Controls.Add(lblBpm);
            grpRegistro.Controls.Add(numBpm);
            grpRegistro.Controls.Add(lblDuracion);
            grpRegistro.Controls.Add(numDuracion);
            grpRegistro.Controls.Add(OwnRB);
            grpRegistro.Controls.Add(rbLinkedList);
            grpRegistro.Controls.Add(rbList);
            grpRegistro.Location = new Point(14, 16);
            grpRegistro.Margin = new Padding(3, 4, 3, 4);
            grpRegistro.Name = "grpRegistro";
            grpRegistro.Padding = new Padding(3, 4, 3, 4);
            grpRegistro.Size = new Size(1143, 133);
            grpRegistro.TabIndex = 0;
            grpRegistro.TabStop = false;
            grpRegistro.Text = "PANEL SUPERIOR: REGISTRO DE PISTA";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(17, 40);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(50, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Título:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(74, 36);
            txtTitle.Margin = new Padding(3, 4, 3, 4);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(205, 27);
            txtTitle.TabIndex = 0;
            // 
            // lblArtista
            // 
            lblArtista.AutoSize = true;
            lblArtista.Location = new Point(297, 40);
            lblArtista.Name = "lblArtista";
            lblArtista.Size = new Size(47, 20);
            lblArtista.TabIndex = 1;
            lblArtista.Text = "Artist:";
            // 
            // txtArtista
            // 
            txtArtista.Location = new Point(360, 36);
            txtArtista.Margin = new Padding(3, 4, 3, 4);
            txtArtista.Name = "txtArtista";
            txtArtista.Size = new Size(205, 27);
            txtArtista.TabIndex = 1;
            // 
            // lblBpm
            // 
            lblBpm.AutoSize = true;
            lblBpm.Location = new Point(583, 40);
            lblBpm.Name = "lblBpm";
            lblBpm.Size = new Size(42, 20);
            lblBpm.TabIndex = 2;
            lblBpm.Text = "BPM:";
            // 
            // numBpm
            // 
            numBpm.Location = new Point(634, 36);
            numBpm.Margin = new Padding(3, 4, 3, 4);
            numBpm.Maximum = new decimal(new int[] { 220, 0, 0, 0 });
            numBpm.Minimum = new decimal(new int[] { 60, 0, 0, 0 });
            numBpm.Name = "numBpm";
            numBpm.Size = new Size(80, 27);
            numBpm.TabIndex = 2;
            numBpm.Value = new decimal(new int[] { 124, 0, 0, 0 });
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.Location = new Point(737, 40);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(72, 20);
            lblDuracion.TabIndex = 3;
            lblDuracion.Text = "Duración:";
            // 
            // numDuracion
            // 
            numDuracion.Location = new Point(834, 36);
            numDuracion.Margin = new Padding(3, 4, 3, 4);
            numDuracion.Maximum = new decimal(new int[] { 3600, 0, 0, 0 });
            numDuracion.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDuracion.Name = "numDuracion";
            numDuracion.Size = new Size(91, 27);
            numDuracion.TabIndex = 3;
            numDuracion.Value = new decimal(new int[] { 210, 0, 0, 0 });
            // 
            // OwnRB
            // 
            OwnRB.AutoSize = true;
            OwnRB.Checked = true;
            OwnRB.Location = new Point(17, 87);
            OwnRB.Margin = new Padding(3, 4, 3, 4);
            OwnRB.Name = "OwnRB";
            OwnRB.Size = new Size(215, 24);
            OwnRB.TabIndex = 4;
            OwnRB.TabStop = true;
            OwnRB.Text = "Lista Simple Propia (Nodos)";
            OwnRB.CheckedChanged += SelectedStructure_CheckedChanged;
            // 
            // rbLinkedList
            // 
            rbLinkedList.AutoSize = true;
            rbLinkedList.Location = new Point(263, 87);
            rbLinkedList.Margin = new Padding(3, 4, 3, 4);
            rbLinkedList.Name = "rbLinkedList";
            rbLinkedList.Size = new Size(157, 24);
            rbLinkedList.TabIndex = 5;
            rbLinkedList.Text = ".NET LinkedList<T>";
            rbLinkedList.CheckedChanged += SelectedStructure_CheckedChanged;
            // 
            // rbList
            // 
            rbList.AutoSize = true;
            rbList.Location = new Point(457, 87);
            rbList.Margin = new Padding(3, 4, 3, 4);
            rbList.Name = "rbList";
            rbList.Size = new Size(114, 24);
            rbList.TabIndex = 6;
            rbList.Text = ".NET List<T>";
            rbList.CheckedChanged += SelectedStructure_CheckedChanged;
            // 
            // grpAcciones
            // 
            grpAcciones.Controls.Add(btnEncolarFinal);
            grpAcciones.Controls.Add(btnReproducirSiguiente);
            grpAcciones.Controls.Add(btnAvanzar);
            grpAcciones.Controls.Add(btnInvertir);
            grpAcciones.Controls.Add(btnOrdenarBpm);
            grpAcciones.Controls.Add(btnPurgar);
            grpAcciones.Location = new Point(14, 160);
            grpAcciones.Margin = new Padding(3, 4, 3, 4);
            grpAcciones.Name = "grpAcciones";
            grpAcciones.Padding = new Padding(3, 4, 3, 4);
            grpAcciones.Size = new Size(297, 400);
            grpAcciones.TabIndex = 1;
            grpAcciones.TabStop = false;
            grpAcciones.Text = "ACCIONES DE COLA";
            // 
            // btnEncolarFinal
            // 
            btnEncolarFinal.Location = new Point(17, 40);
            btnEncolarFinal.Margin = new Padding(3, 4, 3, 4);
            btnEncolarFinal.Name = "btnEncolarFinal";
            btnEncolarFinal.Size = new Size(263, 43);
            btnEncolarFinal.TabIndex = 0;
            btnEncolarFinal.Text = "Listar al Final";
            btnEncolarFinal.Click += btnEncolarFinal_Click;
            // 
            // btnReproducirSiguiente
            // 
            btnReproducirSiguiente.Location = new Point(17, 93);
            btnReproducirSiguiente.Margin = new Padding(3, 4, 3, 4);
            btnReproducirSiguiente.Name = "btnReproducirSiguiente";
            btnReproducirSiguiente.Size = new Size(263, 43);
            btnReproducirSiguiente.TabIndex = 1;
            btnReproducirSiguiente.Text = "Reproducir Siguiente";
            btnReproducirSiguiente.Click += btnPlayNext_Click;
            // 
            // btnAvanzar
            // 
            btnAvanzar.Location = new Point(17, 147);
            btnAvanzar.Margin = new Padding(3, 4, 3, 4);
            btnAvanzar.Name = "btnAvanzar";
            btnAvanzar.Size = new Size(263, 43);
            btnAvanzar.TabIndex = 2;
            btnAvanzar.Text = "Avanzar Track";
            btnAvanzar.Click += btnNext_Click;
            // 
            // btnInvertir
            // 
            btnInvertir.Location = new Point(17, 200);
            btnInvertir.Margin = new Padding(3, 4, 3, 4);
            btnInvertir.Name = "btnInvertir";
            btnInvertir.Size = new Size(263, 43);
            btnInvertir.TabIndex = 3;
            btnInvertir.Text = "Invertir Lista";
            btnInvertir.Click += btnInvert_Click;
            // 
            // btnOrdenarBpm
            // 
            btnOrdenarBpm.Location = new Point(17, 253);
            btnOrdenarBpm.Margin = new Padding(3, 4, 3, 4);
            btnOrdenarBpm.Name = "btnOrdenarBpm";
            btnOrdenarBpm.Size = new Size(263, 43);
            btnOrdenarBpm.TabIndex = 4;
            btnOrdenarBpm.Text = "Ordenar por BPM";
            btnOrdenarBpm.Click += btnSortBpm_Click;
            // 
            // btnPurgar
            // 
            btnPurgar.Location = new Point(17, 307);
            btnPurgar.Margin = new Padding(3, 4, 3, 4);
            btnPurgar.Name = "btnPurgar";
            btnPurgar.Size = new Size(263, 43);
            btnPurgar.TabIndex = 5;
            btnPurgar.Text = "Eliminar Duplicados";
            btnPurgar.Click += btnDelete_Click;
            // 
            // grpPlaylist
            // 
            grpPlaylist.Controls.Add(lblNowPlaying);
            grpPlaylist.Controls.Add(dgvQueue);
            grpPlaylist.Controls.Add(lblEstadisticas);
            grpPlaylist.Location = new Point(325, 160);
            grpPlaylist.Margin = new Padding(3, 4, 3, 4);
            grpPlaylist.Name = "grpPlaylist";
            grpPlaylist.Padding = new Padding(3, 4, 3, 4);
            grpPlaylist.Size = new Size(832, 400);
            grpPlaylist.TabIndex = 2;
            grpPlaylist.TabStop = false;
            grpPlaylist.Text = "PLAYLIST VISUAL / COLA EN VIVO";
            // 
            // lblNowPlaying
            // 
            lblNowPlaying.AutoSize = true;
            lblNowPlaying.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNowPlaying.Location = new Point(17, 33);
            lblNowPlaying.Name = "lblNowPlaying";
            lblNowPlaying.Size = new Size(189, 20);
            lblNowPlaying.TabIndex = 0;
            lblNowPlaying.Text = "▶ Sin reproducción activa";
            // 
            // dgvQueue
            // 
            dgvQueue.AllowUserToAddRows = false;
            dgvQueue.AllowUserToDeleteRows = false;
            dgvQueue.ColumnHeadersHeight = 29;
            dgvQueue.Location = new Point(17, 77);
            dgvQueue.Margin = new Padding(3, 4, 3, 4);
            dgvQueue.Name = "dgvQueue";
            dgvQueue.ReadOnly = true;
            dgvQueue.RowHeadersWidth = 51;
            dgvQueue.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQueue.Size = new Size(798, 273);
            dgvQueue.TabIndex = 0;
            // 
            // lblEstadisticas
            // 
            lblEstadisticas.AutoSize = true;
            lblEstadisticas.Location = new Point(17, 357);
            lblEstadisticas.Name = "lblEstadisticas";
            lblEstadisticas.Size = new Size(249, 20);
            lblEstadisticas.TabIndex = 1;
            lblEstadisticas.Text = "Total en cola: 0 | Tiempo total: 00:00";
            // 
            // grpBenchmark
            // 
            grpBenchmark.Controls.Add(lblCantidadStress);
            grpBenchmark.Controls.Add(numStress);
            grpBenchmark.Controls.Add(btnBenchmark);
            grpBenchmark.Controls.Add(txtResultadosBenchmark);
            grpBenchmark.Location = new Point(14, 571);
            grpBenchmark.Margin = new Padding(3, 4, 3, 4);
            grpBenchmark.Name = "grpBenchmark";
            grpBenchmark.Padding = new Padding(3, 4, 3, 4);
            grpBenchmark.Size = new Size(1143, 253);
            grpBenchmark.TabIndex = 3;
            grpBenchmark.TabStop = false;
            grpBenchmark.Text = "PANEL DE BENCHMARK Y TELEMETRÍA";
            // 
            // lblCantidadStress
            // 
            lblCantidadStress.AutoSize = true;
            lblCantidadStress.Location = new Point(17, 40);
            lblCantidadStress.Name = "lblCantidadStress";
            lblCantidadStress.Size = new Size(260, 20);
            lblCantidadStress.TabIndex = 0;
            lblCantidadStress.Text = "Cantidad de pistas para test de estrés:";
            // 
            // numStress
            // 
            numStress.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            numStress.Location = new Point(297, 36);
            numStress.Margin = new Padding(3, 4, 3, 4);
            numStress.Maximum = new decimal(new int[] { 200000, 0, 0, 0 });
            numStress.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numStress.Name = "numStress";
            numStress.Size = new Size(114, 27);
            numStress.TabIndex = 0;
            numStress.ThousandsSeparator = true;
            numStress.Value = new decimal(new int[] { 25000, 0, 0, 0 });
            // 
            // btnBenchmark
            // 
            btnBenchmark.Location = new Point(434, 33);
            btnBenchmark.Margin = new Padding(3, 4, 3, 4);
            btnBenchmark.Name = "btnBenchmark";
            btnBenchmark.Size = new Size(297, 40);
            btnBenchmark.TabIndex = 1;
            btnBenchmark.Text = "Iniciar Prueba de Rendimiento";
            btnBenchmark.Click += btnBenchmark_Click;
            // 
            // txtResultadosBenchmark
            // 
            txtResultadosBenchmark.Font = new Font("Consolas", 9F);
            txtResultadosBenchmark.Location = new Point(17, 87);
            txtResultadosBenchmark.Margin = new Padding(3, 4, 3, 4);
            txtResultadosBenchmark.Multiline = true;
            txtResultadosBenchmark.Name = "txtResultadosBenchmark";
            txtResultadosBenchmark.ReadOnly = true;
            txtResultadosBenchmark.ScrollBars = ScrollBars.Vertical;
            txtResultadosBenchmark.Size = new Size(1102, 145);
            txtResultadosBenchmark.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 840);
            Controls.Add(grpRegistro);
            Controls.Add(grpAcciones);
            Controls.Add(grpPlaylist);
            Controls.Add(grpBenchmark);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1186, 876);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SoundCore Engine v2.0";
            grpRegistro.ResumeLayout(false);
            grpRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numBpm).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDuracion).EndInit();
            grpAcciones.ResumeLayout(false);
            grpPlaylist.ResumeLayout(false);
            grpPlaylist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQueue).EndInit();
            grpBenchmark.ResumeLayout(false);
            grpBenchmark.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numStress).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}
