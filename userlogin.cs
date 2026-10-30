// userlogin.cs
// handes user login functionality
public class UserLogin
{
    public string email { get; set; }
    public string password { get; set; }

    public bool login(string email, string password)
    {
        // basic placeholder logic
        return !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password);
    }
}