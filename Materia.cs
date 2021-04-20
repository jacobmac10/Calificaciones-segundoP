using System;

namespace calificaciones
{
    class Materia
    {
        // Atributos - características, información
        public int primerParcial;
        public int segundoParcial;
        public int tercerParcial;

        public Materia(int primerParcial, int segundoParcial, int tercerParcial)
        {
            this.primerParcial = primerParcial;
            this.segundoParcial = segundoParcial;
            this.tercerParcial = tercerParcial;

             if (!(primerParcial == 0 || primerParcial >= 5 && primerParcial <= 10))
            {
                throw new ArgumentException("La calificacion debe ser 0 o estar entre 5 y 10");
            }

            if (!(segundoParcial == 0 || segundoParcial >= 5 && segundoParcial <= 10))
            {
                throw new ArgumentException("La calificacion debe ser 0 o estar entre 5 y 10");
            }

            if (!(tercerParcial == 0 || tercerParcial >= 5 && tercerParcial <= 10))
            {
                throw new ArgumentException("La calificacion debe ser 0 o estar entre 5 y 10");
            }
        }

       



        public float CalcularPromedioParciales()
        {
            float Promedioparcial_1_2 = (primerParcial+segundoParcial)/2;
            Console.WriteLine("El promedio es:" + Promedioparcial_1_2);

            if(Promedioparcial_1_2 <= 11)
            {
                Console.WriteLine("No puedes continuar");
            }
            // TODO: calcular el promedio entre los 2 primeros parciales
            return Promedioparcial_1_2;
        }

        public float CalcularPromedioFinal()
        {
            float PromedioDeparciales = (((primerParcial+segundoParcial)/2)+tercerParcial)/2;
            Console.WriteLine("El promedio es:" + PromedioDeparciales);
            // TODO: calcular el promedio final
            return promedioDeparciales;
        }

        public bool RevisarRequiereAplicarEvaluacionExtraordinaria()
        {
            if (tercerParcial < 6)
            {
                Console.WriteLine("No tienes los suficientes puntos para continuar");
                
                return true;
            }else if(CalcularPromedioParciales()<12)
            {
                return true;
            }
            // TODO: revisar si se requiere aplicar o no una evaluación extraordinaria
            return false;
        }
    }
}