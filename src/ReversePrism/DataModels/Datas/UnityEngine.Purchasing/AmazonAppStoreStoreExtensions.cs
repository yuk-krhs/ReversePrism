using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Android                                  ModelClassType AndroidJavaObject AndroidJavaObject AndroidJavaObject Pointer
    public partial class AmazonAppStoreStoreExtensions : DataModel
    {
        public AndroidJavaObject?                       Android                                 { get; set; }

        public static AmazonAppStoreStoreExtensions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AmazonAppStoreStoreExtensions() { Pointer= p0 };

            value.Android                                   = GetObject<AndroidJavaObject>(new IntPtr(p + 0x010), ReversePrism.DataModels.AndroidJavaObject.FromPointer); // 0x10 Android                     ( ModelClassType AndroidJavaObject AndroidJavaObject AndroidJavaObject Pointer )

            return value;
        }
    }
}
