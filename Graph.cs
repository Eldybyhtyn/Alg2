using System;

namespace Lol {

    public class Graph {
        int countOfArsc;
        List<List<int>> table = new List<List<int>>();
        List<string> names = new List<string>();
        List<bool> marks = new List<bool>();
        public Graph() {
            countOfArsc = 0;
        }

        public void Add_V(string name, bool newMark) {
            table.Add(new List<int>());
            names.Add(name);
            marks.Add(newMark);
        }

        public void Add_E(int first, int second, int cost) {
            ++countOfArsc;
            table[first - 1].Add(cost);
            table[second - 1].Add(-cost);
            for (int i = 0; i < table.Count; ++i) {
                if (table[i].Count == countOfArsc) continue;
                else table[i].Add(0);
            }
        }

        public void Del_V(string name) {

            int index = names.IndexOf(name);
            for (int i = 0; i < table.Count; ++i) {
                for (int j = 0; j < table[index].Count; ++j) {
                    if (table[index][i] == -table[j][i]) {
                        table[j][i] = 0;
                    }
                }
            }
            table.RemoveAt(index);
            marks.RemoveAt(index);
        }

        public void Del_E(int first, int second) {
            for (int i = 0; i < table.Count; ++i) {
                if (table[first - 1][i] == -table[second - 1][i]) {
                    for (int j = 0; j < table.Count; ++j) {
                        table[j].RemoveAt(i);
                    } 
                    break;
                }
            }
        }

        public void Edit_E(int first, int second, int cost) {
            for (int i = 0; i < table.Count; ++i) {
                if (table[first - 1][i] == -table[second - 1][i]) {
                    table[first - 1][i] = cost;
                    table[second - 1][i] = -cost;
                    break;
                }
            }
        }

        public void Edit_V(string name, bool newMark) {
            int index = names.IndexOf(name);
            marks[index] = newMark;
        }

        public void FindSimplePath() {
            for (int i = 0; i < table.Count; ++i) {
                for (int j = 0; j < table[i].Count; ++j) {
                    //if ()
                }
            }
        }

        // private List<string> DFS(string first, string last) {
            
            

        // }

        public void ShowGraph() {
            for (int i = 0; i < table.Count; ++i) {
                //Console.Write(names[i]);
                for (int j = 0; j < table[i].Count; ++j) {
                    Console.Write(Convert.ToString(table[i][j]) + " ");
                }
            
                Console.WriteLine();
            }
        }

    }


}