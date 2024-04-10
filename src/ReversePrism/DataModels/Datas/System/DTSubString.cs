using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 s                                        ReadOnlySpan`1<char> IL2CPP_TYPE_GENERICINST
    // 020 Index                                    0001865F2F90 ModelPrimitiveType int int int Int32
    // 024 Length                                   0001865F2F90 ModelPrimitiveType int int int Int32
    // 028 Type                                     000186674F20 ModelEnumType DTSubStringType DTSubStringType DTSubStringType Int32
    // 02C Value                                    0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class DTSubString : DataModel
    {
        public int                                      Index                                   { get; set; }
        public int                                      Length                                  { get; set; }
        public DTSubStringType                          Type                                    { get; set; }
        public int                                      Value                                   { get; set; }

        public static DTSubString? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DTSubString() { Pointer= p0 };

            value.Index                                     = GetInt32(new IntPtr(p + 0x020)); // 024666A0D370 0x20 Index                       ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Length                                    = GetInt32(new IntPtr(p + 0x024)); // 024666A0D390 0x24 Length                      ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Type                                      = (DTSubStringType)GetInt32(new IntPtr(p + 0x028)); // 024666A0D3B0 0x28 Type                        ( 000186674F20 ModelEnumType DTSubStringType DTSubStringType DTSubStringType Int32 )
            value.Value                                     = GetInt32(new IntPtr(p + 0x02C)); // 024666A0D3D0 0x2C Value                       ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
