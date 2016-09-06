﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Calculator
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Add()
        {
            Assert.AreEqual(0, Calculator.Add(0, 0));
            Assert.AreEqual(4, Calculator.Add(2, 2));
            Assert.AreEqual(8, Calculator.Add(2, 6));
        }
        [TestMethod]
        public void Subtract()
        {
            Assert.AreEqual(6, Calculator.Subtract(10, 4));
        }
        [TestMethod]
        public void Sum()
        {
            //Arrange
            int[] numbers = new int[2];
            Assert.AreEqual(0, Calculator.Sum(numbers));

            numbers[0] = 7;
            Assert.AreEqual(7, Calculator.Sum(numbers));

            numbers[0] = 7;
            numbers[1] = 11;
            Assert.AreEqual(18, Calculator.Sum(numbers));

        }
        [TestMethod]
        public void Multiply()
        {
            //Arrange
            int[] numbers = new int[3];
            Assert.AreEqual(0, Calculator.Multiply(numbers));

            numbers[0] = 7;
            numbers[1] = 1;
            numbers[2] = 1;
            Assert.AreEqual(7, Calculator.Multiply(numbers));

            numbers[0] = 7;
            numbers[1] = 11;
            numbers[2] = 1;
            Assert.AreEqual(77, Calculator.Multiply(numbers));

            numbers[0] = 7;
            numbers[1] = 11;
            numbers[2] = 18;
            Assert.AreEqual(1386, Calculator.Multiply(numbers));
        }
        [TestMethod]
        public void Power()
        {
            int[] numbers = new int[2];
          
            numbers[0] = 7;
            numbers[1] = 2;
            Assert.AreEqual(49, Calculator.Power(numbers));

            numbers[0] = 7;
            numbers[1] = 3;
            Assert.AreEqual(343, Calculator.Power(numbers));
        }
        [TestMethod]
        public void Factorial()
        {
            Assert.AreEqual(1, Calculator.Factorial(0));
            Assert.AreEqual(120, Calculator.Factorial(5));
            Assert.AreEqual(3628800, Calculator.Factorial(10));
        }
    }
}
