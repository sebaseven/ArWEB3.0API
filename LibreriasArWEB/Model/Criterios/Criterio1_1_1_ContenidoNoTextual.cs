using LibreriasArWEB.Model.Tecnicas;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasArWEB.Model.Criterios
{
    public class Criterio1_1_1_ContenidoNoTextual : Criterio
    {
  

        public override List<Tecnica> getTecnicasAAgregar()
		{
			List<Tecnica> listaTecnicas = new List<Tecnica>();
			listaTecnicas.Add(new TecnicaG94(CategoriaTecnicaEnum.SUFICIENTE));
			listaTecnicas.Add(new TecnicaG196(CategoriaTecnicaEnum.SUFICIENTE));
			listaTecnicas.Add(new TecnicaG95(CategoriaTecnicaEnum.SUFICIENTE));
			listaTecnicas.Add(new TecnicaG73(CategoriaTecnicaEnum.SUFICIENTE));
			listaTecnicas.Add(new TecnicaG74(CategoriaTecnicaEnum.SUFICIENTE));
			listaTecnicas.Add(new TecnicaG92(CategoriaTecnicaEnum.SUFICIENTE));
			listaTecnicas.Add(new TecnicaG82(CategoriaTecnicaEnum.SUFICIENTE));
			listaTecnicas.Add(new TecnicaG68(CategoriaTecnicaEnum.SUFICIENTE));
			listaTecnicas.Add(new TecnicaG100(CategoriaTecnicaEnum.SUFICIENTE));
			listaTecnicas.Add(new TecnicaG143(CategoriaTecnicaEnum.SUFICIENTE));
			listaTecnicas.Add(new TecnicaG144(CategoriaTecnicaEnum.SUFICIENTE));
			listaTecnicas.Add(new TecnicaH2(CategoriaTecnicaEnum.SUFICIENTE));
			listaTecnicas.Add(new TecnicaH24(CategoriaTecnicaEnum.SUFICIENTE));
			listaTecnicas.Add(new TecnicaH35(CategoriaTecnicaEnum.SUFICIENTE));
			listaTecnicas.Add(new TecnicaH37(CategoriaTecnicaEnum.SUFICIENTE));
			listaTecnicas.Add(new TecnicaH53(CategoriaTecnicaEnum.SUFICIENTE));
			listaTecnicas.Add(new TecnicaH86(CategoriaTecnicaEnum.SUFICIENTE));
			listaTecnicas.Add(new TecnicaH45(CategoriaTecnicaEnum.SUFICIENTE));
			listaTecnicas.Add(new TecnicaH30(CategoriaTecnicaEnum.SUFICIENTE));
			listaTecnicas.Add(new TecnicaH36(CategoriaTecnicaEnum.SUFICIENTE));
			listaTecnicas.Add(new TecnicaH44(CategoriaTecnicaEnum.SUFICIENTE));
			listaTecnicas.Add(new TecnicaH65(CategoriaTecnicaEnum.SUFICIENTE));
			listaTecnicas.Add(new TecnicaH67(CategoriaTecnicaEnum.SUFICIENTE));
			listaTecnicas.Add(new TecnicaH46(CategoriaTecnicaEnum.RECOMENDABLE));
			listaTecnicas.Add(new TecnicaC9(CategoriaTecnicaEnum.SUFICIENTE));
			listaTecnicas.Add(new TecnicaC18(CategoriaTecnicaEnum.RECOMENDABLE));
			return listaTecnicas;
		}

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
