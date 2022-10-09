using System;
using System.Diagnostics.CodeAnalysis;
using ConsoleTableExt;

namespace simply_together
{
    public class TableVisualisation
    {
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
