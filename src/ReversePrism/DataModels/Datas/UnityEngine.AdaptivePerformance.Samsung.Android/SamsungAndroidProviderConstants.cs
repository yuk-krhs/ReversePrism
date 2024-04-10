using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_SettingsKey                            string IL2CPP_TYPE_STRING
    // 000 k_InvalidOperation                       int IL2CPP_TYPE_I4
    public partial class SamsungAndroidProviderConstants : DataModel
    {

        public static SamsungAndroidProviderConstants? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SamsungAndroidProviderConstants() { Pointer= p0 };


            return value;
        }
    }
}
