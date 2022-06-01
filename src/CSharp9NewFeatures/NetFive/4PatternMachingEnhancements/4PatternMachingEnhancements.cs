using System;

namespace NetFive._4PatternMachingEnhancements
{
    public class PatternMachingEnhancements
    {
        //Conhunctive 'and' Patterns
        //Disjunctive 'or' Patterns
        //Negated 'not' Patterns
        //Parenthesized Patterns
        //Relational Patterns


        //Before the new operators
        public bool IsLetter(char letter)
        {
            return letter >= 'a' && letter <= 'z' || letter >= 'A' && letter <= 'Z';
        }

        public bool IsLetter2(char letter)
        {
            return (letter >= 'a' && letter <= 'z') || (letter >= 'A' && letter <= 'Z');
        }


        //After the new operators
        public bool IsLetter3(char letter)
        {
            return letter is >= 'a' and <= 'z' or >= 'A' and <= 'Z';
        }

        public bool IsLetter4(char letter)
        {
            return letter is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z');
        }

        //Negated Pattern Example: Nullable Check
        public bool IsLetter4(char? letter)
        {
            if(letter is not null)
                return letter is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z');
            return false;
        }

        /* Relational Pattern Example | !The right-hand part of a relational pattern must be a constant expression.
          The constant expression can be of an integer, floating-point, char, or enum type. */
        public string Classify(double measurement)
        {
            return measurement switch
            {
                < -4.0 => "Too low",
                > 10.0 => "Too high",
                double.NaN => "Unknown",
                _ => "Acceptable",
            };
        }

        //Relational Pattern && 'and', 'or' Example
        public string GetCalendarSeason(DateTime date) => date.Month switch
        {
            >= 3 and < 6 => "spring",
            >= 6 and < 9 => "summer",
            >= 9 and < 12 => "autumn",
            12 or (>= 1 and < 3) => "winter",
            _ => throw new ArgumentOutOfRangeException(nameof(date), $"Date with unexpected month: {date.Month}."),
        };
    }
}
