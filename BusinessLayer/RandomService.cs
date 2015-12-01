using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class RandomService : IRandomService
    {
        ISimulatedData _dataService;

        public RandomService(ISimulatedData dataService)
        {
            _dataService = dataService;
        }
        public string GetRandomData(string seed)
        {
            var str = _dataService.GetData(seed);

            var base64EncodedBytes = System.Convert.FromBase64String(str);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
