using System;

class NumberConverter
{
    public static string Convert(int number)
    {
        if (number == 0)
            return "zero";
        string word = "";
        if(number/1000000 > 0)
        {
            word += (Convert(number / 1000000)) + " million ";
            number = number % 1000000;
        }
        if(number/1000 > 0)
        {
            word += Convert(number / 1000) +" thousand ";
            number = number % 1000;
        }
        if(number/100 > 0)
        {
            word += Convert(number / 100) +" hundred ";
            number = number % 100;
        }
        if(number > 0)
        {
            string[] units = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "ten", "eleven", "twelve", "thirteen", "fourteen", "fiveteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tenses = new string[] { "zero", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "ninety" };

            if(number<20)
            {
                word += units[number];
            }
            else
            {
                word += tenses[number % 10];
                if (number % 10 > 0)
                    word += " " + units[number % 10];
            }
        }
        return word;
    }
}
        