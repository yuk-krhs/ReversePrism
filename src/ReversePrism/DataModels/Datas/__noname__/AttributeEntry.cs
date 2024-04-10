using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     000186692F60 ModelClassType Type Type Type Pointer
    // 018 Index                                    0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class AttributeEntry : DataModel
    {
        public Type?                                    Type                                    { get; set; }
        public int                                      Index                                   { get; set; }

        public static AttributeEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AttributeEntry() { Pointer= p0 };

            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0245A60085E8 0x10 Type                        ( 000186692F60 ModelClassType Type Type Type Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x018)); // 0245A6008608 0x18 Index                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
