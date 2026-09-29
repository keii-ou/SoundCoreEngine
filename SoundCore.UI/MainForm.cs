using System.Diagnostics;
using System.Runtime.CompilerServices;
using SoundCore.EstructurasPropias;
using SoundCore.Modelos;

namespace SoundCore.UI
{
    public partial class MainForm : Form
    {
     
        private readonly SimpleLinkedList<Track> _ownQueue = new();
        private readonly LinkedList<Track> _LinkedListQueue = new();
        private readonly List<Track> _QueueList = new();

        private int _counterId = 1;
        private Track? _trackPlaying = null;

        public MainForm()
        {
            InitializeComponent();
            ConfigurateGridColums();
            LoadSeedData();
            RefreshView();
        }

        private void ConfigurateGridColums()
        {
            dgvQueue.Columns.Clear();
            dgvQueue.ColumnCount = 6;
            dgvQueue.Columns[0].Name = "Pos";
            dgvQueue.Columns[1].Name = "ID";
            dgvQueue.Columns[2].Name = "Título / Artist";
            dgvQueue.Columns[3].Name = "BPM";
            dgvQueue.Columns[4].Name = "Duración";
            dgvQueue.Columns[5].Name = "Referencia Nodo";
            dgvQueue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadSeedData()
        {
            var demo = new[]
            {
                new Track(_counterId++, "Strobe", "deadmau5", 128, 634),
                new Track(_counterId++, "Midnight City", "M83", 105, 243),
                new Track(_counterId++, "Animals", "Martin Garrix", 130, 304)
            };

            foreach (var p in demo)
            {
                _ownQueue.AddAtTheEnd(p);
                _LinkedListQueue.AddLast(p);
                _QueueList.Add(p);
            }
        }

      
        private Track? CreateTrackfromForm()
        {
            string title = txtTitle.Text.Trim();
            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("El título de la track no puede estar vacío.", "Datos incompletos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return null;
            }

            string artist = string.IsNullOrWhiteSpace(txtArtista.Text) ? "DJ Desconocido" : txtArtista.Text.Trim();
            int bpm = (int)numBpm.Value;
            int duration = (int)numDuracion.Value;

            var pista = new Track(_counterId++, title, artist, bpm, duration);
            txtTitle.Clear();
            txtArtista.Clear();
            txtTitle.Focus();
            return pista;
        }

        private void btnEncolarFinal_Click(object? sender, EventArgs e)
        {
            var track = CreateTrackfromForm();
            if (track is null) return;

            if (OwnRB.Checked) _ownQueue.AddAtTheEnd(track);
            else if (rbLinkedList.Checked) _LinkedListQueue.AddLast(track);
            else _QueueList.Add(track);

            RefreshView();
        }

        private void btnPlayNext_Click(object? sender, EventArgs e)
        {
            var track = CreateTrackfromForm();
            if (track is null) return;

            if (OwnRB.Checked)
            {
                _ownQueue.PlayNext(track);
            }
            else if (rbLinkedList.Checked)
            {
                if (_LinkedListQueue.First == null)
                    _LinkedListQueue.AddFirst(track);
                else
                    _LinkedListQueue.AddAfter(_LinkedListQueue.First, track);
            }
            else
            {
                if (_QueueList.Count == 0) _QueueList.Add(track);
                else _QueueList.Insert(1, track);
            }

            RefreshView();
        }

        private void btnNext_Click(object? sender, EventArgs e)
        {
            try
            {
                if (OwnRB.Checked)
                {
                    _trackPlaying = _ownQueue.SkipTrack();
                }
                else if (rbLinkedList.Checked)
                {
                    if (_LinkedListQueue.First == null) throw new InvalidOperationException();
                    _trackPlaying = _LinkedListQueue.First.Value;
                    _LinkedListQueue.RemoveFirst();
                }
                else
                {
                    if (_QueueList.Count == 0) throw new InvalidOperationException();
                    _trackPlaying = _QueueList[0];
                    _QueueList.RemoveAt(0);
                }

                lblNowPlaying.Text = $"▶ Reproduciendo: \"{_trackPlaying.Title}\" - {_trackPlaying.Artist} ({_trackPlaying.Bpm} BPM)";
                lblNowPlaying.ForeColor = Color.DarkGreen;
                RefreshView();
            }
            catch (InvalidOperationException)
            {
               
                MessageBox.Show("No hay pistas pendientes en la cola.", "Fin del Setlist",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnInvert_Click(object? sender, EventArgs e)
        {
            if (OwnRB.Checked)
            {
                _ownQueue.Invertir();
            }
            else if (rbLinkedList.Checked)
            {
                var TemporalList = new List<Track>(_LinkedListQueue);
                TemporalList.Reverse();
                _LinkedListQueue.Clear();
                foreach (var item in TemporalList) _LinkedListQueue.AddLast(item);
            }
            else
            {
                _QueueList.Reverse();
            }

            RefreshView();
        }

        private void btnSortBpm_Click(object? sender, EventArgs e)
        {
            if (OwnRB.Checked)
            {
                var temporal = new SimpleLinkedList<Track>();
                foreach (var track in _ownQueue)
                {
                    temporal.InsertSorted(track, (a, b) => a.Bpm.CompareTo(b.Bpm));
                }
                _ownQueue.Clear();
                foreach (var p in temporal) _ownQueue.AddAtTheEnd(p);
            }
            else if (rbLinkedList.Checked)
            {
                var sorted = _LinkedListQueue.OrderBy(p => p.Bpm).ToList();
                _LinkedListQueue.Clear();
                foreach (var p in sorted) _LinkedListQueue.AddLast(p);
            }
            else
            {
                _QueueList.Sort((a, b) => a.Bpm.CompareTo(b.Bpm));
            }

            RefreshView();
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (OwnRB.Checked)
            {
                _ownQueue.DeleteDupes((a, b) => a.Title.Equals(b.Title, StringComparison.OrdinalIgnoreCase));
            }
            else if (rbLinkedList.Checked)
            {
                var uniques = _LinkedListQueue.DistinctBy(p => p.Title).ToList();
                _LinkedListQueue.Clear();
                foreach (var p in uniques) _LinkedListQueue.AddLast(p);
            }
            else
            {
                var uniques = _QueueList.DistinctBy(p => p.Title).ToList();
                _QueueList.Clear();
                _QueueList.AddRange(uniques);
            }

            RefreshView();
        }

      
        private void SelectedStructure_CheckedChanged(object? sender, EventArgs e)
        {
            RefreshView();
        }

        private void RefreshView()
        {
            dgvQueue.Rows.Clear();

            int index = 1;
            int TotalDuration = 0;

            if (OwnRB.Checked)
            {
                var node = _ownQueue.Head;
                while (node != null)
                {
                    string refNodo = ReformNodereference(node, node.Next == null);
                    dgvQueue.Rows.Add(index++, node.Value.Id, $"{node.Value.Title} — {node.Value.Artist}",
                        $"{node.Value.Bpm} BPM", $"{node.Value.SecondsDuration}s", refNodo);
                    TotalDuration += node.Value.SecondsDuration;
                    node = node.Next;
                }
            }
            else
            {
                IEnumerable<Track> colection = rbLinkedList.Checked
                    ? _LinkedListQueue
                    : _QueueList;

                foreach (var p in colection)
                {
                    dgvQueue.Rows.Add(index++, p.Id, $"{p.Title} — {p.Artist}", $"{p.Bpm} BPM", $"{p.SecondsDuration}s", "—");
                    TotalDuration += p.SecondsDuration;
                }
            }

            lblEstadisticas.Text = $"Total en cola: {index - 1} pistas | Duración acumulada: {TimeSpan.FromSeconds(TotalDuration):mm\\:ss}";
        }

       
        private static string ReformNodereference(Node<Track> nodo, bool isLast)
        {
            int hash = RuntimeHelpers.GetHashCode(nodo);
            string destination = isLast ? "Null" : "Next";
            return $"Node 0x{hash:X4} -> {destination}";
        }

        private void btnBenchmark_Click(object? sender, EventArgs e)
        {
            int n = (int)numStress.Value;
            var sw = new Stopwatch();

         
            var testOwn = new SimpleLinkedList<Track>();
            testOwn.AddAtTheEnd(new Track(0, "Head", "DJ", 120, 200));
            sw.Restart();
            for (int i = 0; i < n; i++)
            {
                testOwn.PlayNext(new Track(i, $"Track {i}", "DJ", 120, 180));
            }
            sw.Stop();
            long OwnTime = sw.ElapsedMilliseconds;

            
            var testLinkedList = new LinkedList<Track>();
            testLinkedList.AddLast(new Track(0, "Head", "DJ", 120, 200));
            sw.Restart();
            for (int i = 0; i < n; i++)
            {
                testLinkedList.AddAfter(testLinkedList.First!, new Track(i, $"Track {i}", "DJ", 120, 180));
            }
            sw.Stop();
            long LinkedListTime = sw.ElapsedMilliseconds;

            
            var testList = new List<Track> { new Track(0, "Head", "DJ", 120, 200) };
            sw.Restart();
            for (int i = 0; i < n; i++)
            {
                testList.Insert(1, new Track(i, $"Track {i}", "DJ", 120, 180));
            }
            sw.Stop();
            long tiempoList = sw.ElapsedMilliseconds;

            txtResultadosBenchmark.Text =
                $"=== RESULTADOS DE ESTRÉS ({n:N0} INSERCIONES INTERMEDIAS) ===\r\n" +
                $"- Lista Propia (Nodos):       {OwnTime,6} ms | Inserción intermedia O(1) por reconexión de puntero\r\n" +
                $"- .NET LinkedList<T>:         {LinkedListTime,6} ms | Inserción con LinkedListNode O(1)\r\n" +
                $"- .NET List<T> (Array Din.):  {tiempoList,6} ms | Insert(idx) sufre degradación por Array.Copy O(n)\r\n\r\n" +
                "Conclusión técnica: en inserciones intermedias frecuentes, las listas enlazadas " +
                "(propia y LinkedList<T>) superan a List<T> porque reconectan punteros en tiempo " +
                "constante, mientras que List<T> debe desplazar en memoria todos los elementos " +
                "posteriores al índice de inserción.";
        }
    }
}
