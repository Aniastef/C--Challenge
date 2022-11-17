namespace Tema;

public class User
{
    private string username = null;
    private string password = null;
    private string email = null;

    public User(string username, string password, string email)
    {
        this.username = username;
        this.password = password;
        this.email = email;
    }

    public string GetUsername()
    {
        return username;
    }
    
    public string GetMail()
    {
        return email;
    }

    public void ChangePassword(string newPassword)
    {
        password = newPassword;
    }

    public string GetPassword()
    {
        return password;
    }

    public override string ToString()
    {
        return username + " " + email;
    }
}