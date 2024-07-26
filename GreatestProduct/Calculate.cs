namespace Calculate
{
    class Calculateclass
    {
        public static int calculate(string inputString)
        {
            int product = 1;
            foreach (char character in inputString)
            {
                //int digit = c - '0';
                //product*=digit;
                product *= (int)Char.GetNumericValue(character);

            }
            return product;
        }
    }

}