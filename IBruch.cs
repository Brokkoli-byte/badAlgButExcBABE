using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface IBruch
    {
        /// <summary>
        /// getter für den Zaehler des Bruchs.
        /// </summary>
        /// <returns>Zaehler des Bruchs</returns>
        int getZaehler();
        /// <summary>
        /// getter für den Nenner des Bruchs.
        /// </summary>
        /// <returns>Nenner des Bruchs</returns
        int getNenner();
        /// <summary>
        /// kuerzt den Bruch soweit es möglich ist.
        /// </summary
        /// <summary>
        /// setzt den Zaehler des BruchObjektes
        /// </summary>
        /// <param name="zaehler">zu setzender ZaehlerWert</param>
        void setZaehler(int zaehler);
        /// <summary>
        /// setzt den Nenner des BruchObjektes
        /// </summary>
        /// <param name="nenner">zu setzender NennerWert</param>
        void setNenner(int nenner);
        void kuerzen();
        /// <summary>
        /// string-Repräsentation des Bruchs mit Zaehler und Nennerwerten.
        /// </summary>
        /// <returns></returns>
        string ausgabe();
        /// <summary>
        /// addiert einen anderen Bruch zu diesem Bruch.
        /// </summary>
        /// <param name="andererBruch">zu addierender Bruch</param>
        void add(IBruch andererBruch);
        /// <summary>
        /// subtrahiert einen anderen Bruch von diesem Bruch.
        /// </summary>
        /// <param name="andererBruch">zu subtrahierender Bruch</param>
        void sub(IBruch andererBruch);
        /// <summary>
        /// multipliziert diesen Bruch mit einem anderen Bruch.
        /// </summary>
        /// <param name="andererBruch">Faktor für die Multiplikation</param>
        void mult(IBruch andererBruch);
        /// <summary>
        /// Dividiert diesen Bruch durch einen anderen Bruch.
        /// </summary>
        /// <param name="andererBruch">Divisor für die Division</param>
        void div(IBruch andererBruch);
        /// <summary>
        /// gibt ein neues Bruchobjekt mit gleichen Werten für den Zaehler und den Nenner zurück.
        /// </summary>
        /// <returns>Kopie des aktuellen Bruchs</returns>
        IBruch copyThis();


    }
}
