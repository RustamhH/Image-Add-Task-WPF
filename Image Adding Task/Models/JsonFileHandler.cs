using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;

namespace Image_Adding_Task.Models
{
    public static class JsonFileHandler
    {
        public static void Write<T>(string filePath, T values)
        {
            try
            {
                JsonSerializerOptions op = new JsonSerializerOptions();
                op.WriteIndented = true;
                File.WriteAllText(filePath, JsonSerializer.Serialize(values, op));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public static T Read<T>(string filePath)
        {
            try
            {
                string text = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<T>(text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return default(T);
        }
    }
}
