using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 List                                     ModelClassType Array Array Array Pointer
    // 018 Index                                    ModelPrimitiveType int int int Int32
    // 020 Id                                       ModelPrimitiveType string string string String
    public partial class CollectionItemFixup : DataModel
    {
        public Array?                                   List                                    { get; set; }
        public int                                      Index                                   { get; set; }
        public string                                   Id                                      { get; set; }

        public static CollectionItemFixup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CollectionItemFixup() { Pointer= p0 };

            value.List                                      = GetObject<Array>(new IntPtr(p + 0x010), ReversePrism.DataModels.Array.FromPointer); // 0x10 List                        ( ModelClassType Array Array Array Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Index                       ( ModelPrimitiveType int int int Int32 )
            value.Id                                        = GetString(new IntPtr(p + 0x020)); // 0x20 Id                          ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
