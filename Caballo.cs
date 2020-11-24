using System;
using System.Drawing;

namespace JuegoDeAjedrezTPG4Equipo8
{
    class Caballo
    {
        /// <summary>
        /// Movimientos del peon
        /// </summary>
        /// <param name="puntoOrigen">punto de partida</param>
        /// <param name="puntoDestino">punto de destino</param>
        /// <param name="Turno">booleano para saber si mueve blancas o negras</param>
        /// <returns></returns>
        public bool Movimientos(Point puntoOrigen, Point puntoDestino, bool Turno)
        {
            int avanceY = puntoOrigen.Y - puntoDestino.Y;
            int avanceX = puntoOrigen.X - puntoDestino.X;

            if (Math.Abs(avanceY) == 50 && Math.Abs(avanceX) == 100 || Math.Abs(avanceY) == 100 && Math.Abs(avanceX) == 50)
            {
                return true;
            }
            return false;
        }

    }
}
