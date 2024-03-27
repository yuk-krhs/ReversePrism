using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Android                                  0001866AD7E0 ModelClassType AndroidJavaObject AndroidJavaObject AndroidJavaObject Pointer
    public partial class AmazonAppStoreStoreExtensions
    {
        public AndroidJavaObject?                       Android                                 { get; set; }

        public static AmazonAppStoreStoreExtensions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AmazonAppStoreStoreExtensions();

            value.Android                                   = GetObject<AndroidJavaObject>(new IntPtr(p + 0x010), ReversePrism.DataModels.AndroidJavaObject.FromPointer); // 0270068FD0B0 0x10 Android                     ( 0001866AD7E0 ModelClassType AndroidJavaObject AndroidJavaObject AndroidJavaObject Pointer )

            return value;
        }
    }
}
