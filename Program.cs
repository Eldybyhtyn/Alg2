using System;

namespace Lol {

    class Program {

        static void Main() {

            Graph hi = new Graph();
            hi.Add_V("1", false);
            hi.Add_V("2", false);
            hi.Add_V("3", false);
            hi.Add_V("4", false);
            hi.Add_V("5", false);
            hi.Add_E(1, 3, 1);
            hi.Add_E(3, 4, 1);
            hi.Add_E(1, 2, 1);
            hi.Add_E(2, 4, 1);
            hi.Add_E(1, 5, 1);
            hi.Add_E(5, 4, 1);
            //hi.ShowGraph();
            // hi.DFS("1", "3");
            // System.Console.WriteLine(hi.getSimplePaths().Count);
            System.Console.WriteLine(hi.FindSimplePath());
        }


    }



}