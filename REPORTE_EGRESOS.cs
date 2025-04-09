using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FERRETERIAPROYECTO
{
    public partial class REPORTE_EGRESOS: Form
    {
        public REPORTE_EGRESOS()
        {
            InitializeComponent();
        }
        public DateTime fecha1 { get; set; }
        public DateTime fecha2 { get; set; }
        private void REPORTE_EGRESOS_Load(object sender, EventArgs e)
        {
            this.rangofechaTableAdapter.Fill(this.dataSet2.rangofecha,fecha1,fecha2); 
            this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fecha1 = DTPINICIO.Value;
            DateTime fecha2 = DTPFINAL.Value;
            this.rangofechaTableAdapter.Fill(this.dataSet2.rangofecha, fecha1, fecha2);
            this.reportViewer1.RefreshReport();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataSet2BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
