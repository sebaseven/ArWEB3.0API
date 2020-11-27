using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasArWEB.Model
{
	public abstract class Estructura
	{

		private string numero;
		private string nombre;
		private string descripcion;

		public Estructura(string numero, string nombre, string descripcion)
		{
			this.setNumero(numero);
			this.setNombre(nombre);
			this.setDescripcion(descripcion);
		}

		public string getNumero()
		{
			return this.numero;
		}

		public void setNumero(string numero)
		{
			this.numero = numero;
		}

		public string getNombre()
		{
			return this.nombre;
		}

		public void setNombre(string nombre)
		{
			this.nombre = nombre;
		}

		public string getDescripcion()
		{
			return this.descripcion;
		}

		public void setDescripcion(string descripcion)
		{
			this.descripcion = descripcion;
		}

		public string toString()
		{
			return this.getNumero() + ": " + this.getNombre() + " - " + this.getDescripcion();
		}

	}
}
