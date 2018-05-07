using System;
using Microsoft.AspNetCore.Mvc;
using MathWizard.Models;

using static MathWizard.Models.RoundOp;

namespace MathWizard.Controllers
{
    public class MathController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Wizard()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DoCalculation([FromForm] MathOperation mathOperation)
        {


            if(ModelState.IsValid){
            }
            else{
                
            }

            if(mathOperation == null)
            {
                return View("Error");
            }
            else
            {
                switch(mathOperation.Operator){
                    case "Add":
                        mathOperation.Result = 
                        mathOperation.Left + mathOperation.Right;
                        break;
                    
                    case "Subtract":
                        mathOperation.Result = 
                        mathOperation.Left - mathOperation.Right;                
                        break;

                    case "Multiply":
                        mathOperation.Result = 
                        mathOperation.Left * mathOperation.Right;                
                        break;
                    
                    case "Divide":
                        mathOperation.Result = 
                        mathOperation.Left / mathOperation.Right;                
                        break;

                    case "Modulus":
                        mathOperation.Result = 
                        mathOperation.Left % mathOperation.Right;                
                        break;

                    default:
                        MathOperation op = new MathOperation();
                        op.Left = mathOperation.Left;
                        op.Left = mathOperation.Right;
                        op.Operator = mathOperation.Operator;
                        op.Result = 0;
                        return View(op);
                        //break;
                        
                    
                }
            }
            return View(mathOperation);
        }

        public IActionResult AnotherWizard()
        {
            return View();
        }

        public IActionResult DoMathOp(MathOp mathOp)
        {
            if(ModelState.IsValid){

                switch(mathOp.Operator){
                    case "Plus":
                        mathOp.Result = 
                        mathOp.Left + mathOp.Right;
                        break;
                    
                    case "Minus":
                        mathOp.Result = 
                        mathOp.Left - mathOp.Right;                
                        break;

                    case "Times":
                        mathOp.Result = 
                        mathOp.Left * mathOp.Right;                
                        break;
                    
                    case "DivBy":
                        if(mathOp.Right == 0)
                        {
                            return View("Error");
                        }                    
                        mathOp.Result = 
                        mathOp.Left / mathOp.Right;                
                        break;

                    case "Modulus":
                        mathOp.Result = 
                        mathOp.Left % mathOp.Right;                
                        break;

                        

                    default:
                        MathOp op = new MathOp();
                        op.Left = mathOp.Left;
                        op.Right = mathOp.Right;
                        op.Operator = mathOp.Operator;
                        op.Result = -999;
                        return View(op);
                        //break;
                        
                }                
            }
            else
            {
                return View("Error");
            }

            return View(mathOp);
        }
    }
}