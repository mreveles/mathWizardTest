using System;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using MathWizard.Controllers;
using MathWizard.Models;

namespace MathWizardTests
{
    public class MathWizardTests
    {

        private MathController controller = new MathController();

        [Fact]
        public void TestAddition()
        {
            //Arrange
            MathOp op = new MathOp();
            op.LeftOperand = 10;
            op.RightOperand = 5;
            op.Operator = "Plus";
            op.Result = 0;
            
            //Act
            ViewResult vr = (ViewResult)controller.DoMathOp(op);
            MathOp model = (MathOp)vr.Model;

            //Assert
            Assert.Equal(15, model.Result);

        }

        [Fact]
        public void TestDivision()
        {
            //Arrange
            MathOp op = new MathOp();
            op.LeftOperand = 10;
            op.RightOperand = 5;
            op.Operator = "Divided By";
            op.Result = 0;
            
            //Act
            ViewResult vr = (ViewResult)controller.DoMathOp(op);
            MathOp model = (MathOp)vr.Model;

            //Assert
            Assert.Equal(2, Math.Round(model.Result, 1));

        }

        [Fact]
        public void TestSubtracktion(){
            //A
            MathOp op = new MathOp();
            op.LeftOperand = 10;
            op.RightOperand = 5;
            op.Operator = "Minus";
            op.Result = 0;

            //A
            ViewResult vr = (ViewResult)controller.DoMathOp(op);
            MathOp model = (MathOp)vr.Model;
            //A
            Assert.Equal(5, model.Result);

        }

        [Fact]
        public void TestMultiply(){
            //A
            MathOp op = new MathOp();
            op.LeftOperand = 10;
            op.RightOperand = 5;
            op.Operator = "Times";
            op.Result = 0;

            //A
            ViewResult vr = (ViewResult)controller.DoMathOp(op);
            MathOp model = (MathOp)vr.Model;
            //A
            Assert.Equal(50, model.Result);

        }

        [Fact]
        public void TestModulus(){
            //A
            MathOp op = new MathOp();
            op.LeftOperand = 10;
            op.RightOperand = 5;
            op.Operator = "Modulus";
            op.Result = 0;

            //A
            ViewResult vr = (ViewResult)controller.DoMathOp(op);
            MathOp model = (MathOp)vr.Model;
            //A
            Assert.Equal(0, model.Result);

        }



    }
}
