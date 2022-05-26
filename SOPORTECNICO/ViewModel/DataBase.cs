using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOPORTECNICO.ViewModel
{
    public interface DataBase
    {
        SQLiteAsyncConnection GetConnection();
    }
}
