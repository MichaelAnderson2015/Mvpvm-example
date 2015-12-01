using System;
namespace BusinessLayer
{
    public interface IRandomService
    {
        string GetRandomData(string seed);
    }
}
