using System;

namespace Lol {

    class Program {

        static void Main() {

            Graph hi = new Graph();
            hi.Add_V("first");
            hi.Add_V("second");
            hi.Add_V("third");
            hi.Add_E(1, 2, 1);
            hi.Add_E(1, 3, 4);
            hi.Add_E(2, 1, 8);
            
            hi.ShowGraph();
            System.Console.WriteLine();
            hi.Del_E(1, 2);
            //hi.Del_V("first");
            hi.ShowGraph();
        }


    }



}