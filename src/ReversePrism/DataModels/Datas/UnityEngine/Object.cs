using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_CachedPtr                              <int> IL2CPP_TYPE_I
    // 000 OffsetOfInstanceIDInCPlusPlusObject      int IL2CPP_TYPE_I4
    // 000 objectIsNullMessage                      string IL2CPP_TYPE_STRING
    // 000 cloneDestroyedMessage                    string IL2CPP_TYPE_STRING
    public partial class Object
    {

        public static Object? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Object();


            return value;
        }
    }
}
