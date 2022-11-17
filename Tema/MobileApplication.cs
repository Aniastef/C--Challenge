namespace Tema;

 public class MobileApplication : Application
 {
     private double rating;

     public MobileApplication(string NumeAplicatie, int NumarMaximUtilizatori) : base(NumeAplicatie,NumarMaximUtilizatori)
     {
     }

     public double RateApp()
    {
        double nota = 0;

        for (int i = 0; i < this.NumarUtilizatori; i++)
        {
            Console.WriteLine("Nota data de {0} este: ", u[i].GetUsername());
            nota=Convert.ToDouble(Console.ReadLine());
            rating = rating + nota;
        }
        return (rating / NumarUtilizatori);
    }
    
    
    
}