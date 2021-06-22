using System.Collections.Generic;

namespace MyDataStructure.Hash
{
    public class HashDistributionSample
    {
        private const int numberOfQueues = 3;
        List<string> queue1, queue2, queue3;

        // Distribute a list of products evenly (as much as possible) among 3 queues using a hash function
        public string Process(List<string> productIds, bool defaultHashFunction)
        {
            queue1 = new List<string>();
            queue2 = new List<string>();
            queue3 = new List<string>();

            foreach (var item in productIds)
            {
                int hash;
                
                if (defaultHashFunction) hash = this.DefaultHashFunction(item);
                else hash = this.HashFunction(item);

                int queueId = hash % numberOfQueues;
                
                switch (queueId)
                {
                    case 0:
                        queue1.Add(item);
                        break;
                    case 1:
                        queue2.Add(item);
                        break;
                    case 2:
                        queue3.Add(item);
                        break;          
                    default:
                        throw new System.Exception("No queue defined");
                }
            }

            return string.Format("{0}, {1}, {2}", 
                        queue1.Count.ToString(),
                        queue2.Count.ToString(),
                        queue3.Count.ToString());
        }

        // Sample implementation of hash function
        private int HashFunction(object key)
        {
            int index = 7;
            int asciiVal = 0;

            for (int i = 0; i < key.ToString().Length; i++)
            {
                asciiVal = (int)key.ToString()[i] * i;
                index = index * 31 + asciiVal;
            }
            return index;
        }

        // Return a number generated by default dotnet hash fuction
        // Note: GetHashCode() is not guaranteed to be unique and can change between builds.
        // https://andrewlock.net/why-is-string-gethashcode-different-each-time-i-run-my-program-in-net-core/
        private int DefaultHashFunction(object key)
        {
            var hash = (int)(key.ToString().GetHashCode());

            if (hash < 0) return hash * -1;
            else return hash;
        }
        
    }
    
}