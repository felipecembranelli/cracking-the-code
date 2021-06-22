using Xunit;
using MyDataStructure.Matrix;
using System.Collections.Generic;

namespace datastructure.tests
{
    public class MatrixTest
    {
        [Fact]
        public void Create_Matrix_Should_Return_Elements()
        {
            // arrange
            const int SIZE = 2;

            int[] values = {1,2,3,4};
            // act
            var arr = Matrix.CreateMatrix(SIZE, values);

            // assert
            Assert.Equal(3, arr.GetUpperBound(1));
            Assert.Equal(3, arr.GetUpperBound(2));
        }
    }
}

