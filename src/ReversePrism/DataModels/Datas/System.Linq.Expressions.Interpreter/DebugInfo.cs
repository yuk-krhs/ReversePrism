using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StartLine                                ModelPrimitiveType int int int Int32
    // 014 EndLine                                  ModelPrimitiveType int int int Int32
    // 018 Index                                    ModelPrimitiveType int int int Int32
    // 020 FileName                                 ModelPrimitiveType string string string String
    // 028 IsClear                                  ModelPrimitiveType bool bool bool Bool
    // 000 s_debugComparer                          DebugInfoComparer IL2CPP_TYPE_CLASS
    public partial class DebugInfo : DataModel
    {
        public int                                      StartLine                               { get; set; }
        public int                                      EndLine                                 { get; set; }
        public int                                      Index                                   { get; set; }
        public string                                   FileName                                { get; set; }
        public bool                                     IsClear                                 { get; set; }

        public static DebugInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugInfo() { Pointer= p0 };

            value.StartLine                                 = GetInt32(new IntPtr(p + 0x010)); // 0x10 StartLine                   ( ModelPrimitiveType int int int Int32 )
            value.EndLine                                   = GetInt32(new IntPtr(p + 0x014)); // 0x14 EndLine                     ( ModelPrimitiveType int int int Int32 )
            value.Index                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Index                       ( ModelPrimitiveType int int int Int32 )
            value.FileName                                  = GetString(new IntPtr(p + 0x020)); // 0x20 FileName                    ( ModelPrimitiveType string string string String )
            value.IsClear                                   = GetBool(new IntPtr(p + 0x028)); // 0x28 IsClear                     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
