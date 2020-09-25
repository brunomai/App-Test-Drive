using SQLite;
using System;
using System.Collections.Generic;
using System.Text;


namespace AppXamarin.Data
{
    public interface ISQLite
    {
        SQLiteConnection PegarConnection();      
        
    }
}
