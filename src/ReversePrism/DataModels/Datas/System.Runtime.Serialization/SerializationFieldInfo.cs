using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_field                                  ModelClassType RuntimeFieldInfo RuntimeFieldInfo RuntimeFieldInfo Pointer
    // 018 M_serializationName                      ModelPrimitiveType string string string String
    public partial class SerializationFieldInfo : DataModel
    {
        public RuntimeFieldInfo?                        M_field                                 { get; set; }
        public string                                   M_serializationName                     { get; set; }

        public static SerializationFieldInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SerializationFieldInfo() { Pointer= p0 };

            value.M_field                                   = GetObject<RuntimeFieldInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.RuntimeFieldInfo.FromPointer); // 0x10 M_field                     ( ModelClassType RuntimeFieldInfo RuntimeFieldInfo RuntimeFieldInfo Pointer )
            value.M_serializationName                       = GetString(new IntPtr(p + 0x018)); // 0x18 M_serializationName         ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
