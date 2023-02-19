using System.Runtime.InteropServices;

namespace CaseStudy.Helper
{
    public class CodeVerificationHelper
    {
        private static string text1 = "AC23DEFG23";
        private static string text2 = "H45KLMNP45";
        private static string text3 = "R79TXYZ79X";
       
        public static bool VerifyCode(string code)
        {
            if (code.Length != 8) return false;
            for (int i = 0; i < code.Length; i++)
            {
                if (i % 3 == 0 && !text1.Contains(code[i])) 
                    return false;
                else if (i % 3 == 1 && !text2.Contains(code[i])) 
                    return false;
                else if (i % 3 == 2 && !text3.Contains(code[i])) 
                    return false;
            }
            return true;
        }

    }
}
