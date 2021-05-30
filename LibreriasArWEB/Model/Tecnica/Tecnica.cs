using LibreriasArWEB.Model.Evaluacion;
using LibreriasArWEB.Parser;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasArWEB.Model.Tecnicas
{
    public abstract class Tecnica : Estructura
    {

        private CategoriaTecnica _categoriaTecnica;
        private Parseador _parseador;
        private string _url;
        private static string _URL_TECNICA = "https://www.w3.org/WAI/WCAG21/Techniques/";//Constantes.URL_TECNICAS_WCAG21;



        public Tecnica(string numero, string nombre, string descripcion, CategoriaTecnica categoriaTecnica) : base(numero,nombre,descripcion)
        {

            this.setCategoriaTecnica(categoriaTecnica);
            this.setUrl(_URL_TECNICA + this.getNumero());
        }

        public void setCategoriaTecnica(CategoriaTecnica categoriaTecnica)
        {
            this._categoriaTecnica = categoriaTecnica;
        }
        private void setUrl(string url)
        {
            this._url = url;
        }
        public abstract ResultadoEvaluacionTecnica validarAccesibilidadPorTecnica(Parseador parseador);
        public Boolean isCategoriaTecnicaSuficiente()
        {
            return this.getCategoriaTecnica().getRepresentacionNumerica() == CategoriaTecnica.categ(CategoriaTecnicaEnum.SUFICIENTE)._representacionNumerica;
        }

        public Boolean isCategoriaTecnicaRecomendable()
        {
            return this.getCategoriaTecnica().getRepresentacionNumerica() == CategoriaTecnica.categ(CategoriaTecnicaEnum.RECOMENDABLE)._representacionNumerica;
        }

        public CategoriaTecnica getCategoriaTecnica()
        {
            return this._categoriaTecnica;
        }
        public string getUrl()
        {
            return this._url;
        }
        public override string toString()
        {
            return this.getCategoriaTecnica().getRepresentacionSimbolica() + ": " + this.getNumero();
        }
    }
}
