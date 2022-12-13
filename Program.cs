using System;

namespace Lol {

    class Program {

        static void Main() {

            Graph hi = new Graph();
            hi.Add_V("first", false);
            hi.Add_V("second", false);
            hi.Add_V("third", false);
            hi.Add_E(1, 2, 1);
            hi.Add_E(1, 3, 4);
            hi.Add_E(2, 1, 8);
            
            hi.ShowGraph();
            System.Console.WriteLine();
            //hi.Del_E(1, 2);
            hi.Del_V("second");
            //hi.Edit_E(1, 2, 10);
            hi.ShowGraph();
        }


    }



}