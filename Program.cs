using System;

namespace Lol {

    class Program {

        static void Main() {

            Graph graph = new Graph();
            graph.Add_V("1", false);
            graph.Add_V("2", false);
            graph.Add_V("3", false);
            graph.Add_V("4", false);
            graph.Add_V("5", false);
            graph.Add_V("6", false);
            graph.Add_E(1, 2, 3);
            graph.Add_E(1, 3, 5);
            graph.Add_E(1, 4, 8);
            graph.Add_E(2, 5, 11);
            graph.Add_E(3, 5, 1);
            graph.Add_E(3, 6, 6);
            graph.Add_E(4, 6, 7);
            graph.Add_E(5, 6, 5);
            System.Console.WriteLine(graph.Next("3", 1));
            System.Console.WriteLine(graph.FindSimplePath());
        }


    }



}