using System.Drawing;

namespace JuegoDeAjedrezTPG4Equipo8
{
    class Peon
    {
        /// <summary>
        /// Movimientos del peon
        /// </summary>
        /// <param name="puntoOrigen">punto de partida</param>
        /// <param name="puntoDestino">punto de destino</param>
        /// <param name="Turno">booleano para saber si mueve blancas o negras</param>
        /// <returns></returns>
        public bool Movimientos(Point puntoOrigen,Point puntoDestino,bool Turno)
        {
            int avanceY = puntoOrigen.Y - puntoDestino.Y;
            int avanceX = puntoOrigen.X - puntoDestino.X;
            if (Turno)
            {
                if (avanceY == -50 && avanceX == 0)
                {
                    return true;
                }
            }
            if (!Turno)
            {
                if (avanceY == 50 && avanceX == 0)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
