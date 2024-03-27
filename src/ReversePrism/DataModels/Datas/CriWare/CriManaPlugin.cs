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
    // 005 enabledMultithreadedRendering            bool IL2CPP_TYPE_BOOLEAN
    // 008 renderingEventOffset                     int IL2CPP_TYPE_I4
    public partial class CriManaPlugin
    {

        public static CriManaPlugin? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriManaPlugin();


            return value;
        }
    }
}
