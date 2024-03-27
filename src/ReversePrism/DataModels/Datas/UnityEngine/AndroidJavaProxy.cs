using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 JavaInterface                            0001866ACD40 ModelClassType AndroidJavaClass AndroidJavaClass AndroidJavaClass Pointer
    // 018 proxyObject                              <int> IL2CPP_TYPE_I
    // 000 s_JavaLangSystemClass                    GlobalJavaObjectRef IL2CPP_TYPE_CLASS
    // 008 s_HashCodeMethodID                       <int> IL2CPP_TYPE_I
    public partial class AndroidJavaProxy
    {
        public AndroidJavaClass?                        JavaInterface                           { get; set; }

        public static AndroidJavaProxy? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AndroidJavaProxy();

            value.JavaInterface                             = GetObject<AndroidJavaClass>(new IntPtr(p + 0x010), ReversePrism.DataModels.AndroidJavaClass.FromPointer); // 027006905248 0x10 JavaInterface               ( 0001866ACD40 ModelClassType AndroidJavaClass AndroidJavaClass AndroidJavaClass Pointer )

            return value;
        }
    }
}
