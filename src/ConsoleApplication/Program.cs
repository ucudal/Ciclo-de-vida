//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {

        
        /// <summary>
        /// Como los objetos dejan de ser apuntados el garbage collector los va eliminando y por lo tanto no crashea el programa,
        ///  ya que la memoria es suficiente gracias a esto
        /// </summary>
        public static void Main()
        {   
            int i=0;
            while  (i!=10000000){
                Train train = new Train("Jorge");
                i++;
                Console.WriteLine(train.getContador);

            }

            
                Train t1= new Train("Last Train To London");
                Train t2= new Train("Last Train To London");
                Train t3=new Train("Runaway Train");
                Console.WriteLine(t1==t2);
                ///El resultado es False ya que t1 no es el mismo objeto que t2, por más que tengan el mismo identificador
                Console.WriteLine(t2==t3);
                ///El resultado es False ya que son diferentes objetos

            
        }
  
    }
}