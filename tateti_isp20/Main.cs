using System;

namespace tateti_isp20
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//declarando e inicializando el juego
			Juego juego=new Juego();
			//variables auxiliares necesarias
			int jugador_actual=1;
			int ficha_actual=1;
			int ficha_a_mover=0;
			int posicion_elegida=0;
			while (true) 
			{
				juego.PintarTablero();
				//cuando ya se colocaron las 6 fichas
				//pide definir la ficha a mover
				if (ficha_actual==0)
				{
					juego.SeleccionarFicha(jugador_actual, ref ficha_a_mover);
					juego.SeleccionarPosicion(jugador_actual,ficha_a_mover,ref posicion_elegida);
					juego.Jugar(jugador_actual,ficha_a_mover,posicion_elegida);
				}
				//en las primeras 6 fichas se ejecuta
				//esto
				else
				{
					juego.SeleccionarPosicion(jugador_actual,ficha_actual, ref posicion_elegida);
					//almacenar el movimiento en el tablero y en las fichas
					//del jugador
					//Console.WriteLine("posicion elegida vale {0}", posicion_elegida);
					//Console.ReadKey();
					juego.Jugar(jugador_actual,ficha_actual,posicion_elegida);
					//cambio de jugador
				}
				//comprobaciones varias
				jugador_actual++;
				if (jugador_actual==3)
				{
					jugador_actual=1;
					if (ficha_actual>0)
					{
						ficha_actual++;
						if (ficha_actual==4)
							ficha_actual=0;
					}
				}
			}
		}
	}
}
