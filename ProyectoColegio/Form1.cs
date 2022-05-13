using Microsoft.Office.Interop.Excel;

namespace ProyectoColegio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridViewPrestamos.Rows.Add(comboBoxCurso.Text, comboBoxOcupacion.Text, txtNombre.Text, txtEquipo.Text, txtNumero.Text, txtHoraEntrega.Text, "", txtObservacion.Text);

            comboBoxCurso.Text = "";
            comboBoxOcupacion.Text = "";
            txtNombre.Text = "";
            txtEquipo.Text = "";
            txtNumero.Text = "";
            txtHoraEntrega.Text = "";
            txtObservacion.Text = "";
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            exportaraexcel(dataGridViewPrestamos);
        }
        public void exportaraexcel(DataGridView dataGridViewPrestamos)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Application.Workbooks.Add(true);

            int IndiceColumna = 0;

            foreach (DataGridViewColumn col in dataGridViewPrestamos.Columns)
            {
                IndiceColumna++;

                excel.Cells[1, IndiceColumna] = col.Name;
            }

            int IndeceFila = 0;

            foreach (DataGridViewRow row in dataGridViewPrestamos.Rows)
            {
                IndeceFila++;

                IndiceColumna = 0;

                foreach (DataGridViewColumn col in dataGridViewPrestamos.Columns)
                {
                    IndiceColumna++;

                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;
                }
            }
            excel.Visible = true;
            excel.Cells[2].ColumnWidth = 20;
            excel.Cells[3].ColumnWidth = 35;
            excel.Cells[4].ColumnWidth = 40;
            excel.Cells[5].ColumnWidth = 7;
            excel.Cells[6].ColumnWidth = 10;
            excel.Cells[7].ColumnWidth = 10;
            excel.Cells[8].ColumnWidth = 30;
        }

        [Serializable]
        public class HoraDevolucionException : Exception 
        {
            public string HoraDeDevolucion { get; }
            public HoraDevolucionException() { }

            public HoraDevolucionException(string message)
                : base(message) { }

            public HoraDevolucionException(string message, Exception inner)
                : base(message, inner) { }
            public HoraDevolucionException(string message, string horaDevolución)
                : this(message)
            {
                HoraDeDevolucion = horaDevolución;
            }
        }

        private void dataGridViewPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Se eliminará la fila completa", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning );
 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se eliminará la fila completa", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
         
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            string message = "¿Seguro que quieres salir? Se abrirá un excel con los datos";
            string caption = "Atención";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(this, message, caption, buttons,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign);

            if (result == DialogResult.Yes)
            {
                exportaraexcel(dataGridViewPrestamos);
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void dataGridViewPrestamos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                throw new HoraDevolucionException("No se encuentra un horario de devolución", "");
                txtEquiposFaltantes.Text = dataGridViewPrestamos.CurrentRow.Cells[6].Value.ToString();
            }
            catch
            {
                MessageBox.Show("No hay horarios de devolución", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e) 
        {
            try
            {

                txtEquiposFaltantes.Text = "0";
                txtEquiposFaltantes.Text = dataGridViewPrestamos.Rows.Count.ToString();
            }
            catch
            {
                MessageBox.Show("No hay horarios de devolución", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}