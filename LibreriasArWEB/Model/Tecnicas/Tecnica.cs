using LibreriasArWEB.Parser;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasArWEB.Model.Tecnicas
{
	public abstract class Tecnica : Estructura
	{

	private CategoriaTecnica categoriaTecnica;
	private Parseador parseador;
	private String url;
	private static String URL_TECNICA = "https://www.w3.org/TR/WCAG20-TECHS/";//Constantes.URL_TECNICAS_WCAG20;


	public Tecnica(String numero, String nombre, String descripcion, CategoriaTecnica categoriaTecnica)
	{
		
		this.setCategoriaTecnica(categoriaTecnica);
		this.setUrl(URL_TECNICA + this.getNumero());
	}

	public abstract ResultadoEvaluacionTecnica validarAccesibilidadPorTecnica(Parseador parseador);

	public Boolean isCategoriaTecnicaSuficiente()
	{
		return this.getCategoriaTecnica().getRepresentacionNumerica() == CategoriaTecnica.SUFICIENTE.getRepresentacionNumerica();
	}

	public Boolean isCategoriaTecnicaRecomendable()
	{
		return this.getCategoriaTecnica().getRepresentacionNumerica() == CategoriaTecnica.RECOMENDABLE.getRepresentacionNumerica();
	}

	public CategoriaTecnica getCategoriaTecnica()
	{
		return this.categoriaTecnica;
	}

	public void setCategoriaTecnica(CategoriaTecnica categoriaTecnica)
	{
		this.categoriaTecnica = categoriaTecnica;
	}

	public String getUrl()
	{
		return this.url;
	}

	private void setUrl(String url)
	{
		this.url = url;
	}

	//public String getPackageClassName()
	//{
	//	return this.getClass().getCanonicalName();
	//}

	public String toString()
	{
		return this.getCategoriaTecnica().getRepresentacionSimbolica() + ": " + this.getNumero();
	}

}
}
