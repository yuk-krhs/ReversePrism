using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SheetInstanceID                          ModelPrimitiveType int int int Int32
    // 014 Index                                    ModelPrimitiveType int int int Int32
    public partial class SheetHandleKey : DataModel
    {
        public int                                      SheetInstanceID                         { get; set; }
        public int                                      Index                                   { get; set; }

        public static SheetHandleKey? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SheetHandleKey() { Pointer= p0 };

            value.SheetInstanceID                           = GetInt32(new IntPtr(p + 0x010)); // 0x10 SheetInstanceID             ( ModelPrimitiveType int int int Int32 )
            value.Index                                     = GetInt32(new IntPtr(p + 0x014)); // 0x14 Index                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
