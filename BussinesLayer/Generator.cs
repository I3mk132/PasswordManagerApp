using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    public class clsGenerator
    {
        public bool HasNumbers { get; set; }
        public bool HasSpecialCharacters { get; set; }
        public clsGenerator()
        {
            HasNumbers = true;
            HasSpecialCharacters = true;
        }
        private Random rand = new Random();
        private char _RandomizeCharacter()
        {
            

            // Letters = [ 65 - 91 ] , [ 97 - 123 ]
            // numbers = [ 48 - 58 ]
            // special characters = [ 33 - 48 ], [58 - 65 ], [91 - 97 ], [ 123 - 127 ]


            (int min, int max)[] Letter = new (int, int)[]
            {
                (65, 91),
                (97, 123)
            };
            (int min, int max) number = (48, 58);
            (int min, int max)[] SpecialChar = new (int, int)[]
            {
                (33, 48),
                (58, 65),
                (91, 97),
                (123, 127)
            };

            if (HasNumbers && HasSpecialCharacters)
            {
                (int min, int max)[] chars = Letter.Concat(new[] { number }).Concat(SpecialChar).ToArray();
                (int min, int max) chosenRange = chars[rand.Next(chars.Length)];
                return (char)rand.Next(chosenRange.min, chosenRange.max);
            }
            else if (HasNumbers && !HasSpecialCharacters)
            {
                (int min, int max)[] chars = Letter.Concat(new[] { number }).ToArray();
                (int min, int max) chosenRange = chars[rand.Next(chars.Length)];
                return (char)rand.Next(chosenRange.min, chosenRange.max);
            }
            else if (!HasNumbers && HasSpecialCharacters)
            {
                (int min, int max)[] chars = Letter.Concat(SpecialChar).ToArray();
                (int min, int max) chosenRange = chars[rand.Next(chars.Length)];
                return (char)rand.Next(chosenRange.min, chosenRange.max);
            }
            else
            {
                (int min, int max) chosenRange = Letter[rand.Next(Letter.Length)];
                return (char)rand.Next(chosenRange.min, chosenRange.max);
            }

        }
        public string GeneratePassword(short length)
        {
            string Password = "";
            for (int i = 0; i < length; i++)
            {
                Password += _RandomizeCharacter();
            }
            return Password;
        }
    }
}
