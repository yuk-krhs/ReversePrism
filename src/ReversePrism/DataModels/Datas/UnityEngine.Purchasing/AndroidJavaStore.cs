using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Store                                  ModelClassType AndroidJavaObject AndroidJavaObject AndroidJavaObject Pointer
    public partial class AndroidJavaStore : DataModel
    {
        public AndroidJavaObject?                       M_Store                                 { get; set; }

        public static AndroidJavaStore? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AndroidJavaStore() { Pointer= p0 };

            value.M_Store                                   = GetObject<AndroidJavaObject>(new IntPtr(p + 0x010), ReversePrism.DataModels.AndroidJavaObject.FromPointer); // 0x10 M_Store                     ( ModelClassType AndroidJavaObject AndroidJavaObject AndroidJavaObject Pointer )

            return value;
        }
    }
}
