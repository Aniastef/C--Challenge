namespace Tema;

public class Admin
{
    private string nume;
    private List<Application> aplicatii;
    
    public Admin(string nume,List<Application> aplicatii)
    {
        this.nume = nume;
        this.aplicatii = aplicatii;

    }

    public void AddUser(User u, Application app)
    {
       if(app.AdaugaUtilizator(u)==false)
           Console.WriteLine("Nu se poate adauga user-ul in aplicatie");
      else
           Console.WriteLine("User adaugat");
    }

    public void RemoveUser(User u, Application app)
    {
        if (app.StergeUtilizator(u)==false)
            Console.WriteLine("Nu se poate sterge user-ul din aplicatie");
        else
        Console.WriteLine("User sters");
    }

}