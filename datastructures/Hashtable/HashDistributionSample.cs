using System.Collections.Generic;

namespace MyDataStructure.Hash
{
    public class HashDistributionSample
    {
        private const int numberOfQueues = 3;
        List<string> queue1, queue2, queue3;

        public string Process(List<string> productIds)
        {
            List<int> distribCount = new List<int>();

            queue1 = new List<string>();
            queue2 = new List<string>();
            queue3 = new List<string>();

            foreach (var item in productIds)
            {
                int hash = this.HashFunction(item);

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
                }
            }

            return string.Format("queue1:{0}, queue2{1}, queue3{2}", 
                        queue1.Count.ToString(),
                        queue2.Count.ToString(),
                        queue3.Count.ToString());
        }

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
        
    }
    
}