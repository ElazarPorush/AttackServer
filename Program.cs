using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Policy;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace AttackServer
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            try
                
            {
                string jsonFilePath = "C:\\Users\\lzrpr\\OneDrive\\Desktop\\קבצים\\תיכנות\\עבודות בתכנות\\_galil\\Reposetory\\IronDome\\AttackServer\\Missiles.json";
                List<Missile> missiles = await AttackMenager.GetFileAsync(jsonFilePath);

                foreach (Missile missel in missiles)
                {
                    Console.WriteLine($"Name: {missel.name}, Speed: {missel.speed}, Mass: {missel.mass}, Origin: ({missel.origin.X}, {missel.origin.Y}, {missel.origin.Z}), Angle: ({missel.angle.X}, {missel.angle.Y}, {missel.angle.Z})");
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

        
    }
}
