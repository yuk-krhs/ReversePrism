using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SheetInstanceID                          0001865F4940 ModelPrimitiveType int int int Int32
    // 014 Index                                    0001865F4940 ModelPrimitiveType int int int Int32
    public partial class SheetHandleKey
    {
        public int                                      SheetInstanceID                         { get; set; }
        public int                                      Index                                   { get; set; }

        public static SheetHandleKey? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SheetHandleKey();

            value.SheetInstanceID                           = GetInt32(new IntPtr(p + 0x010)); // 0270068868C0 0x10 SheetInstanceID             ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Index                                     = GetInt32(new IntPtr(p + 0x014)); // 0270068868E0 0x14 Index                       ( 0001865F4940 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
