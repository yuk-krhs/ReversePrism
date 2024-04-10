using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 initializationCount                      int IL2CPP_TYPE_I4
    // 004 isConfigured                             bool IL2CPP_TYPE_BOOLEAN
    // 008 defaultInstallBufferSize                 int IL2CPP_TYPE_I4
    // 00C installBufferSize                        int IL2CPP_TYPE_I4
    public partial class CriFsPlugin : DataModel
    {

        public static CriFsPlugin? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriFsPlugin() { Pointer= p0 };


            return value;
        }
    }
}
