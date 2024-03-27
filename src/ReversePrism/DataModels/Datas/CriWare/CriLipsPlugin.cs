using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 scriptVersionString                      string IL2CPP_TYPE_STRING
    // 000 scriptVersionNumber                      int IL2CPP_TYPE_I4
    // 000 initializationCount                      int IL2CPP_TYPE_I4
    public partial class CriLipsPlugin
    {

        public static CriLipsPlugin? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriLipsPlugin();


            return value;
        }
    }
}
