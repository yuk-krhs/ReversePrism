using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Value                                    ReadOnlySpan`1<char> IL2CPP_TYPE_GENERICINST
    // 020 Index                                    ModelPrimitiveType int int int Int32
    // 024 m_current                                char IL2CPP_TYPE_CHAR
    // 028 M_info                                   ModelClassType CompareInfo CompareInfo CompareInfo Pointer
    // 030 M_checkDigitToken                        ModelPrimitiveType bool bool bool Bool
    // 000 WhiteSpaceChecks                         char[] IL2CPP_TYPE_SZARRAY
    public partial class __DTString : DataModel
    {
        public int                                      Index                                   { get; set; }
        public CompareInfo?                             M_info                                  { get; set; }
        public bool                                     M_checkDigitToken                       { get; set; }

        public static __DTString? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new __DTString() { Pointer= p0 };

            value.Index                                     = GetInt32(new IntPtr(p + 0x020)); // 0x20 Index                       ( ModelPrimitiveType int int int Int32 )
            value.M_info                                    = GetObject<CompareInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.CompareInfo.FromPointer); // 0x28 M_info                      ( ModelClassType CompareInfo CompareInfo CompareInfo Pointer )
            value.M_checkDigitToken                         = GetBool(new IntPtr(p + 0x030)); // 0x30 M_checkDigitToken           ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
