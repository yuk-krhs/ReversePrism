using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_field                                  000186698E30 ModelClassType RuntimeFieldInfo RuntimeFieldInfo RuntimeFieldInfo Pointer
    // 018 M_serializationName                      000186671910 ModelPrimitiveType string string string String
    public partial class SerializationFieldInfo
    {
        public RuntimeFieldInfo?                        M_field                                 { get; set; }
        public string                                   M_serializationName                     { get; set; }

        public static SerializationFieldInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SerializationFieldInfo();

            value.M_field                                   = GetObject<RuntimeFieldInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.RuntimeFieldInfo.FromPointer); // 0270D6C290F0 0x10 M_field                     ( 000186698E30 ModelClassType RuntimeFieldInfo RuntimeFieldInfo RuntimeFieldInfo Pointer )
            value.M_serializationName                       = GetString(new IntPtr(p + 0x018)); // 0270D6C29110 0x18 M_serializationName         ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
