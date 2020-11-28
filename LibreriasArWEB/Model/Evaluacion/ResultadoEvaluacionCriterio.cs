using LibreriasArWEB.Model.Criterios;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasArWEB.Model.Evaluacion
{
   public class ResultadoEvaluacionCriterio
    {
		private static int PUNTAJE_CRITERIO_OK;// = Constantes.PUNTAJE_CRITERIO_OK;
		private static int PUNTAJE_CRITERIO_ERROR;// = Constantes.PUNTAJE_CRITERIO_ERROR;
		private Criterio criterio;
		private List<ResultadoEvaluacionTecnica> resultadoEvaluacionTecnicas;

		public ResultadoEvaluacionCriterio(Criterio criterio)
		{
			this.setCriterio(criterio);
			this.setResultadoEvaluacionTecnicas(new LinkedList<ResultadoEvaluacionTecnica>());
		}

		public void agregarResultadoEvaluacionTecnica(ResultadoEvaluacionTecnica resultadoEvaluacionTecnica)
		{
			this.getResultadoEvaluacionTecnicas().add(resultadoEvaluacionTecnica);
		}

		public bool isOKResultadoEvaluacionCriterio()
		{
			if (this.getResultadoEvaluacionTecnicas().size() == 0)
				return true;
			for (ResultadoEvaluacionTecnica resultadoEvaluacionTecnica : this.getResultadoEvaluacionTecnicas())
				if (!resultadoEvaluacionTecnica.isOKResultadoEvaluacionTecnica())
					return false;
			return true;
		}

		public int getPuntosPorCriterio()
		{
			try
			{
				Properties properties = new Properties();
				properties.load(ValidarAccesibilidadService.class.getResourceAsStream("/ar/edu/uade/tic/tesis/arweb/configuracion/Config.properties"));
			PUNTAJE_CRITERIO_OK = Integer.parseInt(properties.get("PUNTAJE_CRITERIO_OK").toString());
			PUNTAJE_CRITERIO_ERROR = Integer.parseInt(properties.get("PUNTAJE_CRITERIO_ERROR").toString());
		} catch (Exception ex) {
			throw new Exception(ex)
		}
return this.isOKResultadoEvaluacionCriterio() ? ResultadoEvaluacionCriterio.PUNTAJE_CRITERIO_OK : ResultadoEvaluacionCriterio.PUNTAJE_CRITERIO_ERROR;
	}

	public Integer getCantidadOKPorCriterio()
{
	return this.getCantidadPorCriterio(TipoResultadoEvaluacion.OK);
}

public Integer getCantidadErrorPorCriterio()
{
	return this.getCantidadPorCriterio(TipoResultadoEvaluacion.ERROR);
}

public Integer getCantidadErrorPorCriterioTecnicasSuficiente()
{
	return this.getCantidadPorCriterio(TipoResultadoEvaluacion.ERROR, CategoriaTecnica.SUFICIENTE);
}

public Integer getCantidadErrorPorCriterioTecnicasRecomendable()
{
	return this.getCantidadPorCriterio(TipoResultadoEvaluacion.ERROR, CategoriaTecnica.RECOMENDABLE);
}

public Integer getCantidadManualPorCriterio()
{
	return this.getCantidadPorCriterio(TipoResultadoEvaluacion.MANUAL);
}

public Integer getCantidadManualPorCriterioTecnicasSuficiente()
{
	return this.getCantidadPorCriterio(TipoResultadoEvaluacion.MANUAL, CategoriaTecnica.SUFICIENTE);
}

public Integer getCantidadManualPorCriterioTecnicasRecomendable()
{
	return this.getCantidadPorCriterio(TipoResultadoEvaluacion.MANUAL, CategoriaTecnica.RECOMENDABLE);
}

public Integer getCantidadImposiblePorCriterio()
{
	return this.getCantidadPorCriterio(TipoResultadoEvaluacion.IMPOSIBLE);
}

public Integer getCantidadImposiblePorCriterioTecnicasSuficiente()
{
	return this.getCantidadPorCriterio(TipoResultadoEvaluacion.IMPOSIBLE, CategoriaTecnica.SUFICIENTE);
}

public Integer getCantidadImposiblePorCriterioTecnicasRecomendable()
{
	return this.getCantidadPorCriterio(TipoResultadoEvaluacion.IMPOSIBLE, CategoriaTecnica.RECOMENDABLE);
}

private Integer getCantidadPorCriterio(TipoResultadoEvaluacion tipoResultadoEvaluacion)
{
	Integer cantidad = 0;
	for (ResultadoEvaluacionTecnica resultadoEvaluacionTecnica : this.getResultadoEvaluacionTecnicas())
			switch (tipoResultadoEvaluacion.getRepresentacionNumerica())
{
	case 1: cantidad += resultadoEvaluacionTecnica.getCantidadOKPorTecnica(); break;
	case 2: cantidad += resultadoEvaluacionTecnica.getCantidadErrorPorTecnica(); break;
	case 3: cantidad += resultadoEvaluacionTecnica.getCantidadManualPorTecnica(); break;
	case 4: cantidad += resultadoEvaluacionTecnica.getCantidadImposiblePorTecnica(); break;
}
return cantidad;
	}

	private Integer getCantidadPorCriterio(TipoResultadoEvaluacion tipoResultadoEvaluacion, CategoriaTecnica categoriaTecnica)
{
	Integer cantidad = 0;
	for (ResultadoEvaluacionTecnica resultadoEvaluacionTecnica : this.getResultadoEvaluacionTecnicas())
			if (resultadoEvaluacionTecnica.getTecnica().getCategoriaTecnica().getRepresentacionNumerica().equals(categoriaTecnica.getRepresentacionNumerica()))
	switch (tipoResultadoEvaluacion.getRepresentacionNumerica())
	{
		case 1: cantidad += resultadoEvaluacionTecnica.getCantidadOKPorTecnica(); break;
		case 2: cantidad += resultadoEvaluacionTecnica.getCantidadErrorPorTecnica(); break;
		case 3: cantidad += resultadoEvaluacionTecnica.getCantidadManualPorTecnica(); break;
		case 4: cantidad += resultadoEvaluacionTecnica.getCantidadImposiblePorTecnica(); break;
	}
return cantidad;
	}

	public Criterio getCriterio()
{
	return this.criterio;
}

public void setCriterio(Criterio criterio)
{
	this.criterio = criterio;
}

public List<ResultadoEvaluacionTecnica> getResultadoEvaluacionTecnicas()
{
	return this.resultadoEvaluacionTecnicas;
}

public void setResultadoEvaluacionTecnicas(List<ResultadoEvaluacionTecnica> resultadosEvaluacionTecnica)
{
	this.resultadoEvaluacionTecnicas = resultadosEvaluacionTecnica;
}

public String toString()
{
	String tecnica = "\n";
	for (ResultadoEvaluacionTecnica resultadoEvaluacionTecnica : this.getResultadoEvaluacionTecnicas())
			tecnica += resultadoEvaluacionTecnica.toString() + "\n";
return this.getCriterio().toString() + tecnica;
	}
    }
}
