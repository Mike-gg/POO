using System;

public class Program
{
	class Peliculas
	{
		private string Titulo;
		private int Año;
		private string Pais;
		private string Director;
		
		public Peliculas( string t, int a, string p, string d)
		{
			this.Titulo = t;
			this.Año = a;
           	 this.Pais = p;
           	 this.Director = d;
		}
		
			public string getNombre()
			{
				return Titulo;
			}
			public int getAño()
			{
				return Año;
			}
        		public string getDirector()
        		{	
            			return Director;
        		}	
        		public string getPais()
        		{
            			return Pais;
        		}
		}
		public static void Main()
		{
		Peliculas a = new Peliculas("Joker", 2019,  "USA", "Todd Phillips");
		Peliculas b = new Peliculas("Revenant", 2015, "USA", "Alejandro González Iñárritu");
        Peliculas c = new Peliculas("Birdman", 2014, "USA", "Alejandro González Iñárritu");
        Peliculas d = new Peliculas("La forma del agua",2017 ,"USA" ,"Guillermo del Toro" );
        Peliculas e = new Peliculas("Gladiador", 1992,"UK", "Ridley Scott");

        Console.WriteLine("|" + "Titulo" + "           |" + "Año" + " |" + "País" + "|" + "Director                    |");
	Console.WriteLine("|-----------------|----|----|----------------------------|");
	Console.WriteLine("|" + a.getNombre() +"            |" + a.getAño() +"|" + a.getPais() +" |" +  " " + a.getDirector() + "              |");
        Console.WriteLine("|" + b.getNombre() +"         |" + b.getAño() +"|" + b.getPais() +" |" +  " " + b.getDirector() + "|");
        Console.WriteLine("|" + c.getNombre() +"          |" + c.getAño() +"|" + c.getPais() +" |" +  " " + c.getDirector() + "|");
        Console.WriteLine("|" + d.getNombre() +"|" + d.getAño() +"|" + d.getPais() +" |" +  " " + d.getDirector() + "         |");
        Console.WriteLine("|" + e.getNombre() +"        |" + e.getAño() +"| " + e.getPais() +" |" +  " " + e.getDirector() + "               |");
        Console.WriteLine("|-----------------|----|----|----------------------------|");
	}
}
