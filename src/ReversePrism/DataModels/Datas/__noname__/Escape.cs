using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Source                                   ModelPrimitiveType string string string String
    // 018 Index                                    ModelPrimitiveType int int int Int32
    // 01C Start                                    ModelPrimitiveType int int int Int32
    // 020 End                                      ModelPrimitiveType int int int Int32
    // 024 Optional                                 ModelPrimitiveType int int int Int32
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

            value.Source                                    = GetString(new IntPtr(p + 0x010)); // 0x10 Source                      ( ModelPrimitiveType string string string String )
            value.Index                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Index                       ( ModelPrimitiveType int int int Int32 )
            value.Start                                     = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Start                       ( ModelPrimitiveType int int int Int32 )
            value.End                                       = GetInt32(new IntPtr(p + 0x020)); // 0x20 End                         ( ModelPrimitiveType int int int Int32 )
            value.Optional                                  = GetInt32(new IntPtr(p + 0x024)); // 0x24 Optional                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
