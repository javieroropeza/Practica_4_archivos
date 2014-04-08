using System ;
using System.IO ;

namespace  Practica_4_archivos
{
	public class  Archivo
	{
		private  string  path ;

		public  Archivo  ( String path )
		{
			this. path  =  path ;
		}

		public  void  setPath ( String  path ) {
			this. path  =  path ;
		}

		public  void  leer () {
			String  linea ;
			try
				{
					if ( System . IO . File . Exists ( this. path ))
					{
						// Se indica el archivo a leer
						StreamReader  lector  =  new  StreamReader ( this. path );
					
						// Lee la primera linea del archivo
						linea  =  lector . ReadLine ();
						if ( linea == null){
							Console.WriteLine( "No hay ningun producto todavia\n");
						}
						// Continua leyendo Hasta Que se terminación el archivo
						else {
							while  ( linea  !=  null )
						{
							// Escribe la linea en la consolación
							Console . WriteLine ( linea );
							// Lee la siguiente linea
							linea  =  lector . ReadLine ();
						}

						// Cierra el lector
						lector . Close ();
						Console . ReadLine ();
						}
					}
					else
					{
						Console . WriteLine ( "No EXISTE el archivo." );
					}
				}
				catch ( Exception  e )
				{
					Console . WriteLine ( "Excepción:"  +  e . Message );
				}
			   	finally
				{
					Console . WriteLine ( "Cerrando la Lectura." );
				}
		}

		public  void  escribir ( String registro ) {
			try 
			{

				// Se indica el archivo a leer
				StreamWriter  Escritor  =  new StreamWriter (  this. path ,  true);
				// Escribe Una linea
				Escritor . WriteLine ( registro );
				// Cierra Escritor
				Escritor . Close ();
			}
			catch ( Exception  e )
			{
				Console . WriteLine ( "Excepción:"  +  e . Message );
			}
			finally 
			{
				Console . WriteLine ( "Cerrando la escritura." );
			}
		}
	}
}