using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialdeJonathanBenigni
{
    using System;

    public enum ColorRelleno
    {
        Rojo,
        Verde,
        Azul,

    }

    public enum TipoTrazo
    {
        Continuo,
        Rayas,
        Puntos
    }

    public class Cubo
    {
        public double Arista { get; set; }
        public ColorRelleno ColorRelleno { get; set; }
        public TipoTrazo TipoTrazo { get; set; }

        public double CalcularArea()
        {
            return 6 * Math.Pow(Arista, 2);
        }

        public double CalcularVolumen()
        {
            return Math.Pow(Arista, 3);
        }
    }



    public class RepositorioCubos
    {
        private List<Cubo> cubos = new List<Cubo>();

        public void AgregarCubo(Cubo cubo)
        {
            if (!CuboRepetido(cubo))
            {
                cubos.Add(cubo);
            }
            else
            {

            }
        }

        public List<Cubo> ObtenerCubos()
        {
            return cubos.ToList();
        }

        public int CantidadCubos()
        {
            return cubos.Count;
        }

        public void BorrarCubo(Cubo cubo)
        {
            cubos.Remove(cubo);
        }

        private bool CuboRepetido(Cubo cubo)
        {
            return cubos.Any(c => c.Arista == cubo.Arista);
        }


        public List<Cubo> OrdenarAscendente()
        {
            return cubos.OrderBy(c => c.Arista).ToList();
        }


        public List<Cubo> OrdenarDescendente()
        {
            return cubos.OrderByDescending(c => c.Arista).ToList();
        }




    }


}

