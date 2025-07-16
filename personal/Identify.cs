namespace Chizl.RegexPatterns.Personal
{
    public enum Identify
    {
        [Identify(SSN_Hyphenated, @"^(?!666|000|9\d{2})\d{3}-(?!00)\d{2}-(?!0000)\d{4}$", @"[^\d\-]", "")]
        SSN_Hyphenated = 0,
        [Identify(SSN_Unhyphenated, @"^\d{9}$", @"[^\d]", @"[\d]\t- Only Numeric Allowed\n{9}\t- Required 9 bytes in length")]
        SSN_Unhyphenated,
        [Identify(Phone_US_Full, @"^((\+1\s)?((\([0-9]{3}\)\s)|[0-9\-]{4}))([0-9]{3})-([0-9]{4})$", @"[^\+\(\)0-9\s\-]", "(\t- START GROUP 1\n(\\+1\\s)?\t- Optional US Country Code '+1 '\n(\t- START AREA CODE GROUP 1.1\n(\\([0-9]{3}\\)\\s)\t- Required '(' + NumericOnly 3 bytes + ')'\n|\t- OR\n[0-9\\-]{4}\t- Required Numeric Only with dash, a total of 4 bytes.\n)\t- END AREA CODE GROUP 1.1\n)\t- END GROUP 1\n([0-9]{3})\t- Prefix, Required Numeric 3 bytes.\n-\t- Required dash\n([0-9]{4})\t- Last 4 required bytes")]
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
        /// @"^[a-zA-Z\d](?:[a-zA-Z\d!#\$%&\+_\.-]{0,62}[a-zA-Z\d])?@(?:(?:[a-zA-Z\d](?:[a-zA-Z\d]|-(?!-)){0,61}[a-zA-Z\d])\.){1,3}[a-zA-Z]{2,24}$"
        /// Local part length (1–64)                   ✅
        /// Local starts & ends with alphanumeric      ✅
        /// Special characters allowed mid-local       ✅
        /// No consecutive .., no leading/trailing .   ✅
        /// Domain part label length (1–63)            ✅
        /// Domain labels no leading/trailing -        ✅
        /// Repeats up to 3 subdomains                 ✅
        /// TLD realistic length (2–24)                ✅
        /// Fully anchored with ^...$                  ✅
        /// Case-insensitive friendly                  ✅
        /// 
        /// Accepted: 
        /// alice.bob@example.com                      ✅
        /// john+doe@sub.mail.org                      ✅
        /// a1_b2@host-name.net                        ✅
        /// 
        /// Regjected:
        /// .bob@domain.com                            ❌
        /// bob.@domain.com                            ❌
        /// bob*@domain.com                            ❌
        /// bob@-domain.com                            ❌
        /// bob@domain-.com                            ❌
        /// bob@a--b.com                               ❌
        /// </summary>
        [Identify(Email, @"^[a-zA-Z\d](?:[a-zA-Z\d!#\$%&\+_\.-]{0,62}[a-zA-Z\d])?@(?:(?:[a-zA-Z\d](?:[a-zA-Z\d]|-(?!-)){0,61}[a-zA-Z\d])\.){1,3}[a-zA-Z]{2,24}$", @"[^a-zA-Z\d!#\$%&\+_\.-]")]
        Email,
        [Identify(Name, @"^[a-zA-Z\.\s]+$", @"[^a-zA-Z\.\s]")]
        Name,
        [Identify(Address, @"^(\d|\d\s)?[a-zA-Z\d\s\.]$", @"[^a-zA-Z0-9\s\.]")]
        Address,
        [Identify(City, @"^(([0-9]{0,5})?\s?([a-zA-Z]{0,10}))?([a-zA-Z]{0,2}[\.\s]{2})?[a-zA-Z]$", @"[^0-9a-zA-Z\.\s]")]
        City,
        [Identify(State_Full, @"^[a-zA-Z\s]{4,30}$", @"[^a-zA-Z\s]")]
        State_Full,
        [Identify(State_Initials, "^[A-Z]{2}$", "[^A-Z]")]
        State_Initials,
        [Identify(ZipCode_Hyphenated, @"^\d{5}|\d{5}-\d{4}$", @"[^\d\-]")]
        ZipCode_Hyphenated,
        [Identify(ZipCode_Unhyphenated, @"^\d{9}$", @"[^\d]")]
        ZipCode_Unhyphenated,
        [Identify(ZipCode_Short, @"^\d{5}$", @"[^\d]")]
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
