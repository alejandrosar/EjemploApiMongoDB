using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksApi
{
    public class COMO_SE_MONTA_EL_MONGO
    {
        /*
         * Configurar MongoDB
            Si usa Windows, MongoDB está instalado en C:\Archivos de programa\MongoDB de forma predeterminada. Agregue C:\Archivos de programa\MongoDB\Server\<número_versión>\bin a la variable de entorno Path. Este cambio permite el acceso a MongoDB desde cualquier lugar en el equipo de desarrollo.
            Use el Shell de mongo en los pasos siguientes para crear una base de datos, hacer colecciones y almacenar documentos. Para obtener más información sobre los comandos de Shell de mongo, consulte Working with the mongo Shell (Trabajo con el shell de Mongo).
            Elija un directorio en el equipo de desarrollo para almacenar los datos. Por ejemplo, C:\BooksData en Windows. Si no existe el directorio, créelo. El shell de mongo no crea nuevos directorios.
            Abra un shell de comandos. Ejecute el comando siguiente para conectarse a MongoDB en el puerto predeterminado 27017. No olvide reemplazar <data_directory_path> por el directorio que eligió en el paso anterior.
            console

            Copiar
            mongod --dbpath <data_directory_path>
            Abra otra instancia del shell de comandos. Conéctese a la base de datos de prueba de forma predeterminada ejecutando el comando siguiente:
            console

            Copiar
            mongo
            Ejecute lo siguiente en un shell de comandos:
            console

            Copiar
            use BookstoreDb
            Si aún no existe, se crea una base de datos denominada BookstoreDb. Si la base de datos existe, su conexión se abre para las transacciones.
            Cree una colección Books con el comando siguiente:
            console

            Copiar
            db.createCollection('Books')
            Se muestra el siguiente resultado:
            console

            Copiar
            { "ok" : 1 }
            Defina un esquema para la colección Books e inserte dos documentos con el comando siguiente:
            console

            Copiar
            db.Books.insertMany([{'Name':'Design Patterns','Price':54.93,'Category':'Computers','Author':'Ralph Johnson'}, {'Name':'Clean Code','Price':43.15,'Category':'Computers','Author':'Robert C. Martin'}])
            Se muestra el siguiente resultado:
            console

            Copiar
            {
            "acknowledged" : true,
            "insertedIds" : [
            ObjectId("5bfd996f7b8e48dc15ff215d"),
            ObjectId("5bfd996f7b8e48dc15ff215e")
            ]
            }
            Nota

            Los identificadores que se muestran en este artículo no coinciden con los que se mostrarán cuando ejecute este ejemplo.
            Vea los documentos en la base de datos mediante el comando siguiente:
            console

            Copiar
            db.Books.find({}).pretty()
            Se muestra el siguiente resultado:
            console

            Copiar
            {
            "_id" : ObjectId("5bfd996f7b8e48dc15ff215d"),
            "Name" : "Design Patterns",
            "Price" : 54.93,
            "Category" : "Computers",
            "Author" : "Ralph Johnson"
            }
            {
            "_id" : ObjectId("5bfd996f7b8e48dc15ff215e"),
            "Name" : "Clean Code",
            "Price" : 43.15,
            "Category" : "Computers",
            "Author" : "Robert C. Martin"
            }
            El esquema agrega una propiedad _id generada automáticamente del tipo ObjectId para cada documento.
            La base de datos está lista. Puede empezar a crear la API web de ASP.NET Core.
        */
    }
}
