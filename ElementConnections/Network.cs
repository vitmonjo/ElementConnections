using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementConnections
{
    internal class Network
    {
        private int numOfElements;
        List<List<int>> connections = new List<List<int>>();

        public Network(int NumOfElements) 
        {
            if (NumOfElements < 0) throw new ArgumentOutOfRangeException();
            numOfElements = NumOfElements;
        }

        public int getNumOfElements() { return numOfElements; }

        public void logConnections()
        {
            for (int i = connections.Count - 1; i >= 0; i--)
            {
                List<int> row = connections[i];
                int firstNumber = row[0];
                int secondNumber = row[1];

                // Print or process the pair
                Console.WriteLine($"Pair: ({firstNumber}, {secondNumber})");
            }
        }

        public void connect(int num1, int num2)
        {
            if (num1 > numOfElements ||  num2 > numOfElements) throw new ArgumentOutOfRangeException();

            connections.Add(new List<int> { num1, num2 });
        }

        public void disconnect(int numToDisconnect1, int numToDisconnect2)
        {

            for (int i = connections.Count - 1; i >= 0; i--)
            {
                List<int> row = connections[i];
                if ((row[0] == numToDisconnect1 && row[1] == numToDisconnect2) ||
                    (row[1] == numToDisconnect1 && row[0] == numToDisconnect2))
                {
                    connections.RemoveAt(i);
                }
            }
        }

        public bool query(int numToFind1, int numToFind2)
        {
            // Direct Connection
            for (int i = connections.Count - 1; i >= 0; i--)
            {
                List<int> row = connections[i];
                if ((row[0] == numToFind1 && row[1] == numToFind2) ||
                    (row[1] == numToFind1 && row[0] == numToFind2))
                {
                    return true;
                }
            }

            return false;
        }

        public int levelConnection(int numToFind1, int numToFind2)
        {
            // Direct Connection
            for (int i = connections.Count - 1; i >= 0; i--)
            {
                List<int> row = connections[i];
                if ((row[0] == numToFind1 && row[1] == numToFind2) ||
                    (row[1] == numToFind1 && row[0] == numToFind2))
                {
                    return 1;
                }
            }

            return 0;
        }
    }
}
