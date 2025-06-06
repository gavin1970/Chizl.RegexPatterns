//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Chizl.RegexPatterns.Personal
//{
//    public enum Identify
//    {
//        [Identify(SSN, "^[0-9]{3}-[0-9]{2}-[0-9]{4}$", "^[0-9]{3}[0-9]{2}[0-9]{4}$")]
//        SSN = 0,
//        [Identify(Phone, @"^(?:\+1[-. ]?)?\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", @"^\+?[0-9\s-()]{7,20}$")]
//        Phone,
//        [Identify(Email, @"^[a-zA-Z0-9]+([._%+-][a-zA-Z0-9]+)*@[a-zA-Z0-9-]+(\.[a-zA-Z0-9-]+)*\.[a-zA-Z]{2,63}$", "")]
//        Email,
//        [Identify(Name, @"^[a-zA-Z ]$", "")]
//        Name,
//        [Identify(Address, @"^[0-9 ]?[a-zA-Z0-9 \.]$", "")]
//        Address,
//        [Identify(City, @"^([0-9] )?[a-zA-Z0-9 \.]$", @"^([a-zA-Z] |[0-9]|[0-9] )?[a-zA-Z](\. )?[a-zA-Z]$")]
//        City,
//        [Identify(State, @"^[A-Z]{2}|[a-zA-Z ]{4,30}$", "")]
//        State,
//        [Identify(ZipCode, @"^[0-9]{5}|[0-9]{5}-[0-9]{4}$", "^[0-9]{9}$")]
//        ZipCode,
//    }
//    //@"^[a-zA-Z]([\.?] )?[a-zA-Z0-9]$" or would it be @"^[a-zA-Z](\. )?[a-zA-Z0-9]$"
//}

///*
//City: @"^(([0-9]{0,5})? ?([a-zA-Z]{0,10}))?([a-zA-Z]{0,2}[\. ]{2})?[a-zA-Z]$"
//e.g. 29 Palms, St. Vincent, Saint Vincent, Jacksonville
//*/
