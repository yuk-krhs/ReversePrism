using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _osArchitecture                          Architecture IL2CPP_TYPE_VALUETYPE
    // 004 _processArchitecture                     Architecture IL2CPP_TYPE_VALUETYPE
    // 008 _osPlatform                              OSPlatform IL2CPP_TYPE_VALUETYPE
    public partial class RuntimeInformation
    {

        public static RuntimeInformation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RuntimeInformation();


            return value;
        }
    }
}
