using Models;
using System.Text.RegularExpressions;

namespace Controllers
{
    public static class Validator
    {
        public static bool IsIdValid(this int Id) =>
            !Id.Equals(null) || !Id.Equals(0);

        public static Response UserValidate(this User user)
        {
            Response response = new Response();

            response.Success = false;
            response.Message = string.Empty;

            Regex regexEmail = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            Regex regexPassword = new Regex("^[0-9]");

            if (string.IsNullOrWhiteSpace(user.Name) || (user.Name.Length < 3 || user.Name.Length > 70))
                response.Message += "Invalid Name\n";

            if (!isCpfValid(user.Cpf))
                response.Message += "Invalid Cpf\n";

            if (string.IsNullOrWhiteSpace(user.Login) || (user.Login.Length < 3 || user.Login.Length > 250))
                response.Message += "Invalid Login\n";

            if (!regexEmail.IsMatch(user.Email))
                response.Message += "Invalid Email\n";

            if (!regexPassword.IsMatch(user.Password) ||  (user.Password.Length < 6 || user.Password.Length > 15))
                response.Message += "Invalid Password, password must be length between 6 and 15";

            if (string.IsNullOrEmpty(response.Message))
                response.Success = true;

            return response;
        }

        private static bool isCpfValid(string cpf)
        {
            int[] multiply1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiply2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digit;
            int sum;
            int rest;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
                return false;

            tempCpf = cpf.Substring(0, 9);
            sum = 0;
            for (int i = 0; i < 9; i++)
                sum += int.Parse(tempCpf[i].ToString()) * multiply1[i];

            rest = sum % 11;
            if (rest < 2)
                rest = 0;
            else
                rest = 11 - rest;

            digit = rest.ToString();

            tempCpf = tempCpf + digit;

            sum = 0;
            for (int i = 0; i < 10; i++)
                sum += int.Parse(tempCpf[i].ToString()) * multiply2[i];

            rest = sum % 11;
            if (rest < 2)
                rest = 0;
            else
                rest = 11 - rest;

            digit = digit + rest.ToString();

            return cpf.EndsWith(digit);
        }
    }
}
