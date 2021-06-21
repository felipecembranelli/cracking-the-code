using Xunit;
using MyDataStructure.Hash;
using System.Collections.Generic;

namespace datastructure.tests
{
    public class HashDistributionSampleTest
    {
        [Fact]
        public void Test()
        {
            // arrange
            HashDistributionSample hashSample = new HashDistributionSample();

            List<string> products = this.GenerateProductList(100);

            // act
            var result = hashSample.Process(products);

            // assert
            System.Console.WriteLine(result);
        }

            private List<string> GenerateProductList(int numberOfItems) 
            {
                    List<string> products = new List<string>();

                    for (int i = 0; i < numberOfItems; i++)
                    {
                        products.Add("SKU" + i.ToString());
                    }

                    return products;

            }
    }
}
