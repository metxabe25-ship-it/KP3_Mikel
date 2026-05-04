namespace _3POO_5
{
    /// <summary>
    /// Programaren klase nagusia.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Porra zerrenda gordetzen duen lista estatikoa.
        /// </summary>
        static List<Porra> lp = new List<Porra>();
        /// <summary>
        /// Programaren sarrera puntua. Menu nagusia kudeatzen du eta erabiltzailearen aukerak exekutatzen ditu.
        /// </summary>
        static void Main()
        {
            int eragiketa;
            FitxategiaIrakurri();
            {
                do
                {
                    Console.WriteLine("***** PORRA ***********");
                    Console.WriteLine("Ze ariketa nahi duzun egin? Sartu bere zenbakia:");
                    Console.WriteLine("1.- Egungo porra ikusi");
                    Console.WriteLine("2.- Emaitzak sartu");
                    Console.WriteLine("3.- IRTEN");
                    eragiketa = int.Parse(Console.ReadLine());
                    switch (eragiketa)
                    {
                        case 1:
                            InprimatuPorrak();
                            break;
                        case 2:
                            SartuEmaitzak();
                            break;
                        case 3:
                            FitxategiraPuntuak();
                            return;
                        default:
                            Console.WriteLine(" *****ERAGIKETA EZ ONARTUA *****");
                            break;
                    }
                } while (eragiketa != 3);
            }
        }
        // <summary>
        /// Erabiltzaileari emaitzak sartzeko aukera ematen dio eta puntuak eguneratzen ditu.
        /// </summary>
        static void SartuEmaitzak()
        {
            Console.WriteLine("Zein izan dira gaurko bi arerioak, finalistak?");
            string are1 = Console.ReadLine();
            string are2 = Console.ReadLine();
            FinalisteiPuntuEguneraketa(are1, are2);
            Console.WriteLine("Eta zein izan da irabazlea? Enpate egon bada sakatu intro");
            string ir = Console.ReadLine();
            IrabazleeiPuntuEguneraketa(ir);
            int golkop = lortugolak();
            for (int i = 1; i <= golkop; i++)
            {
                Console.WriteLine("Sartu " + i + ". golaren egilea:");
                string goleatzaile = Console.ReadLine();
                GoleatzaileenPuntuEguneraketa(goleatzaile);
            }
        }
        /// <summary>
        /// Erabiltzaileari sartutako gol kopurua eskatzen dio eta balio zuzena itzultzen du.
        /// </summary>
        static int lortugolak()
        {
            while (true)
            {
                Console.WriteLine("Zenbat gol egon dira gaur?");
                try
                {
                    int golkop = int.Parse(Console.ReadLine());
                    return golkop;
                }
                catch
                {
                    Console.Write("Zenbaki desegokia...");
                }
            }
        }
        /// <summary>
        /// Irabazlea asmatu duten partaideen puntuak eguneratzen ditu.
        /// </summary>
        /// /// <param name="ir">Irabazlearen izena.</param>
        static void IrabazleeiPuntuEguneraketa(string ir)
        {
            for (int i = 0; i < lp.Count; i++)
            {
                if (lp[i].Irabazlea == ir)
                {
                    lp[i].Puntuak = lp[i].AsmatuIrabazlea();
                }
            }
        }
        /// <summary>
        /// Bi finalistak asmatu dituzten partaideen puntuak eguneratzen ditu.
        /// </summary>
        /// <param name="fi">Lehen finalista.</param>
        /// <param name="ir">Bigarren finalista.</param>
        static void FinalisteiPuntuEguneraketa(string fi, string ir)
        {
            for (int i = 0; i < lp.Count; i++)
            {
                if (((lp[i].Finalista == fi) && (lp[i].Irabazlea == ir) || (lp[i].Finalista == ir) && (lp[i].Irabazlea == fi)))
                {
                    lp[i].Puntuak = lp[i].AsmatuBiFinalistak();
                }
            }
        }
        /// <summary>
        /// Goleatzailea asmatu duten partaideen puntuak eguneratzen ditu.
        /// </summary>
        /// <param name="gol">Goleatzailearen izena.</param>
        static void GoleatzaileenPuntuEguneraketa(string gol)
        {
            for (int i = 0; i < lp.Count; i++)
            {
                if (lp[i].Goleatzailea == gol)
                {
                    lp[i].Puntuak = lp[i].Goleko();
                }
            }
        }
        /// <summary>
        /// Fitxategitik porren datuak irakurtzen ditu eta zerrendan kargatzen ditu.
        /// </summary>
        static void FitxategiaIrakurri()
        {
            StreamReader sr = new StreamReader("porrak.txt");
            String lerroa;
            lerroa = sr.ReadLine();
            while (lerroa != null)
            {
                string[] zatitua = lerroa.Split("-");
                Porra p = new Porra(zatitua[0], zatitua[1], zatitua[2], zatitua[3], int.Parse(zatitua[4]));
                lp.Add(p);
                lerroa = sr.ReadLine();
            }
            sr.Close();

        }
        /// <summary>
        /// Uneko puntuak fitxategian gordetzen ditu.
        /// </summary>
        static void FitxategiraPuntuak()
        {
            StreamWriter sw = new StreamWriter("porrak.txt", false);
            foreach (Porra p in lp)
            {

                sw.WriteLine(p.ToString());
            }
            sw.Close();
        }
        /// <summary>
        /// Uneko porren egoera pantailan bistaratzen du.
        /// </summary>
        static void InprimatuPorrak()
        {
            Console.WriteLine("************************** EGUNGO PORRAREN EGOERA **********************************");
            foreach (Porra p in lp)
            {
                Console.WriteLine(p.Pantailaratu());
            }
            Console.WriteLine("");
        }
    }
}
