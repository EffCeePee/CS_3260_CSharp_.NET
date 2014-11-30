using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace GUI_RegEx_01
{
    class TestRegExp
    {
        /// <summary>
        /// Purpose: Load list with the Regular Expression strings
        /// </summary>
        List<string> listRegExp = new List<string>()
        {
            "[a-zA-Z][a-zA-Z\\s]*",        //Kleen Star (0 or 1)
            "[a-zA-Z][a-zA-Z\\s]+",        //1 or more
            "[a-zA-Z][a-zA-Z\\s]{5}",     //exactly 5
            "[a-zA-Z][a-zA-Z\\s]{1,7}",    //from 1 to 7
            "[a-zA-Z][a-zA-Z\\s]{,9}",     //at least 9
            @"[a-zA-Z][a-zA-Z\s]+$",       //1 or more to the end
            @"^[a-zA-Z][a-zA-Z\s]+",      //1 or more starting at the front
            @"[\w][\W]+",                 //[a-zA-Z_0-9] and [^a-zA-Z_0-9]
            @"[\d][\D]+",                 //[0-9] and [^0-9] 
            @"[\s][\S]+",                 //[ \f\n\r\t\v] and [ \f\n\r\t\v]
            @"[aeiou][^aeiou]+",
            "[a-zA-Z]",
            "abc[a-zA-Z]",
            "[a-zA-Z]*",
            "[a-zA-Z]+",
            "[0-9a-fA-F]",
            @"\A",                       //Specifies that the match must occur at the beginning of the string (ignores the Multiline option).
            @"\z\Z",                     //Specifies that the match must occur at the end of the string or before \n at the end of the string or after \n (ignores the Multiline option).
            @"\g",                       //Specifies that the match must occur at the point where the previous match ended. When used with Match.NextMatch(), this ensures that matches are all contiguous
            @"\b",                       //Specifies that the match must occur on a boundary between \w (alphanumeric) and \W (nonalphanumeric) characters. The match must occur on word boundaries — that is, at the first or last characters in words separated by any nonalphanumeric characters.
            @"\B",                       //Specifies that the match must not occur on a \b boundary.
            @"\b[A-Za-z0-9._%-]+@[A-Za-z0-9.-]+\.(com|org|biz|net|info)\b ",  //email address
            @"*\.txt",                   //text file
            @"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b",   //dates
            @"[-+]?([0-9]*\.[0-9]+)",    //floating point number
            @"(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d",   //integer
            "//.*$",                    //single line comment
            @"/\*.*?\*/",                //multiline comment
            @"[-+]?\b\d+\b",             //positive integer
            @"\b(first|second|third|etc)\b",  //reserved word
            "[a-zA-Z_][a-zA-Z0-9_]*",         //C# identifier
            "0[xX][0-9a-fA-F]+",              //Hexadecimal number
            @"(0|([1-9][0-9]*))?\.[0-9]+",     //floating point number
            @"(([2-9]\d{2})-)?(\d{3})-(\d{4})", //phone number
            @"(([2-9]\d{2})-)?(\d{3})-(\d{4})",  //groups
            @"(?:(?<areaCode>[2-9]\d{2})-)?(?<prefix>\d{3})-(?<lastFour>\d{4})", //named groups
            @"\b(?<word>\w+)\s+(\k<word>)\b, RegexOptions.IgnoreCase",   //grouping
            "(aaa)(bbb)(ccc)",          //replace groups
            "$3$2$1"                    //groups for replace

        };
        /// <summary>
        /// Purpose: Returns the list of Regular Expression strings
        /// </summary>
        /// <returns>Reference to listRegExp</returns>
        public List<string> GetRegExpList()
        {
            return listRegExp;
            string inscope = "";
        }

    }//End TestRegExp
}//End namespace GUI_RegEx_01
