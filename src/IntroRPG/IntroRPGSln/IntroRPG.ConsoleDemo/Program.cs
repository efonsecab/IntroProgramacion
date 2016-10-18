using IntroRPG.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroRPG.ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IntroRPG.Shared.GameController objGC = new Shared.GameController(100, 5);
            objGC.StartGame();
            bool bSalir = false;
            do
            {
                switch (objGC.TurnoActual)
                {
                    case Shared.Turno.Jugador:
                        Console.WriteLine(string.Format("Su turno. HP={0}", objGC.GetPlayerHP()));
                        if (objGC.TieneTarget())
                        {
                            int enemyHP = objGC.GetEnemyHP();
                            Console.WriteLine(string.Format("Tiene un enemigo. HP={0}", enemyHP));
                        }
                        Console.WriteLine("Selecciona su ataque");
                        Console.WriteLine("1. Rayo");
                        Console.WriteLine("2. Fuego");
                        Console.WriteLine("3. Tierra");
                        Console.WriteLine("4. Hielo");
                        Console.WriteLine("5. Agua");
                        Console.WriteLine("6. Viento");
                        ConsoleKeyInfo ataque = Console.ReadKey();
                        Console.WriteLine("");
                        bool ataqueRealizado = false;
                        Ataque objAtaqueJugador = null;
                        int damagePorJugador = 0;
                        bool nuevoEnemigo = false;
                        switch (ataque.Key)
                        {
                            case ConsoleKey.D1:
                            case ConsoleKey.NumPad1:
                                objAtaqueJugador=objGC.AtacarEnemigo(IntroRPG.Shared.TipoElemento.Rayo, out damagePorJugador, out nuevoEnemigo);
                                ataqueRealizado = true;
                                break;
                            case ConsoleKey.D2:
                            case ConsoleKey.NumPad2:
                                objAtaqueJugador = objGC.AtacarEnemigo(IntroRPG.Shared.TipoElemento.Fuego, out damagePorJugador, out nuevoEnemigo);
                                ataqueRealizado = true;
                                break;
                            case ConsoleKey.D3:
                            case ConsoleKey.NumPad3:
                                objAtaqueJugador = objGC.AtacarEnemigo(IntroRPG.Shared.TipoElemento.Tierra, out damagePorJugador, out nuevoEnemigo);
                                ataqueRealizado = true;
                                break;
                            case ConsoleKey.D4:
                            case ConsoleKey.NumPad4:
                                objAtaqueJugador = objGC.AtacarEnemigo(IntroRPG.Shared.TipoElemento.Hielo, out damagePorJugador, out nuevoEnemigo);
                                ataqueRealizado = true;
                                break;
                            case ConsoleKey.D5:
                            case ConsoleKey.NumPad5:
                                objAtaqueJugador = objGC.AtacarEnemigo(IntroRPG.Shared.TipoElemento.Agua, out damagePorJugador, out nuevoEnemigo);
                                ataqueRealizado = true;
                                break;
                            case ConsoleKey.D6:
                            case ConsoleKey.NumPad6:
                                objAtaqueJugador = objGC.AtacarEnemigo(IntroRPG.Shared.TipoElemento.Viento, out damagePorJugador, out nuevoEnemigo);
                                ataqueRealizado = true;
                                break;
                            default:
                                Console.WriteLine("Porfavor digite una opción válida");
                                break;
                        }
                        if (ataqueRealizado == true)
                        {
                            objGC.TurnoActual = Shared.Turno.Enemigo;
                            Console.WriteLine(string.Format("Ha atacado con {0}. Su enemigo pierde {1}HP", objAtaqueJugador.Tipo.ToString(), damagePorJugador));
                        }
                        if (nuevoEnemigo)
                            Console.WriteLine("Ha encontrado un nuevo enemigo");
                        break;
                    case Shared.Turno.Enemigo:
                        int dmg = 0;
                        Ataque objAtaque = objGC.AtacarJugador(out dmg);
                        Console.WriteLine("Ha sido atacado con {0}. Pierde {1}HP", objAtaque.Tipo.ToString(), dmg);
                        objGC.TurnoActual = Turno.Jugador;
                        break;
                }
                switch (objGC.CurrentGameplayStatus)
                {
                    case GameSessionStatus.PlayerWin:
                        Console.WriteLine("Felicidades! Ha ganado el juego");
                        bSalir = true;
                        break;
                    case GameSessionStatus.GameOver:
                        Console.WriteLine("Lo sentimos. Ha sufrido una derrota");
                        bSalir = true;
                        break;
                }
            } while (bSalir == false);
            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
        }
    }
}
