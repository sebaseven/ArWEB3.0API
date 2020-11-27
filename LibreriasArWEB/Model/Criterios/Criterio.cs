using LibreriasArWEB.Model.Tecnicas;
using LibreriasArWEB.Parser;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasArWEB.Model.Criterios
{
    public abstract class Criterio : Estructura
    {

        private List<Tecnica> tecnicas;
        private NivelAccesibilidad nivelAccesibilidad;
        private List<string> versionesWCAG;

        public Criterio(string numero,string nombre,string descripcion, NivelAccesibilidad nivelAccesibilidad, List<String> versionesWCAG)
            :base(numero,nombre,descripcion)
        {
            this.setTecnicas(new List<Tecnica>());
            this.setNivelAccesibilidad(nivelAccesibilidad);
            foreach (Tecnica tecnica in getTecnicasAAgregar())
            {

            }

        }
        //public Criterio(String numero, String nombre, String descripcion, NivelAccesibilidad nivelAccesibilidad, List<String> versionesWCAG)
        //{
        //    this.setTecnicas(new List<Tecnica>());
        //    this.setNivelAccesibilidad(nivelAccesibilidad);
        //    for (Tecnica tecnica : this.getTecnicasAAgregar())
        //        this.agregarTecnica(tecnica);
        //    this.setVersionesWCAG(versionesWCAG);
        //}

        public abstract List<Tecnica> getTecnicasAAgregar();

        private void agregarTecnica(Tecnica tecnica)
        {
            this.getTecnicas().Add(tecnica);
        }

        public ResultadoEvaluacionCriterio validarAccesibilidadPorCriterio(Parseador parseador)
        {
            ResultadoEvaluacionCriterio resultadoEvaluacionCriterio = new ResultadoEvaluacionCriterio(this);
            for (Tecnica tecnica : this.getTecnicas())
                resultadoEvaluacionCriterio.agregarResultadoEvaluacionTecnica(tecnica.validarAccesibilidadPorTecnica(parseador));
            return resultadoEvaluacionCriterio;
        }

        public List<Tecnica> getTecnicas()
        {
            return this.tecnicas;
        }

        public void setTecnicas(List<Tecnica> tecnicas)
        {
            this.tecnicas = tecnicas;
        }

        public NivelAccesibilidad getNivelAccesibilidad()
        {
            return this.nivelAccesibilidad;
        }

        public void setNivelAccesibilidad(NivelAccesibilidad nivelAccesibilidad)
        {
            this.nivelAccesibilidad = nivelAccesibilidad;
        }

        public List<String> getVersionesWCAG()
        {
            return this.versionesWCAG;
        }

        public void setVersionesWCAG(List<String> versionesWCAG)
        {
            this.versionesWCAG = versionesWCAG;
        }


        //public String getPackageClassName()
        //{
        //	return this.getClass().getCanonicalName();
        //}

        public String toString()
        {
            return this.getNumero();
        }

    }
}
