using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Index                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 Unicode                                  0001866992B0 ModelPrimitiveType uint uint uint UInt32
    public partial class CharacterSubstitution
    {
        public int                                      Index                                   { get; set; }
        public uint                                     Unicode                                 { get; set; }

        public static CharacterSubstitution? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterSubstitution();

            value.Index                                     = GetInt32(new IntPtr(p + 0x010)); // 0270068F9668 0x10 Index                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Unicode                                   = GetUInt32(new IntPtr(p + 0x014)); // 0270068F9688 0x14 Unicode                     ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
