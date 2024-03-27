using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_SpaceInfo                              000186609380 ModelEnumType LocalKeywordSpace LocalKeywordSpace LocalKeywordSpace Int32
    // 018 M_Name                                   0001866731A0 ModelPrimitiveType string string string String
    // 020 M_Index                                  000186699C60 ModelPrimitiveType uint uint uint UInt32
    public partial class LocalKeyword
    {
        public LocalKeywordSpace                        M_SpaceInfo                             { get; set; }
        public string                                   M_Name                                  { get; set; }
        public uint                                     M_Index                                 { get; set; }

        public static LocalKeyword? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LocalKeyword();

            value.M_SpaceInfo                               = (LocalKeywordSpace)GetInt32(new IntPtr(p + 0x010)); // 02700246E030 0x10 M_SpaceInfo                 ( 000186609380 ModelEnumType LocalKeywordSpace LocalKeywordSpace LocalKeywordSpace Int32 )
            value.M_Name                                    = GetString(new IntPtr(p + 0x018)); // 02700246E050 0x18 M_Name                      ( 0001866731A0 ModelPrimitiveType string string string String )
            value.M_Index                                   = GetUInt32(new IntPtr(p + 0x020)); // 02700246E070 0x20 M_Index                     ( 000186699C60 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
