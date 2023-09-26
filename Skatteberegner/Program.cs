    public class Beregning {
        static void Main(string[] args) {

        }
        
        // Funktionen returnerer det beløb, der skal beskattes (altså ikke selve skatten).
        public double SkatVedJulegave(double julegave, double andenGave) {
            double iAlt = julegave + andenGave;
            double beskattes = 0;
            switch (iAlt)
            {
                case > 1200.00:
                    beskattes = iAlt;
                    break;
                    
            }
            return beskattes;
        }
    }