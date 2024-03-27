using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Name                                   000186671BA0 ModelPrimitiveType string string string String
    // 018 M_Index                                  000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 01C M_IsLocal                                000186595210 ModelPrimitiveType bool bool bool Bool
    // 01D M_IsCompute                              000186595210 ModelPrimitiveType bool bool bool Bool
    // 01E M_IsValid                                000186595210 ModelPrimitiveType bool bool bool Bool
    public partial class ShaderKeyword
    {
        public string                                   M_Name                                  { get; set; }
        public uint                                     M_Index                                 { get; set; }
        public bool                                     M_IsLocal                               { get; set; }
        public bool                                     M_IsCompute                             { get; set; }
        public bool                                     M_IsValid                               { get; set; }

        public static ShaderKeyword? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShaderKeyword();

            value.M_Name                                    = GetString(new IntPtr(p + 0x010)); // 027002476958 0x10 M_Name                      ( 000186671BA0 ModelPrimitiveType string string string String )
            value.M_Index                                   = GetUInt32(new IntPtr(p + 0x018)); // 027002476978 0x18 M_Index                     ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.M_IsLocal                                 = GetBool(new IntPtr(p + 0x01C)); // 027002476998 0x1C M_IsLocal                   ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.M_IsCompute                               = GetBool(new IntPtr(p + 0x01D)); // 0270024769B8 0x1D M_IsCompute                 ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.M_IsValid                                 = GetBool(new IntPtr(p + 0x01E)); // 0270024769D8 0x1E M_IsValid                   ( 000186595210 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
