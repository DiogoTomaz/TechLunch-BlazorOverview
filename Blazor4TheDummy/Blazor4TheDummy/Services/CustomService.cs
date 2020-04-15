using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor4TheDummy.Services
{
    public class CustomService : ICustomService
    {
        public void IAmUtterlyUseless()
        {
            throw new NotImplementedException();
        }
    }

    public interface ICustomService
    {
        public void IAmUtterlyUseless();
    }
}
