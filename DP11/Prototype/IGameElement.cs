using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP11.Prototype
{
    public interface IGameElement
    {
        IGameElement Clone();
        void Render();
    }
}
