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

        public  int _representacionNumerica { get; set; }
        public  string _representacionSimbolica { get; set; }
        public  string _representacionString { get; set; }

        public CategoriaTecnica()
        {

        }
        public int getRepresentacionNumerica()
        {
            return this._representacionNumerica;
        }

        public void setRepresentacionNumerica(int representacionNumerica)
        {
            this._representacionNumerica = representacionNumerica;
        }

        public String getRepresentacionSimbolica()
        {
            return this._representacionSimbolica;
        }

        public void setRepresentacionSimbolica(String representacionSimbolica)
        {
            this._representacionSimbolica = representacionSimbolica;
        }

        public String getRepresentacionString()
        {
            return this._representacionString;
        }

        public void setRepresentacionString(String representacionString)
        {
            this._representacionString = representacionString;
        }
        public static CategoriaTecnica categ(CategoriaTecnicaEnum en)
        {
           var c = new CategoriaTecnica();

            switch (en)
            {
                case CategoriaTecnicaEnum.SUFICIENTE:
                    c._representacionNumerica = 0;
                    c._representacionSimbolica = "S";
                    c._representacionString = "Suficiente";
                    break;
                case CategoriaTecnicaEnum.RECOMENDABLE:
                    c._representacionNumerica = 1;
                    c._representacionSimbolica = "R";
                    c._representacionString = "Recomendable";
                    break;
                case CategoriaTecnicaEnum.FALLO_COMUN:
                    c._representacionNumerica = 2;
                    c._representacionSimbolica = "F";
                    c._representacionString = "Fallo Comun";
                    break;
                default:

                    break;
            }
            return c;
        }
    }
}

