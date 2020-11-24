using System.Drawing;

namespace JuegoDeAjedrezTPG4Equipo8
{
    class Piezas
    {
        #region Propiedades
        private string nombre;
        private int puntos;
        #endregion

        #region Constructor
        public Piezas(string nombre,int puntos)
        {
            Nombre = nombre;
            Puntos = puntos;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Puntos { get => puntos; set => puntos = value; }
        #endregion

        #region Metodos
        private void Desicion(Piezas piezaJugada )
        {
            Piezas pieza = piezaJugada;
            if (pieza.nombre == "Peon")
            {

            }
        }
        #endregion

    }
}
