using System;

namespace Lol {

    public class Graph {
        int countOfArsc;
        public int countOfPaths = 0;
        List<List<int>> table = new List<List<int>>();
        List<string> names = new List<string>();
        List<bool> marks = new List<bool>();
        List<string> currentPath = new List<string>();
        List<List<string>> simplePaths = new List<List<string>>();
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

        public int FindSimplePath() {
            for (int i = 0; i < names.Count; ++i) {
                for (int j = 0; j < names.Count; ++j) {
                    if (i == j) continue;
                    simplePaths.Clear();
                    currentPath.Clear();
                    DFS(names[i], names[j]);
                    
                    countOfPaths += getSimplePaths().Count;
                        
                    
                }
            }
            return countOfPaths;
        }

        public List<string> PossiblePaths(string currentVertex) {
            List<string> paths = new List<string>();
            List<int> currentList = table[names.IndexOf(currentVertex)];
            for (int i = 0; i < currentList.Count; ++i) {
                if (currentList[i] > 0) {
                    for (int j = 0; j < table.Count; ++j) {
                        if (table[j][i] < 0) paths.Add(names[j]);
                    }
                }
            }
            return paths;
        }

        public List<List<string>> getSimplePaths() {
            return simplePaths;
        }

        public void DFS(string first, string last) {
            
            
            if (marks[names.IndexOf(first)]) return;
            
            marks[names.IndexOf(first)] = true;
            currentPath.Add(first);
            if (marks[names.IndexOf(first)] == marks[names.IndexOf(last)]) {
                simplePaths.Add(currentPath);
                marks[names.IndexOf(first)] = false;
                currentPath.RemoveAt(currentPath.Count - 1);
                return;
            }
            List<string> possiblePaths = this.PossiblePaths(first);
            foreach (string elem in possiblePaths) {
                DFS(elem, last);
            }
            currentPath.RemoveAt(currentPath.Count - 1);
            marks[names.IndexOf(first)] = false;
        }

        public void ShowGraph() {
            for (int i = 0; i < table.Count; ++i) {
                for (int j = 0; j < table[i].Count; ++j) {
                    Console.Write(Convert.ToString(table[i][j]) + " ");
                }
            
                Console.WriteLine();
            }
        }

    }


}