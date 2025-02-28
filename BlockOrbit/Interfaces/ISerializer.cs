using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockOrbit.Interfaces
{
    public interface ISerializer<K>
    {
        byte[] Serialize(K value);

        K Deserialize(byte[] buffer, int offset, int length);

        bool IsFixedSize
        {
            get;
        }

        int Length
        {
            get;
        }
    }
}
