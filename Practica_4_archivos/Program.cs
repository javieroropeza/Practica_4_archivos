using System;

namespace Practica_4_archivos
{
    
class MainClass
	{
		
public static void Main (string [] args)
	
		{
	
		int pal ;
            
		do{
                	
			Console.WriteLine("\tMENU [.] para salir\n");
                
			Console.WriteLine("1) Imprimir Productos\n");
               
			Console.WriteLine("2) Agregar un nuevo producto\n");
			
 
			pal = int.Parse( Console.ReadLine() );
		
      
			switch( pal ){
                    
				case 1: 
					string url = "Archivo de productos.txt";
					Archivo archivo = new Archivo(url);
					archivo.leer();  
					break;					
				
				case 2: 
					
					Console.WriteLine( "Dame el nombre del producto" );
					String nombre = Console.ReadLine();
					Console.WriteLine( "Dame el codigo para el producto" );
					String codigo = Console.ReadLine();
					Console.WriteLine( "Dame la descripcion del producto" );
					String descripcion = Console.ReadLine();
			    
					String registro = nombre +","+ codigo + ","	+ descripcion + "\n";
					url = "Archivo de productos.txt";
					
					Archivo archivo1 = new Archivo(url);
                    
                	archivo1.escribir(registro); 
                	archivo1.leer();
                	break;
				}
			
				System.Console.Clear(); 
			}while ( pal != "3");
	
            
		

			
	//Observador observador = new Observador();
			
	//observador.inicia();
		
	}
	
  }

}