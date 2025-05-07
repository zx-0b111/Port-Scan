using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Escaneador
    {
        private static string ip;
        private static int porta;
        
    
    public static void DetectTCP()
    {
        while (true)
        {
                TcpClient tcpClient = new TcpClient();

                Console.Write("Ip: ");
                ip = Console.ReadLine();

                Console.Write("Porta: ");
                porta = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < porta; i++)
                {
                  try
                     {
                        tcpClient.Connect(ip, porta);

                        if (tcpClient.Connected)
                        {
                            Console.WriteLine("Porta aberta " + i);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Porta fechada " + i);
                    }

                }
            }
        }
    }
}
