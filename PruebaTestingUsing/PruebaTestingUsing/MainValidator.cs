﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PruebaTestingUsing
{
    public class MainValidator
    {
        //public bool IsValidEmail(string emailAddress)
        //{

        //    if (string.IsNullOrEmpty(emailAddress))
        //        throw new EmailNotProvidedException();
        //    Regex regex = new Regex(@"^[\w0-9._%+-]+@[\w0-9.-]+\.[\w]{2,6}$");
        //            return regex.IsMatch(emailAddress);
        //}

        //public bool IsValidPassword(string password) { }

        //public string IsSpam(string emailAddress)
        //{
        //    if (string.IsNullOrEmpty(emailAddress)) ;
        //    throw new EmailNotProvidedException() ;
        //    List<string> spammyDomains = new List<string>() { "spam.com", "dodgy.com", "donttrust.com" };

        //    return spammyDomains.Any(d=> emailAddress.Contains(d))? "SPAM":"INBOX";
        //}

        // Este método valida si un número de teléfono es válido
    // Comprueba si el número de teléfono tiene un mínimo de 10 dígitos
    public bool IsValidPhoneNumber(string phoneNumber)
        {
            // Comprueba si el número de teléfono tiene un mínimo de 10 dígitos
            return phoneNumber.Length == 10;
        }
    }
    
}
