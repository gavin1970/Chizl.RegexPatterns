namespace Chizl.RegexPatterns.Personal
{
    public enum Identify
    {
        [Identify(SSN_Hyphenated, @"^(?!666|000|9\d{2})\d{3}-(?!00)\d{2}-(?!0000)\d{4}$", "[^0-9-]", "")]
        SSN_Hyphenated = 0,
        [Identify(SSN_Unhyphenated, "^[0-9]{9}$", "[^0-9]", "[0-9]\t- Only Numeric Allowed\n{9}\t- Required 9 bytes in length")]
        SSN_Unhyphenated,
        [Identify(Phone_US_Full, @"^((\+1\s)?((\([0-9]{3}\)\s)|[0-9\-]{4}))([0-9]{3})-([0-9]{4})$", @"[^\+\(\)0-9 \-]", "(\t- START GROUP 1\n(\\+1\\s)?\t- Optional US Country Code '+1 '\n(\t- START AREA CODE GROUP 1.1\n(\\([0-9]{3}\\)\\s)\t- Required '(' + NumericOnly 3 bytes + ')'\n|\t- OR\n[0-9\\-]{4}\t- Required Numeric Only with dash, a total of 4 bytes.\n)\t- END AREA CODE GROUP 1.1\n)\t- END GROUP 1\n([0-9]{3})\t- Prefix, Required Numeric 3 bytes.\n-\t- Required dash\n([0-9]{4})\t- Last 4 required bytes")]
        Phone_US_Full,
        [Identify(Phone_US_Mid, @"^((\([0-9]{3}\)\s)?|[0-9\-]{4})([0-9]{3}\-[0-9]{4})$", @"[^0-9\s-()]")]
        Phone_US_Mid,
        [Identify(Phone_US_Base, @"^\d{3}-\d{4}$", @"[^0-9-]")]
        Phone_US_Base,
        /// <summary>
        /// Comprehensive Email Address Validation Using Regex in C#
        /// Introduction
        /// Email address validation is a crucial aspect of many applications, ensuring that users provide valid email formats before proceeding with registration or communication. In this article, we will explore a robust Regular Expression (Regex) pattern designed for validating email addresses in C#. This Regex pattern is not only efficient but also adheres to common email formatting standards.
        /// 
        /// Key Concepts
        /// Before diving into the code, it is essential to understand the components of the Regex pattern provided. The pattern is structured to match valid email addresses while excluding invalid formats. Here are the key concepts involved:
        /// 
        /// Character Classes: The pattern uses character classes to define valid characters for the local part (before the '@') and the domain part (after the '@') of the email address.
        /// Quantifiers: These are used to specify the number of times a character or group of characters can occur.
        /// Assertions: The pattern employs negative lookaheads to ensure that certain invalid formats are not matched.
        /// Domain Validation: The pattern checks for valid domain names and ensures that the top-level domain (TLD) is of an appropriate length.
        /// Code Structure
        /// The Regex pattern is structured as follows:
        /// 
        /// language-regex
        /// [a-zA-Z0-9]+([._%+-][a-zA-Z0-9]+)*@[a-zA-Z0-9-]+(\.[a-zA-Z0-9-]+)*\.[a-zA-Z]{2,63}
        /// 
        /// Breakdown of the Pattern:
        /// [a-zA-Z0-9]+            : Matches one or more alphanumeric characters at the beginning of the email.
        /// ([._%+-][a-zA-Z0-9]+)*  : Allows for optional sequences of special characters followed by alphanumeric characters.
        /// @                       : The mandatory '@' symbol separating the local part from the domain.
        /// [a-zA-Z0-9-]+           : Matches the domain name, which can include alphanumeric characters and hyphens.
        /// (\.[a-zA-Z0-9-]+)*      : Allows for subdomains, which can be separated by periods.
        /// \.[a-zA-Z]{2,63}        : Ensures that the email ends with a valid top-level domain, which can be between 2 to 63 characters long.
        /// 
        /// Example emails pattern:
        /// "example@example.com", "user.name+tag+sorting@example.com", "user@subdomain.example.com", "invalid-email@.com", "invalid-email@domain..com", "@missingusername.com"
        /// </summary>
        [Identify(Email, @"^[a-zA-Z0-9]+([\._\%\+\-][a-zA-Z0-9]+)*@[a-zA-Z0-9-]+(\.[a-zA-Z0-9-]+)*\.[a-zA-Z]{2,63}$", @"[^a-zA-Z0-9@\._\%\+\-]")]
        Email,
        [Identify(Name, @"^[a-zA-Z\.\s]+$", @"[^a-zA-Z\.\s]")]
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
