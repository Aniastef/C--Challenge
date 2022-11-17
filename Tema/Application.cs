namespace Tema;

public abstract class Application
{
    protected int NumarUtilizatori;
    protected int NumarMaximUtilizatori;
    protected string NumeAplicatie = null;
    protected User[] u;

    
    public Application(string NumeAplicatie, int NumarMaximUtilizatori)
    {
        this.NumeAplicatie = NumeAplicatie;
        this.NumarMaximUtilizatori = NumarMaximUtilizatori;
        this.u = new User[NumarMaximUtilizatori];
    }
    

public bool AdaugaUtilizator(User nou)
    {
        if (NumarUtilizatori == NumarMaximUtilizatori)
            return false;
        else
        {
            u[NumarUtilizatori] = nou;
            NumarUtilizatori++;
            return true;
        }
    }

    public bool StergeUtilizator(User s)
    {
        for (int i = 0; i < NumarUtilizatori; i++)
        {
            if (string.Equals(u[i].GetUsername(), s.GetUsername()))
            {
                for (int j = i; j < NumarUtilizatori - 1; j++)
                    u[j] = u[j + 1];

                u[NumarUtilizatori - 1] = null;
                NumarUtilizatori--;
                return true;
            }
        }
        return false;
    }

    public string GetName()
    {
        return NumeAplicatie;
    }
    
    public int GetNumberOfUsers()
    {
        return NumarUtilizatori;
    }

    public override string ToString()
    {
        return NumeAplicatie + $" {NumarUtilizatori}";
    }

   
    
}