namespace Chizl.RegexPatterns.Personal
{
    public enum Identify
    {
        [Identify(SSN_Hyphenated, @"^(?!666|000|9\d{2})\d{3}-(?!00)\d{2}-(?!0000)\d{4}$", "[^0-9-$]", "")]
        SSN_Hyphenated = 0,
        [Identify(SSN_Unhyphenated, "^[0-9]{9}$", "[^0-9$]", "[0-9]\t- Only Numeric Allowed\n{9}\t- Required 9 bytes in length")]
        SSN_Unhyphenated,
        [Identify(Phone_US_Full, @"^((\+1\s)?((\([0-9]{3}\)\s)|[0-9\-]{4}))([0-9]{3})-([0-9]{4})$", @"[^\+\(\)0-9 \-$]", "(\t- START GROUP 1\n(\\+1\\s)?\t- Optional US Country Code '+1 '\n(\t- START AREA CODE GROUP 1.1\n(\\([0-9]{3}\\)\\s)\t- Required '(' + NumericOnly 3 bytes + ')'\n|\t- OR\n[0-9\\-]{4}\t- Required Numeric Only with dash, a total of 4 bytes.\n)\t- END AREA CODE GROUP 1.1\n)\t- END GROUP 1\n([0-9]{3})\t- Prefix, Required Numeric 3 bytes.\n-\t- Required dash\n([0-9]{4})\t- Last 4 required bytes")]
        Phone_US_Full,
        [Identify(Phone_US_Mid, @"^((\([0-9]{3}\)\s)?|[0-9\-]{4})([0-9]{3}\-[0-9]{4})$", @"[^0-9\s-()$]")]
        Phone_US_Mid,
        [Identify(Phone_US_Base, @"^\d{3}-\d{4}$", @"[^0-9-$]")]
        Phone_US_Base,
        [Identify(Email, @"^[a-zA-Z0-9]+([._%+-][a-zA-Z0-9]+)*@[a-zA-Z0-9-]+(\.[a-zA-Z0-9-]+)*\.[a-zA-Z]{2,63}$", @"[^a-zA-Z0-9@\+_\.-$]")]
        Email,
        [Identify(Name, @"^[a-zA-Z\. ]$", @"[^a-zA-Z\. $]")]
        Name,
        [Identify(Address, @"^[0-9 ]?[a-zA-Z0-9 \.]$", @"[^a-zA-Z0-9 \.$]")]
        Address,
        [Identify(City, @"^(([0-9]{0,5})? ?([a-zA-Z]{0,10}))?([a-zA-Z]{0,2}[\. ]{2})?[a-zA-Z]$", @"[^0-9a-zA-Z\. $]")]
        City,
        [Identify(State_Full, "^[a-zA-Z ]{4,30}$", "[^a-zA-Z $]")]
        State_Full,
        [Identify(State_Initials, "^[A-Z]{2}$", "[^A-Z$]")]
        State_Initials,
        [Identify(ZipCode_Hyphenated, @"^\d{5}|\d{5}-\d{4}$", "[^0-9-$]")]
        ZipCode_Hyphenated,
        [Identify(ZipCode_Unhyphenated, @"^\d{9}$", "[^0-9$]")]
        ZipCode_Unhyphenated,
        [Identify(ZipCode_Short, @"^\d{5}$", "[^0-9$]")]
        ZipCode_Short,
    }
}

/*
Phone:
^((\+1\s)?(\(?[0-9]{3}\)\s?|[0-9-]{4}))([0-9]{3})-([0-9]{4})$
^(?:\+1[-. ]?)?\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$

City: @"^(([0-9]{0,5})? ?([a-zA-Z]{0,10}))?([a-zA-Z]{0,2}[\. ]{2})?[a-zA-Z]$"
e.g. 29 Palms, St. Vincent, Saint Vincent, Jacksonville

@"^[a-zA-Z]([\.?] )?[a-zA-Z0-9]$" or would it be @"^[a-zA-Z](\. )?[a-zA-Z0-9]$"
*/
