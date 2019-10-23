using System;

namespace ExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Insere um número inteiro: ");
                int i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Número inserido: {i}");
            } catch (FormatException e)
            {
                Console.WriteLine("\nNão foi inserido um número inteiro.");
            } catch (OverflowException e)
            {
                Console.WriteLine("\nFoi inserido um número inteiro " +
                    "demasiado grande ou pequeno.");
            } catch (Exception e)
            {
                Console.WriteLine($"\nOcorreu o seguinte erro: {e.Message}");
            } finally
            {
                Console.WriteLine("\nObrigado por ter utilizado este " +
                    "programa!");
            }
        }
    }
}
