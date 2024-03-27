using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 SPACE                                    uint IL2CPP_TYPE_U4
    // 000 DOUBLE_QUOTE                             uint IL2CPP_TYPE_U4
    // 000 NUMBER_SIGN                              uint IL2CPP_TYPE_U4
    // 000 PERCENTAGE                               uint IL2CPP_TYPE_U4
    // 000 PLUS                                     uint IL2CPP_TYPE_U4
    // 000 MINUS                                    uint IL2CPP_TYPE_U4
    // 000 PERIOD                                   uint IL2CPP_TYPE_U4
    // 000 HYPHEN_MINUS                             uint IL2CPP_TYPE_U4
    // 000 SOFT_HYPHEN                              uint IL2CPP_TYPE_U4
    // 000 HYPHEN                                   uint IL2CPP_TYPE_U4
    // 000 NON_BREAKING_HYPHEN                      uint IL2CPP_TYPE_U4
    // 000 ZERO_WIDTH_SPACE                         uint IL2CPP_TYPE_U4
    // 000 RIGHT_SINGLE_QUOTATION                   uint IL2CPP_TYPE_U4
    // 000 APOSTROPHE                               uint IL2CPP_TYPE_U4
    // 000 WORD_JOINER                              uint IL2CPP_TYPE_U4
    // 000 HIGH_SURROGATE_START                     uint IL2CPP_TYPE_U4
    // 000 HIGH_SURROGATE_END                       uint IL2CPP_TYPE_U4
    // 000 LOW_SURROGATE_START                      uint IL2CPP_TYPE_U4
    // 000 LOW_SURROGATE_END                        uint IL2CPP_TYPE_U4
    // 000 UNICODE_PLANE01_START                    uint IL2CPP_TYPE_U4
    public partial class CodePoint
    {

        public static CodePoint? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CodePoint();


            return value;
        }
    }
}
