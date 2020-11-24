using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace JuegoDeAjedrezTPG4Equipo8
{
    public partial class Form1 : Form
    {
        #region Propiedades
        PictureBox seleccionado = null;                     //PictureBox que toma el valor de la Pieza
        PictureBox Destino = null;                          //PictureBox que toma el lugar de la pieza que sera comida (AUN EN PRUEBA)
        List<PictureBox> Blancas = new List<PictureBox>();  //Lista de piezas Blancas
        List<PictureBox> Negras = new List<PictureBox>();   //Lista de piezas Negras
        private bool TurnoBlancas = true;                   //TurnoBlancas = True, Mueven las blancas
                                                            //TurnoBlancas = false, Mueven las negras
        private int turno = 0;                              //Contador de turnos
        private string NombrePieza;                         //Variable para saber que pieza se esta moviendo
        #endregion

        public Form1()
        {
            InitializeComponent();
            CargarListas();
        }
        //Crea las listas con piezas negras y blancas
        private void CargarListas()
        {
            Blancas.Add(PeonBlanco1);
            Blancas.Add(PeonBlanco2);
            Blancas.Add(PeonBlanco3);
            Blancas.Add(PeonBlanco4);
            Blancas.Add(PeonBlanco5);
            Blancas.Add(PeonBlanco6);
            Blancas.Add(PeonBlanco7);
            Blancas.Add(PeonBlanco8);
            Blancas.Add(TorreBlanco1);
            Blancas.Add(TorreBlanco2);
            Blancas.Add(CaballoBlanco1);
            Blancas.Add(CaballoBlanco2);
            Blancas.Add(AlfilBlanco1);
            Blancas.Add(AlfilBlanco2);
            Blancas.Add(ReyBlanco);
            Blancas.Add(ReinaBlanco);

            Negras.Add(PeonNegro1);
            Negras.Add(PeonNegro2);
            Negras.Add(PeonNegro3);
            Negras.Add(PeonNegro4);
            Negras.Add(PeonNegro5);
            Negras.Add(PeonNegro6);
            Negras.Add(PeonNegro7);
            Negras.Add(PeonNegro8);
            Negras.Add(TorreNegro1);
            Negras.Add(TorreNegro2);
            Negras.Add(CaballoNegro1);
            Negras.Add(CaballoNegro2);
            Negras.Add(AlfilNegro1);
            Negras.Add(AlfilNegro2);
            Negras.Add(ReyNegro);
            Negras.Add(ReinaNegro);
        }
        //Pieza seleccionada
        public void Seleccion(object objeto)
        {
            try
            {
                seleccionado.BackColor = Color.Transparent;
            }
            catch
            { }
            PictureBox ficha = (PictureBox)objeto;
            seleccionado = ficha;
            seleccionado.BackColor = Color.Lime;
        }
        //Punto de llegada
        private void CuadroClick(object sender, MouseEventArgs e)
        {
            Movimiento((PictureBox)sender);
        }

        public void Movimiento(PictureBox cuadro)
        {
            if (seleccionado != null)
            {
                switch (NombrePieza)
                {
                    case "peon":
                        if (ValidacionPeon(seleccionado, cuadro))//VALIDAION
                        {
                            seleccionado.Location = cuadro.Location;
                            turno++;
                            TurnoBlancas = !TurnoBlancas;
                            NombrePieza = null;
                        } break;
                    case "alfil":
                        if (ValidacionAlfil(seleccionado, cuadro))//VALIDAION
                        {
                            seleccionado.Location = cuadro.Location;
                            turno++;
                            TurnoBlancas = !TurnoBlancas;
                            NombrePieza = null;
                        }break;
                    case "caballo":
                        if (ValidacionCaballo(seleccionado, cuadro))//VALIDAION
                        {
                            seleccionado.Location = cuadro.Location;
                            turno++;
                            TurnoBlancas = !TurnoBlancas;
                            NombrePieza = null;
                        }
                        break;
                    case "torre":
                        if (ValidacionTorre(seleccionado, cuadro))//VALIDAION
                        {
                            seleccionado.Location = cuadro.Location;
                            turno++;
                            TurnoBlancas = !TurnoBlancas;
                            NombrePieza = null;
                        }
                        break;
                    case "reina":
                        if (ValidacionReina(seleccionado, cuadro))//VALIDAION
                        {
                            seleccionado.Location = cuadro.Location;
                            turno++;
                            TurnoBlancas = !TurnoBlancas;
                            NombrePieza = null;
                        }
                        break;
                    case "rey":
                        if (ValidacionRey(seleccionado, cuadro))//VALIDAION
                        {
                            seleccionado.Location = cuadro.Location;
                            turno++;
                            TurnoBlancas = !TurnoBlancas;
                            NombrePieza = null;
                        }
                        break;
                }

            }
        }
        /// <summary>
        /// Metodo para verificar si una posicion esta ocupada
        /// </summary>
        /// <param name="punto">Punto de destino</param>
        /// <param name="bando">Lista de piezas de color contrario</param>
        /// <returns></returns>
        private bool Ocupado(Point punto,List<PictureBox> bando)
        {
            for(int i = 0; i < bando.Count; i++)
            {
                if (punto == bando[i].Location)
                {
                    return true;
                }
            }
            return false;
        }
        #region Validacion de movimiento
        /// <summary>
        /// Movimiento del peon
        /// </summary>
        /// <param name="origen">punto de partida de la pieza</param>
        /// <param name="destino">punto de llegada de la pieza</param>
        /// <returns></returns>
        private bool ValidacionPeon(PictureBox origen,PictureBox destino)
        {
            Point puntoOrigen = origen.Location;
            Point puntoDestino = destino.Location;
            Peon peon = new Peon();
            return peon.Movimientos(puntoOrigen, puntoDestino, TurnoBlancas);
        }
        private bool ValidacionAlfil(PictureBox origen, PictureBox destino)
        {
            Point puntoOrigen = origen.Location;
            Point puntoDestino = destino.Location;
            Alfil alfil = new Alfil();
            return alfil.Movimientos(puntoOrigen, puntoDestino, TurnoBlancas);
        }
        private bool ValidacionCaballo(PictureBox origen, PictureBox destino)
        {
            Point puntoOrigen = origen.Location;
            Point puntoDestino = destino.Location;
            Caballo caballo = new Caballo();
            return caballo.Movimientos(puntoOrigen, puntoDestino, TurnoBlancas);
        }
        private bool ValidacionTorre(PictureBox origen, PictureBox destino)
        {
            Point puntoOrigen = origen.Location;
            Point puntoDestino = destino.Location;
            Torre torre = new Torre();
            return torre.Movimientos(puntoOrigen, puntoDestino, TurnoBlancas);
        }
        private bool ValidacionReina(PictureBox origen, PictureBox destino)
        {
            Point puntoOrigen = origen.Location;
            Point puntoDestino = destino.Location;
            Reina reina = new Reina();
            return reina.Movimientos(puntoOrigen, puntoDestino, TurnoBlancas);
        }
        private bool ValidacionRey(PictureBox origen, PictureBox destino)
        {
            Point puntoOrigen = origen.Location;
            Point puntoDestino = destino.Location;
            Rey rey = new Rey();
            return rey.Movimientos(puntoOrigen, puntoDestino, TurnoBlancas);
        }

        #endregion

        #region Turnos de las piezas
        private void SeleccionNegras(object sender, MouseEventArgs e)
        {
            if (turno % 2 == 1)
            {
                Seleccion(sender);
            }
        }

        private void SeleccionBlancas(object sender, MouseEventArgs e)
        {
            if (turno % 2 == 0)
            {
                Seleccion(sender);
            }
        }

        private void SeleccionPeonNegro(object sender, MouseEventArgs e)
        {
            if (turno % 2 == 1)
            {
                Seleccion(sender);
                NombrePieza = "peon";
            }
        }

        private void SeleccionPeonBlanco(object sender, MouseEventArgs e)
        {
            if (turno % 2 == 0)
            {
                Seleccion(sender);
                NombrePieza = "peon";
            }
        }

        private void SeleccionCaballoBlanco(object sender, MouseEventArgs e)
        {
            if (turno % 2 == 0)
            {
                Seleccion(sender);
                NombrePieza = "caballo";
            }
        }

        private void SeleccionCaballoNegro(object sender, MouseEventArgs e)
        {
            if (turno % 2 == 1)
            {
                Seleccion(sender);
                NombrePieza = "caballo";
            }
        }

        private void SeleccionAlfilBlanco(object sender, MouseEventArgs e)
        {
            if (turno % 2 == 0)
            {
                Seleccion(sender);
                NombrePieza = "alfil";
            }
        }

        private void SeleccionAlfilNegra(object sender, MouseEventArgs e)
        {
            if (turno % 2 == 1)
            {
                Seleccion(sender);
                NombrePieza = "alfil";
            }
        }

        private void SeleccionTorreBlanca(object sender, MouseEventArgs e)
        {
            if (turno % 2 == 0)
            {
                Seleccion(sender);
                NombrePieza = "torre";
            }
        }

        private void SeleccionTorreNegra(object sender, MouseEventArgs e)
        {
            if (turno % 2 == 1)
            {
                Seleccion(sender);
                NombrePieza = "torre";
            }
        }

        private void SeleccionReinaBlanca(object sender, MouseEventArgs e)
        {
            if (turno % 2 == 0)
            {
                Seleccion(sender);
                NombrePieza = "reina";
            }
        }

        private void SeleccionReinaNegra(object sender, MouseEventArgs e)
        {
            if (turno % 2 == 1)
            {
                Seleccion(sender);
                NombrePieza = "reina";
            }
        }

        private void SeleccionReyNegra(object sender, MouseEventArgs e)
        {
            if (turno % 2 == 1)
            {
                Seleccion(sender);
                NombrePieza = "rey";
            }
        }

        private void SeleccionReyBlanca(object sender, MouseEventArgs e)
        {
            if (turno % 2 == 0)
            {
                Seleccion(sender);
                NombrePieza = "rey";
            }
        }
        #endregion
    }
}
