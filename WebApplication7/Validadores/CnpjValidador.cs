namespace WebApplication7.Validadores;

public class CnpjValidador
{
    public static bool IsValid(string cnpj)
    {
        cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

        if (cnpj.Length != 14)
            return false;

        bool hasSameDigits = true;
        for (int i = 1; i < cnpj.Length; i++)
        {
            if (cnpj[i] != cnpj[i - 1])
            {
                hasSameDigits = false;
                break;
            }
        }

        if (hasSameDigits)
            return false;

        int[] multiplier1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
        int sum = 0;
        for (int i = 0; i < 12; i++)
        {
            sum += int.Parse(cnpj[i].ToString()) * multiplier1[i];
        }

        int remainder = sum % 11;
        int firstDigitVerifier = (remainder < 2) ? 0 : 11 - remainder;

        if (int.Parse(cnpj[12].ToString()) != firstDigitVerifier)
            return false;

        int[] multiplier2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
        sum = 0;
        for (int i = 0; i < 13; i++)
        {
            sum += int.Parse(cnpj[i].ToString()) * multiplier2[i];
        }

        remainder = sum % 11;
        int secondDigitVerifier = (remainder < 2) ? 0 : 11 - remainder;

        if (int.Parse(cnpj[13].ToString()) != secondDigitVerifier)
            return false;

        return true;
    }
}