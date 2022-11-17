namespace Tema;

public class WebApplication : Application
{
    public WebApplication(string NumeAplicatie, int NumarMaximUtilizatori) : base(NumeAplicatie,NumarMaximUtilizatori)
    {
    }

    public void HttpRequest(User us)
    {
        int ok = 0;
        for (int i = 0; i < this.GetNumberOfUsers(); i++)
        {
            if (us.GetUsername().Equals(u[i].GetUsername())) ;
            ok = 1;
        }
        if (ok==1)
            Console.WriteLine("Ok Request");
        else
            Console.WriteLine("Bad Request");
    }
}