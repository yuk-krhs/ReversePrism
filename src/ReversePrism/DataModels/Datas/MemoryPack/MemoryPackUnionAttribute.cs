using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Tag                                      ModelPrimitiveType ushort ushort ushort UInt16
    // 018 Type                                     ModelClassType Type Type Type Pointer
    public partial class MemoryPackUnionAttribute : DataModel
    {
        public ushort                                   Tag                                     { get; set; }
        public Type?                                    Type                                    { get; set; }

        public static MemoryPackUnionAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MemoryPackUnionAttribute() { Pointer= p0 };

            value.Tag                                       = GetUInt16(new IntPtr(p + 0x010)); // 0x10 Tag                         ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 0x18 Type                        ( ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
