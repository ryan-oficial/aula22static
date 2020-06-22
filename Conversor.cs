namespace Aula22Static
{
    public static class Conversor
    {
        private static float CotacaoDolar = 5.29f;
        private static float CotacaoEuro = 5.90f;

        public static float ConversorRealParaDolar(float valorRS){
            return valorRS / CotacaoDolar;
        }

        public static float ConversorDolarParaReal(float valorUS){
            return valorUS * CotacaoDolar;
        }

        public static float ConversorRealParaEuro(float valorRS){
            return valorRS / CotacaoEuro;
        }
        public static float ConversorEuroParaReal(float valorEU){
            return valorEU * CotacaoEuro;
        }
    }
}