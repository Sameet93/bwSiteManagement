using System;
using SQLite;

namespace Brightwave2
{
    public interface SQLiteInt
    {
        SQLiteConnection getConnection();
    }
}
