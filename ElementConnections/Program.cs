namespace ElementConnections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of elements for the network:");
            int numOfElements = Convert.ToInt32(Console.ReadLine());

            Network myNetworkInstance = new Network(numOfElements);

            Console.WriteLine(myNetworkInstance.getNumOfElements());

            myNetworkInstance.connect(1, 2);
            myNetworkInstance.connect(3, 1);
            myNetworkInstance.connect(2, 4);
            myNetworkInstance.connect(5, 6);
            myNetworkInstance.connect(1, 12);

            myNetworkInstance.logConnections();

            myNetworkInstance.disconnect(2, 4);
            Console.WriteLine("2, 4 - WAS DISCONNECTED");

            myNetworkInstance.logConnections();
            Console.WriteLine(myNetworkInstance.query(1, 2));
            Console.WriteLine(myNetworkInstance.query(6, 5));
            Console.WriteLine(myNetworkInstance.query(12, 3));
        }
    }
}