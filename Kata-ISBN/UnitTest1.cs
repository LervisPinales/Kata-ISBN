using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata_ISBN
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public bool TestISBN_10D_Valid(string isbn)
        {
            bool validation_Re = false;
            string iisbn = "07167003440";

            string isbnNum = System.Text.RegularExpressions.Regex.Replace(iisbn, "[^ .0-9]", "");

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
            Assert.IsFalse(validation_Re);

        }

        public bool TestISBN_13D_Valid(string isbn)
        {
            bool validation_Re = false;
            string iisbnn = "9780716703440";

            string TisbnNum = System.Text.RegularExpressions.Regex.Replace(iisbnn, "[^ .0-12]", "");

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
            Assert.IsFalse(validation_Re);
        }
    }
}
