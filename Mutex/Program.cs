using System;
using System.Threading;

namespace Mutex2
{
    class Program
    {
        static Mutex _mutex;


        //static bool IsSingleInstance()
        //{
        //    try
        //    {
        //        // Tenta abrir um mutex existente
        //        Mutex.OpenExisting("RENATO");
        //    }
        //    catch
        //    {
        //        // se não existir um mutex ocorre uma exceção
        //        Console.WriteLine("deu erro ao tentar abrir");
        //        Program._mutex = new Mutex(true, "RENATO");
        //        // Existe somente uma instância
        //        return true;
        //    }
        //    // Sem exceção então existe mais de uma instância
        //    return false;
        //}


        static bool abreum()
        {
            try
            {
                Mutex.OpenExisting("RENATO");
                Console.WriteLine("ok");
            }
            catch (Exception)
            {
                Console.WriteLine("deu erro ao tentar abrir");
                Program._mutex = new Mutex(true, "RENATO");
                // Existe somente uma instância
                return true;
            }
            Console.WriteLine("retorna falso");
            return false;
        }


        static void Main(string[] args)
        {
            if (!Program.abreum())
            {
                Console.WriteLine("Existe Mais de uma instância em execução"); //sair
            }
            else
            {
                Console.WriteLine("Existe somente Uma instância em Execução"); //Continuar
            }
            Console.ReadLine();

        }

    }
}
