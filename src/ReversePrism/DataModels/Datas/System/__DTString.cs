using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Value                                    ReadOnlySpan`1<char> IL2CPP_TYPE_GENERICINST
    // 020 Index                                    0001865F2F90 ModelPrimitiveType int int int Int32
    // 024 m_current                                char IL2CPP_TYPE_CHAR
    // 028 M_info                                   0001865EB460 ModelClassType CompareInfo CompareInfo CompareInfo Pointer
    // 030 M_checkDigitToken                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 WhiteSpaceChecks                         char[] IL2CPP_TYPE_SZARRAY
    public partial class __DTString
    {
        public int                                      Index                                   { get; set; }
        public CompareInfo?                             M_info                                  { get; set; }
        public bool                                     M_checkDigitToken                       { get; set; }

        public static __DTString? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new __DTString();

            value.Index                                     = GetInt32(new IntPtr(p + 0x020)); // 0270D3066640 0x20 Index                       ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_info                                    = GetObject<CompareInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.CompareInfo.FromPointer); // 0270D3066680 0x28 M_info                      ( 0001865EB460 ModelClassType CompareInfo CompareInfo CompareInfo Pointer )
            value.M_checkDigitToken                         = GetBool(new IntPtr(p + 0x030)); // 0270D30666A0 0x30 M_checkDigitToken           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
