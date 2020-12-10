using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface IBruch
    {

	//Definiert den Nenner des Bruchs
        int Nenner { get; set; }
	//Definiert den Zaehler des zu brechnenden Bruchs!!! 
        int Zaehler { get; set; }
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
