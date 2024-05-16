namespace WebApplication7.Validadores;

public class CpfValidador
{
    public static bool IsValid(string cpf)
    {
        cpf = cpf.Replace(".", "").Replace("-", "");

        if (cpf.Length != 11)
            return false;

        bool hasSameDigits = true;
        for (int i = 1; i < cpf.Length; i++)
        {
            if (cpf[i] != cpf[i - 1])
            {
                hasSameDigits = false;
                break;
            }
        }

        if (hasSameDigits)
            return false;

        int sum = 0;
        for (int i = 0; i < 9; i++)
        {
            sum += int.Parse(cpf[i].ToString()) * (10 - i);
        }

        int remainder = sum % 11;
        int firstDigitVerifier = (remainder < 2) ? 0 : 11 - remainder;

        if (int.Parse(cpf[9].ToString()) != firstDigitVerifier)
            return false;

        sum = 0;
        for (int i = 0; i < 10; i++)
        {
            sum += int.Parse(cpf[i].ToString()) * (11 - i);
        }

        remainder = sum % 11;
        int secondDigitVerifier = (remainder < 2) ? 0 : 11 - remainder;

        if (int.Parse(cpf[10].ToString()) != secondDigitVerifier)
            return false;

        return true;
    }
}


