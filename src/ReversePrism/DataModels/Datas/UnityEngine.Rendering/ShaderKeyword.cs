using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Name                                   ModelPrimitiveType string string string String
    // 018 M_Index                                  ModelPrimitiveType uint uint uint UInt32
    // 01C M_IsLocal                                ModelPrimitiveType bool bool bool Bool
    // 01D M_IsCompute                              ModelPrimitiveType bool bool bool Bool
    // 01E M_IsValid                                ModelPrimitiveType bool bool bool Bool
    public partial class ShaderKeyword : DataModel
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
            var value   = new ShaderKeyword() { Pointer= p0 };

            value.M_Name                                    = GetString(new IntPtr(p + 0x010)); // 0x10 M_Name                      ( ModelPrimitiveType string string string String )
            value.M_Index                                   = GetUInt32(new IntPtr(p + 0x018)); // 0x18 M_Index                     ( ModelPrimitiveType uint uint uint UInt32 )
            value.M_IsLocal                                 = GetBool(new IntPtr(p + 0x01C)); // 0x1C M_IsLocal                   ( ModelPrimitiveType bool bool bool Bool )
            value.M_IsCompute                               = GetBool(new IntPtr(p + 0x01D)); // 0x1D M_IsCompute                 ( ModelPrimitiveType bool bool bool Bool )
            value.M_IsValid                                 = GetBool(new IntPtr(p + 0x01E)); // 0x1E M_IsValid                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
