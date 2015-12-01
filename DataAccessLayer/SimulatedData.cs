using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class SimulatedData : ISimulatedData
    {
        public string GetData(string seed)
        {
            
            // Simulating data retrieved from DAL
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var str = new string(Enumerable.Repeat(chars, seed.Length)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(str);
            return System.Convert.ToBase64String(plainTextBytes);
        }
    }
}
