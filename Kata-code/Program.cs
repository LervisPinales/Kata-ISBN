using System;

namespace Kata_code
{
    class Program
    {
        static bool ValidISBN(string isbn)
        {
            string isbnNum = System.Text.RegularExpressions.Regex.Replace(isbn, "[^ .0-9]", "");

            if (isbnNum.Length != 10)
            {
                return false;
            }

            int Result = 0;

            for (int i = 0; i < isbnNum.Length; i++)
            {
                int numval = -1;
                numval = (int)char.GetNumericValue(isbnNum[i]);

                Result = Result + numval * (10 - i);
            }

            return ((Result % 11) == 0);


        }
        public bool TValid(string isbn)
        {


            string TisbnNum = System.Text.RegularExpressions.Regex.Replace(isbn, "[^ .0-12]", "");

            if (TisbnNum.Length != 13)
            {
                return false;
            }

            int TResult = 0;

            for (int i = 0; i < TisbnNum.Length; i++)
            {
                int Tnumval = -1;
                Tnumval = (int)char.GetNumericValue(TisbnNum[i]);

                TResult = TResult + Tnumval * (13 - i);
            }

            return ((TResult % 14) == 0);

        }

        public static void Main()
        {
            string isbn = "07167003440";

            if (ValidISBN(isbn))
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");

            string iisbnn = "9780716703440";

            //if (TValid(iisbnn))
            

        }
    }
}

