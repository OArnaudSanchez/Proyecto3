using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLogica;
namespace CPresentacion
{
	public partial class Presentacion : Form
	{
		Producto p = new Producto();
		
		public Presentacion()
		{
			InitializeComponent();
		}

		private void bSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void bAgregarProductos_Click(object sender, EventArgs e)
		{

			try {

					p.Codigo = int.Parse(tCodigo.Text);
					p.Nombre = tNombre.Text;
					p.Detalle = tDetalle.Text;
					p.Costo = double.Parse(tCosto.Text);
					p.Precio = double.Parse(tPrecio.Text);
					p._FechaCreacion = DateTime.Parse(tFCreacion.Text);
					p._FechaVencimiento = DateTime.Parse(tFVencimiento.Text);
					p.Categoria = tCategoria.Text;
					p.Estado = tEstado.Text;
				MessageBox.Show("El producto se ingreso correctamente");	
				
			} catch (Exception error) {
				MessageBox.Show("Ingrese los datos correctamente");
				}

			verDatos();
			Limpiar();
		}

	

		public void verDatos() {
			try {
				DataGridViewRow fila = new DataGridViewRow();
				fila.CreateCells(dataGridView1);
				fila.Cells[0].Value = p.Codigo;
				fila.Cells[1].Value = p.Nombre;
				fila.Cells[2].Value = p.Detalle;
				fila.Cells[3].Value = p.Costo;
				fila.Cells[4].Value = p.Precio;
				fila.Cells[5].Value = p._FechaCreacion;
				fila.Cells[6].Value = p._FechaVencimiento;
				fila.Cells[7].Value = p.Categoria;
				fila.Cells[8].Value = p.Estado;

				dataGridView1.Rows.Add(fila);
			} catch (Exception error) {
				MessageBox.Show(error.Message);
			}
			
		}
		public void Limpiar() {
			tCodigo.Clear();
			tNombre.Clear();
			tDetalle.Clear();
			tCosto.Clear();
			tPrecio.Clear();
			tFCreacion.Clear();
			tFVencimiento.Clear();
			tCategoria.Clear();
			tEstado.Clear();
		}

		private void bQuitarProductos_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
		}

		private void Presentacion_Load(object sender, EventArgs e)
		{
			verDatos();
		}
	}
}
