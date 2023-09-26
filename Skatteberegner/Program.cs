    public class Beregning {
        static void Main(string[] args) {

        }
        
        // Funktionen returnerer det beløb, der skal beskattes (altså ikke selve skatten).
        public double SkatVedJulegave(double julegave, double andenGave) {
            double iAlt = julegave+andenGave;
            double beskattes = 0.00;
            if(iAlt>1200)
            {
                if(julegave<901) return andenGave;
                else return iAlt;
            }
            else return beskattes; 
        }
    }