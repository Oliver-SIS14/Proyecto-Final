﻿using ProyectoFinalFerreteria.BLL;
using ProyectoFinalFerreteria.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalFerreteria.UI.Reportes
{
    public partial class ReporteVentasDiarias : Form
    {
        public List<Facturas> ListaFacturas { get; set; }
        public ReporteVentasDiarias(List<Facturas> facturas)
        {
            this.ListaFacturas = facturas;
            InitializeComponent();
        }

        private void VentasReporteViewer_Load(object sender, EventArgs e)
        {

        }

        private void ReporteVentasDiarias_Load(object sender, EventArgs e)
        {
            RepositorioBase<Facturas> repo = new RepositorioBase<Facturas>();
            RVentasDiarias listaf = new RVentasDiarias();

            listaf.SetDataSource(ListaFacturas);

            VentasReporteViewer.ReportSource = listaf;
            VentasReporteViewer.Refresh();
        }
    }
}
