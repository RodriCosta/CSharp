
namespace RefeOut
{
    class Calculator
    {
        public static void Triple( ref int x)
        {

            x = x * 3;

        }


        public static void Doub(int origem, out int resultado) {

            resultado = origem * 2;

        }
    }

}