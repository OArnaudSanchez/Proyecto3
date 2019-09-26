using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica
{
	public class Producto
	{
		private int codigo;
		private string nombre;
		private string detalle;
		private double costo;
		private double precio;
		private DateTime fechaCreacion;
		private DateTime fechaVencimiento;
		private string categoria;
		private string estado;

		public int Codigo {
			get {
				return codigo;
			}
			set {
				codigo = value;
			}
		}

		public string Nombre {
			get {
				return nombre;
			}
			set {
				nombre = value;
			}
		}

		public string Detalle {
			get {
				return detalle;
			}
			set {
				detalle = value;
			}
		}

		public double Costo {
			get {
				return costo;
			}
			set {
				if (value>0.0) {
					costo = value;
				}
			}
		}

		public double Precio {
			get {
				return precio;
			}
			set {
				if (value>0.0) {
					precio = value;
				}
			}
		}

		public DateTime _FechaCreacion {
			get {
				return fechaCreacion;
			}
			set {
				fechaCreacion = value;
			}
		}

		public DateTime _FechaVencimiento {
			get {
				return fechaVencimiento;
			}
			set {
				fechaVencimiento = value;
			}
		}

		public string Categoria {
			get {
				return categoria;
			}

			set {
				categoria = value;
			}
		}

		public string Estado {
			get {
				return estado;
			}
			set {
				estado = value;
			}
		}

		public void agregar(int pCodigo,string pNombre,string pDetalle,double pCosto,double pPrecio,DateTime pFechaCreacion,
			DateTime pFechaVencimiento,string pCategoria, string pEstado) {

			Codigo = pCodigo;
			Nombre = pNombre;
			Detalle = pDetalle;
			Costo = pCosto;
			Precio = pPrecio;
			_FechaCreacion = pFechaCreacion;
			_FechaVencimiento = pFechaVencimiento;
			Categoria = pCategoria;
			Estado = pEstado;
		}
	}
}
