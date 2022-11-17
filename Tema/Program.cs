// See https://aka.ms/new-console-template for more information

using Tema;

WebApplication s1 = new WebApplication("Facebook", 23);
MobileApplication s2 = new MobileApplication("Instagram", 34);
List<Application> l = new List<Application>();
l.Add(s1);
l.Add(s2);
Admin unu = new Admin(Console.ReadLine(),l);


User u1 = new User("aniastef", "stelute", "aniastef11@gmail.com");
User u2 = new User("ionescu", "mancare", "ionescuandreiI@gmail.com");
User u3 = new User("nico", "mov", "niconiconii@gmail.com");
User u4 = new User("marius", "hungaria", "marius@gmail.hu");


unu.AddUser(u1,s1);
unu.AddUser(u2,s2);
unu.AddUser(u3,s1);
unu.AddUser(u4,s2);

Console.WriteLine(s1.GetNumberOfUsers());
Console.WriteLine(s1);
unu.RemoveUser(u3,s1);
Console.WriteLine(s1);

s1.HttpRequest(u3);
Console.WriteLine("Rating-ul final este {0} ",s2.RateApp());
u1.ChangePassword("parolanoua");
u1.GetPassword();
Console.WriteLine(s2);







