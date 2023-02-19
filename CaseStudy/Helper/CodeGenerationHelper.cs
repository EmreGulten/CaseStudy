namespace CaseStudy.Helper
{
    public class CodeGenerationHelper
    {
        //Normalde istenen veri seti bu şekildeydi "ACDEFGHKLMNPRTXYZ234579" ama benim yapıma uyması için bunu toplamda 30 karakter yapıp 3 bolmem gerekiyordu.
        private static string text1 = "AC23DEFG23";
        private static string text2 = "H45KLMNP45";
        private static string text3 = "R79TXYZ79X";

        //Hesaplama yapmak için farklı sayılar veriyorum.
        private static int number1 = 83731;
        private static int number2 = 46691805;

        //Kullanıcılar kampanya dönemi içerisinde çeşitli kanallar üzerinden ellerindeki kodları kullanarak kampanyalara katılabilecektir.
        //Ben burda belli donemleri ay olarak düşündüm her bir ay için farklı kod üretiyorum.
        public static string CreateCode(int count)
        {
            string code = string.Empty;
            string index = ((number1 * count + number2) % 100000000).ToString();

            if (index.Length < 8)
            {
                string tempCode = string.Empty;
                for (int i = 0; i < 8 - index.Length; i++)
                {
                    tempCode += "0";
                }
                tempCode += index;
                index = tempCode;
            }

            for (int i = 0; i < index.Length; i++)
            {
                if (i % 3 == 0)
                {
                    code += text1[Convert.ToInt32(index[i].ToString())];
                }
                if (i % 3 == 1)
                {
                    code += text2[Convert.ToInt32(index[i].ToString())];
                }
                if (i % 3 == 2)
                {
                    code += text3[Convert.ToInt32(index[i].ToString())];
                }
            }

            return code;

        }
    }
}
