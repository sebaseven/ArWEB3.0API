using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasArWEB.Model.Tecnicas
{
    public enum CategoriaTecnicaEnum
    {
        SUFICIENTE=0,
        RECOMENDABLE=1,
        FALLO_COMUN=2
    }
    public class CategoriaTecnica
    {

        public static int representacionNumerica { get; set; }
        public static String representacionSimbolica { get; set; }
        public static String representacionString { get; set; }



        public CategoriaTecnica(CategoriaTecnicaEnum en)
        {
            switch (en)
            {
                case CategoriaTecnicaEnum.SUFICIENTE:
                    representacionNumerica = 0;
                    representacionSimbolica = "S";
                    representacionString = "Suficiente";
                    break;
                case CategoriaTecnicaEnum.RECOMENDABLE:
                    representacionNumerica = 1;
                    representacionSimbolica = "R";
                    representacionString = "Recomendable";
                    break;
                case CategoriaTecnicaEnum.FALLO_COMUN:
                    representacionNumerica = 2;
                    representacionSimbolica = "F";
                    representacionString = "Fallo Comun";
                    break;
                default:
                  
                    break;
            }

        }

    }
}

