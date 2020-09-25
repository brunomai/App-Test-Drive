using System.IO;
using AppXamarin.Data;
using AppXamarin.Droid;
using SQLite;
using PCLExt.FileStorage;
using PCLExt.FileStorage.Folders;

[assembly: Xamarin.Forms.Dependency(typeof(SQLite_Android))]
namespace AppXamarin.Droid
{
    class SQLite_Android : ISQLite
    {
        private const string nomeArquivoDB = "Agendamentos.db3";

        public SQLiteConnection PegarConnection()
        {
            //Cria uma pasta base local para o dispositivo
            var path = new LocalRootFolder();
            //Cria o arquivo
            var arquivo = path.CreateFile(nomeArquivoDB     , CreationCollisionOption.OpenIfExists);
            
            return new SQLite.SQLiteConnection(arquivo.Path);
        }
    }
}