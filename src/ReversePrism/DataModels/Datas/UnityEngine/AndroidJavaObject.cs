using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 enableDebugPrints                        bool IL2CPP_TYPE_BOOLEAN
    // 010 M_jobject                                00018667BB20 ModelClassType GlobalJavaObjectRef GlobalJavaObjectRef GlobalJavaObjectRef Pointer
    // 018 M_jclass                                 00018667BB20 ModelClassType GlobalJavaObjectRef GlobalJavaObjectRef GlobalJavaObjectRef Pointer
    public partial class AndroidJavaObject : DataModel
    {
        public GlobalJavaObjectRef?                     M_jobject                               { get; set; }
        public GlobalJavaObjectRef?                     M_jclass                                { get; set; }

        public static AndroidJavaObject? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AndroidJavaObject() { Pointer= p0 };

            value.M_jobject                                 = GetObject<GlobalJavaObjectRef>(new IntPtr(p + 0x010), ReversePrism.DataModels.GlobalJavaObjectRef.FromPointer); // 0245A68F7168 0x10 M_jobject                   ( 00018667BB20 ModelClassType GlobalJavaObjectRef GlobalJavaObjectRef GlobalJavaObjectRef Pointer )
            value.M_jclass                                  = GetObject<GlobalJavaObjectRef>(new IntPtr(p + 0x018), ReversePrism.DataModels.GlobalJavaObjectRef.FromPointer); // 0245A68F7188 0x18 M_jclass                    ( 00018667BB20 ModelClassType GlobalJavaObjectRef GlobalJavaObjectRef GlobalJavaObjectRef Pointer )

            return value;
        }
    }
}
