using System;
namespace EXERCICE_01___PARAMS {
    //-----> INICIO
    ////////////////////////////////////////////////////////////////////////////////////////////
    class Program {
        static void Main(string[] args) {
            int s1 = Calculator.Sum( 2, 3); // --------------- > NÃO PRECISA DECLARAR O VETOR, JA DECLARADO NA CLASSE
            int s2 = Calculator.Sum( 2, 4, 3);

            Console.WriteLine(s1);
            Console.WriteLine(s2);           
        }
    }
    ////////////////////////////////////////////////////////////////////////////////////////////
    //-----> FIM
}
