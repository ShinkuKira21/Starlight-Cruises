using Microsoft.AspNetCore.Mvc;

namespace Server.Settings;

public static class AdminSettings
{
    private const string adminUsername = "root";
    private const string adminPassword = "A762)A(aLo:D";
    private const string adminCode = "A@#sO|";

    public static bool CheckConfirmationCode(string code)
    {
        string compilation = adminCode + adminUsername + adminPassword;

        if (code.Equals(compilation)) return true;
        return false;
    }
}