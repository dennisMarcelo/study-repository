/*
 System.Console
    - Está sempre habilitado e sempre grava no console.
    - Útil para informações que seu cliente talvez precise ver na versão.
    - Por ser a abordagem mais simples, costuma ser usado para a depuração temporária ad hoc. Geralmente, esse código de depuração nunca é submetido a check-in no controle do código-fonte.
 System.Diagnostics.Trace
    - Habilitado somente quando TRACE é definido.
    - Grava em Ouvintes anexados, por padrão, o DefaultTraceListener.
    - Use essa API ao criar logs que serão habilitados na maioria dos builds.
 System.Diagnostics.Debug
    - Habilitado somente quando DEBUG é definido (no modo de depuração).
    - Grava em um depurador anexado.
    - Use essa API ao criar logs que serão habilitados apenas em builds de depuração.
 */

using System.Diagnostics;
using System;

namespace Logs 
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("este treco funciona.");
         Trace.WriteLine("This is a trace message when tracing the app.");
         Debug.WriteLine("This is a debug message just for developers.");

         int result = Fibonacci(5);
         Console.WriteLine(result);

         static int Fibonacci(int n)
         {
            int n1 = 0;
            int n2 = 1;
            int sum;

            for (int i = 2; i < n; i++)
            {
               sum = n1 + n2;
               n1 = n2;
               n2 = sum;
            }

            return n == 0 ? n1 : n2;
         }
      }
   } 
}