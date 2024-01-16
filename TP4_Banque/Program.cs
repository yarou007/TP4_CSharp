using System;



namespace TP4_Banque
{

    public class Program {
        public static void Main(string[] args) { 
        
            Compte c = new Compte();
            // Compte simple 
            Console.WriteLine("Compte simple ---father class--- ");
            c.depot(150); // depot 150
            c.retrait(50);  // retrait 50 = 100 solde
            Console.WriteLine(c.ToString());
            // Compte Epargne 
            Console.WriteLine("Compte Epargne ---child class--- ");
            CompteEpargne ce = new CompteEpargne();
            ce.depot(150); // zedna taux donc tsabou  159
            ce.retrait(50);  // retrait simple 
            ce.calculInteret();
            Console.WriteLine(ce.ToString()); //109 solde
            // Compte Payant 
            Console.WriteLine("Compte Payant ---child class--- ");
            ComptePayant cp = new ComptePayant();
            cp.depot(150); // depot 150 ----> 145
            cp.retrait(50); // retrait 50 -----> 90
            Console.WriteLine(cp.ToString());



        }
    }

}