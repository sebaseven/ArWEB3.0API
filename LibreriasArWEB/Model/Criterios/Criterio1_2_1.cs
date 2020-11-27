using LibreriasArWEB.Model.Tecnicas;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasArWEB.Model.Criterios
{
    public class Criterio1_2_1 : Criterio
    {
        public override List<Tecnica> getTecnicasAAgregar()
        {
            List<Tecnica> listaTecnicas = new LinkedList<Tecnica>();
            listaTecnicas.Add(new TecnicaG158(CategoriaTecnica.SUFICIENTE));
            listaTecnicas.Add(new TecnicaG159(CategoriaTecnica.SUFICIENTE));
            listaTecnicas.Add(new TecnicaG166(CategoriaTecnica.SUFICIENTE));
            listaTecnicas.Add(new TecnicaH96(CategoriaTecnica.RECOMENDABLE));
            return listaTecnicas;
        }
    }
}
