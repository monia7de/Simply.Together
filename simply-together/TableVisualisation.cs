using System;
using System.Diagnostics.CodeAnalysis;
using ConsoleTableExt;

namespace simply_together
{
    public class TableVisualisation
    {
        /// <summary>
        /// Method <c>DisplayTable</c> uses ConsoleTableBuilder to draw a table in the console.
        /// It receives a list of generic type <paramref name="tableData"/> and conducts a null check on 
        /// <paramref name="tableName"/>
        /// </summary>
        public static void DisplayTable<T>(List<T> tableData, [AllowNull] string tableName) where T : class
        {
            if (tableName == null)
                tableName = "";

                Console.WriteLine("\n\n");

                ConsoleTableBuilder
                    .From(tableData)
                    .WithColumn(tableName)
                    .ExportAndWriteLine();
                Console.WriteLine("\n\n");
                
        }







    }
}
