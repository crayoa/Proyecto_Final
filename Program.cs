using System;
					
public class Program
{
	public static void Main()
	{
        int opc=0;
        int cant = 0;
        int vot = 0;
        int column = 4;
        string [,] matrix = null;
        int [] votos = null;
        int index = 0;
        int prom = 0;
        double result = 0;
        

        do
        {
            Console.Clear();
            Console.WriteLine("-------BIENVENIDO AL SISTEMA DE VOTACIONES-------");
            Console.WriteLine("0. Pre-Carga de Candidatos.");
            Console.WriteLine("1. Carga de Votos.");
            Console.WriteLine("2. Mostrar Candidatos.");
            Console.WriteLine("3. Mostrar los Resultados.");
            Console.WriteLine("4. Salir.");
            
            Console.WriteLine("Dime que opcion te gustaria seleccionar: ");
            opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 0:
                Console.Clear();
                Console.WriteLine("¿Cuantos Candidatos Ingresaras?");
                cant = Convert.ToInt32(Console.ReadLine());
                votos = new int[cant];

                 matrix = new string [cant,column];
                
                int buffer = 0;
                 for (int i = 0; i < cant; i++) 
                 {
                    for (int j = 0; j < 3; j++) 
                        {
                            
                            if (j == 0)
                            {
                                buffer = buffer + 1;
                                matrix[i,j] = buffer.ToString();
                            }else if (j == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("--------CANDIDATO # "+ buffer + "--------" );
                                Console.WriteLine("Ingrese Nombre del Candidato" );
                                matrix[i,j] = Convert.ToString(Console.ReadLine());
                            }else
                            {
                                Console.WriteLine("Ingrese el Nombre del Partido");
                                matrix[i,j] = Convert.ToString(Console.ReadLine());
                            }
                    }
                }
                break;

                case 1:
                    Console.Clear(); 
                    Console.WriteLine("--------INGRESO DE VOTOS--------" );
                    vot = 1;
                    while (vot !=0 )
                    {
                        
                        vot= Convert.ToInt32(Console.ReadLine());
                        if (vot == 0)
                        {
                            Console.WriteLine("Listo....! Votos Cargados.");
                            break;
                            
                        }else
                        {
                            prom = prom + 1;
                            index = vot - 1;
                            votos[index] = votos[index] + 1;
                        }
                        
                    }


                break;

                case 2:
                 Console.Clear();
                 Console.WriteLine("");
                 Console.WriteLine("--------CANDIDATOS---------------");
                 Console.WriteLine("");
                     for (int i = 0; i < cant; i++)
                        {
                            for (int j = 0; j < 3; j++)
                                {
                                    if (j == 0)
                                    {
                                        Console.WriteLine("");
                                        Console.Write("Identificador: " + matrix[i,j] + "\t");
                                        Console.WriteLine("");
                                    }else if (j == 1)
                                    {
                                        Console.Write("Candidato: " + matrix[i,j] + "\t");
                                        Console.WriteLine("");
                                    }else
                                    {
                                        Console.Write("Partido: " + matrix[i,j] + "\t");
                                        Console.WriteLine("");
                                    }
                                   
                                }
                                    
                        }

                break;

                case 3:
                    Console.Clear();
                    for (int i = 0; i < cant; i++) 
                    {
                        for (int j = 3; j < 4; j++) 
                            { 
                                result = votos[i];
                                result = (result/prom)*100;
                                matrix[i,j] = result.ToString("0");

                            }
                    }
                    Console.WriteLine("--------RESULTADOS DE LA VOTACION---------------");
                    Console.WriteLine("");
                    for (int i = 0; i < cant; i++)
                    {
                        for (int j = 0; j < column; j++)
                        {
                            if (j == 3)
                            {
                            Console.Write(matrix[i,j] + "%");
                            }else
                            {
                            Console.Write(matrix[i,j] + "\t");
                            }
                            
                        }
                        Console.WriteLine("");
                    }
                break;

                case 4:
                Console.WriteLine("Gracias por usar nuestro programa, ¡hasta luego!");
                break;
                
                default:
                Console.WriteLine("Selecciona una opcion de nuestra lista.....");
                break;
            }

            Console.ReadKey();
        } while (opc!=4);

    } 
    
    
}
