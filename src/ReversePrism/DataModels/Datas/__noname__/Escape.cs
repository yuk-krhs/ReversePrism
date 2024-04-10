using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Source                                   0001866722E0 ModelPrimitiveType string string string String
    // 018 Index                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C Start                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 End                                      0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 Optional                                 0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class Escape : DataModel
    {
        public string                                   Source                                  { get; set; }
        public int                                      Index                                   { get; set; }
        public int                                      Start                                   { get; set; }
        public int                                      End                                     { get; set; }
        public int                                      Optional                                { get; set; }

        public static Escape? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Escape() { Pointer= p0 };

            value.Source                                    = GetString(new IntPtr(p + 0x010)); // 0246669AB300 0x10 Source                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Index                                     = GetInt32(new IntPtr(p + 0x018)); // 0246669AB320 0x18 Index                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Start                                     = GetInt32(new IntPtr(p + 0x01C)); // 0246669AB340 0x1C Start                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.End                                       = GetInt32(new IntPtr(p + 0x020)); // 0246669AB360 0x20 End                         ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Optional                                  = GetInt32(new IntPtr(p + 0x024)); // 0246669AB380 0x24 Optional                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
