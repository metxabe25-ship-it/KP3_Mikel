using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3POO_5
{
    /// <summary>
    /// Porra baten informazioa eta portaera definitzen duen klasea.
    /// </summary>
    class Porra
    {
        private string izena, irabazlea, finalista, goleatzailea;
        private int puntuak;

        public string Izena { get => izena; set => izena = value; }
        public string Irabazlea { get => irabazlea; set => irabazlea = value; }
        public string Finalista { get => finalista; set => finalista = value; }
        public string Goleatzailea { get => goleatzailea; set => goleatzailea = value; }

        public int Puntuak { get => puntuak; set => puntuak = value; }

        /// <summary>
        /// Porra objektu berri bat sortzen du.
        /// </summary>
        /// <param name="i">Izena.</param>
        /// <param name="ir">Irabazlea.</param>
        /// <param name="fi">Finalista.</param>
        /// <param name="go">Goleatzailea.</param>
        /// <param name="p">Hasierako puntuak.</param>
        public Porra(string i, string ir, string fi, string go, int p)
        {
            this.izena = i;
            this.irabazlea = ir;
            this.finalista = fi;
            this.goleatzailea = go;
            this.puntuak = p;
        }
        /// <summary>
        /// Porra baten informazioa testu moduan itzultzen du pantailan erakusteko.
        /// </summary>
        /// <returns>Porra-ren deskribapena.</returns>
        public string Pantailaratu()
        {
            return "TALDEA=" + izena + ", bere IRABAZLEA=" + irabazlea + ", beste FINALISTA=" + finalista + ", GOLEATZAILEA=" + goleatzailea + " eta PUNTUAK=" + puntuak;

        }
        /// <summary>
        /// Porra objektua testu kate batean bihurtzen du fitxategian gordetzeko.
        /// </summary>
        /// <returns>Testu formatuko porra.</returns>
        public override string ToString()
        {
            return izena + "-" + irabazlea + "-" + finalista + "-" + goleatzailea + "-" + puntuak;
        }
        /// <summary>
        /// Irabazlea asmatu bada puntuak gehitzen ditu.
        /// </summary>
        /// <returns>Eguneratutako puntuak.</returns>
        public int AsmatuIrabazlea()
        {
            return (puntuak + 25);
        }
        /// <summary>
        /// Bi finalistak asmatu badira puntuak gehitzen ditu.
        /// </summary>
        /// <returns>Eguneratutako puntuak.</returns>
        public int AsmatuBiFinalistak()
        {
            return (puntuak + 20);
        }
        /// <summary>
        /// Goleatzailea asmatu bada puntuak gehitzen ditu.
        /// </summary>
        /// <returns>Eguneratutako puntuak.</returns>
        public int Goleko()
        {
            return (puntuak + 3);
        }

    }
}
