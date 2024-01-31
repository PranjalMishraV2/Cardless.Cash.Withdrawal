using Cardless.Cash.Withdrawal.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Cardless.Cash.Withdrawal.Controllers
{
    public class CardlessController:Controller
    {
        //private readonly ILogger<CardlessController> _logger;

        //public CardlessController(ILogger<CardlessController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            return View();
        }

        public string GetEmployeeName(int empId)
        {
            string name;
            if (empId == 1)
            {
                name = "Jignesh";
            }
            else if (empId == 2)
            {
                name = "Rakesh";
            }
            else
            {
                name = "Not Found";
            }
            return name;
        }

        public bool ValidateLoginCred(string payIDType, string payID)
        {
            //Assuming data is Feched from some db and verified ,here we are returing true if both fields are non empty.
            return !string.IsNullOrEmpty(payIDType) && !string.IsNullOrEmpty(payID);
        }

        public bool ValidateLoginEmailID(string payIDType, string emailID) 
        {
            bool result ;
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                                   //"^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$"
            if (!string.IsNullOrEmpty(payIDType) && !string.IsNullOrEmpty(emailID))
            {
                result = Regex.IsMatch(emailID, emailPattern);
            }
            else
            {       
                result = false;            
            }
            return result;
        }
    }
}
