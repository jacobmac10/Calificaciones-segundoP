using System;
using System.Collections.Generic;

namespace calificaciones
{
        class Parcial
    {
       
        public List<Criterio> criterios = new List<Criterio>();


        // TODO: calcularlo

        public void AgregarCriterio(Criterio criterio)
        {
            this.criterios.Add(criterio);
        }
        // Suma de criterios da 100%
        // Criterios distintos
        // Debe haber por lo menos 1 criterio

        public bool ValidarSumaCriterios(float porcentaje)
        {   
            float suma1 = 0f;

            for (int i = 0; i < this.criterios.Count; i++)
            {
                suma1 = suma1 + this.criterios[i].porcentaje;

            }
            if (suma1 == 1.0f)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        public bool ValidarCriteriosDistintos()
        {
            // TODO: validar que todos los criterios tienen nombre distinto
            return true;
        }

        public bool ValidarCriteriosDefinidos()
        {
            // TODO: validar que por lo menos hay 1 criterio
            return true;
        }

        public int CalcularCalificacion(List<float> calificacionesDeCadaCriterio)
        {
            return 10;
        }
    }

}