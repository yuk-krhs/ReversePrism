using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Index                                    0001865F4940 ModelPrimitiveType int int int Int32
    // 014 Flags                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class LocalVariable
    {
        public int                                      Index                                   { get; set; }
        public int                                      Flags                                   { get; set; }

        public static LocalVariable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LocalVariable();

            value.Index                                     = GetInt32(new IntPtr(p + 0x010)); // 0270D9FDAD10 0x10 Index                       ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Flags                                     = GetInt32(new IntPtr(p + 0x014)); // 0270D9FDAD30 0x14 Flags                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
