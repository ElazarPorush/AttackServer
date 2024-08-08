using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace AttackServer
{
    internal class AttackMenager
    {
        public static async Task<List<Missile>> GetFileAsync(string filePath)
        {
            try
            {
                string result = await Task.Run(() => File.ReadAllText(filePath));
                List<Missile> missiles = JsonSerializer.Deserialize<List<Missile>>(result);
                return missiles;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
            return null;
        }
    }
}
