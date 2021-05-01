using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EXERCICE_01___PARAMS {
    class Calculator {
        //---------------------------- START --------------------------------//
        public static int Sum(params int[] numbers) { // ------------ > PARAMETRO PARA A CLASSE PRINCIPAL
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }
            return sum;
        }
        //-------------------------------- END -------------------------------//
    }
}
