using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Index                                    ModelPrimitiveType int int int Int32
    // 014 Flags                                    ModelPrimitiveType int int int Int32
    public partial class LocalVariable : DataModel
    {
        public int                                      Index                                   { get; set; }
        public int                                      Flags                                   { get; set; }

        public static LocalVariable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LocalVariable() { Pointer= p0 };

            value.Index                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 Index                       ( ModelPrimitiveType int int int Int32 )
            value.Flags                                     = GetInt32(new IntPtr(p + 0x014)); // 0x14 Flags                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
