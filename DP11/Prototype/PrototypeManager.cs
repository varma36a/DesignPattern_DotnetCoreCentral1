using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP11.Prototype
{
    public class PrototypeManager
    {
        private Dictionary<string, IGameElement> _prototypes = new Dictionary<string, IGameElement>();

        // Add a prototype to the manager
        public void AddPrototype(string key, IGameElement prototype)
        {
            _prototypes[key] = prototype;
        }

        // Clone a prototype based on a key
        public IGameElement GetPrototype(string key)
        {
            if (_prototypes.ContainsKey(key))
            {
                return _prototypes[key].Clone();
            }

            throw new ArgumentException("Prototype not found!");
        }
    }

}
