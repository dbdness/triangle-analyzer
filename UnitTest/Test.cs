using System;
using Xunit;

namespace UnitTest
{
    public class TestClass
    {

        //This Fact test will pass - Equal will be true.
        //All three sides are equal, therefore the triangle is equilateral.
        [Fact]
        public void EquilateralPass(){
            Assert.Equal("Equilateral", Triangle.GetType(3, 3, 3));
        }

        //This test will fail - Equal will not be true. 
        //All three sides are not equal in any case, therefore the triangle is not equilateral.
        [Theory]
        [InlineData(3,3,4)]
        [InlineData(2,3,4)]
        [InlineData(3,4,3)]
        public void EquilateralFail(int side1, int side2, int side3){
            Assert.NotEqual("Equilateral", Triangle.GetType(side1, side2, side3));

        }

        //This Fact test will pass - Equal will be true.
        //Two of the sides are equal, therefore the triangle is isosceles.
        [Fact]
        public void IsoscelesPass(){
            Assert.Equal("Isosceles", Triangle.GetType(3, 3, 2));
            Assert.Equal("Isosceles", Triangle.GetType(3, 3, 2));
            Assert.Equal("Isosceles", Triangle.GetType(3, 3, 2));

        }

        //This test will fail - Equal will not be true. 
        //All three sides either equal or not equal in any case, therefore the triangle is not isosceles.
        [Theory]
        [InlineData(3, 3, 3)]
        [InlineData(3, 2, 1)]
        [InlineData(1, 2, 3)]
        public void IsoscelesFail(int side1, int side2, int side3){
            Assert.NotEqual("Isosceles", Triangle.GetType(side1, side2, side3));
        }

        //This Fact test will pass - Equal will be true.
        //None of the sides are equal, therefore the triangle is scalene.
        [Fact]
        public void ScalenePass(){
            Assert.Equal("Scalene", Triangle.GetType(1, 2, 3));
            Assert.Equal("Scalene", Triangle.GetType(3, 2, 1));
            Assert.Equal("Scalene", Triangle.GetType(5, 4, 3));

        }

        //This test will fail - Equal will not be true. 
        //Some or all of the sides are equal, therefore the triangle is not scalene.
        [Theory]
        [InlineData(3, 3, 3)]
        [InlineData(3, 2, 3)]
        [InlineData(1, 2, 1)]
        public void ScaleneFail(int side1, int side2, int side3){
            Assert.NotEqual("Scalene", Triangle.GetType(side1, side2, side3));
        }

    }
    
    public class Triangle{
        public static String GetType(int side1, int side2, int side3){
        String type = "Couldn't calculate type."; //If none of the below criteria are met (for some reason), returns error.
        if(side1 == side2 && side1 == side3 && side2 == side3){
            type = "Equilateral";
            return type;
        }
        if(side1 == side2 || side1 == side3 || side2 == side3){
            type = "Isosceles";
            return type;
        }
        if(side1 != side2 && side1 != side3){
            type = "Scalene";
            return type;
        }
        return type;
    }
    }
}


