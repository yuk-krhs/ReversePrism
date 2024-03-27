using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 pluginName                               string IL2CPP_TYPE_STRING
    // 000 pluginCallingConvention                  CallingConvention IL2CPP_TYPE_VALUETYPE
    // 000 initializationCount                      int IL2CPP_TYPE_I4
    public partial class CriLipsAtomPlugin
    {

        public static CriLipsAtomPlugin? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriLipsAtomPlugin();


            return value;
        }
    }
}
