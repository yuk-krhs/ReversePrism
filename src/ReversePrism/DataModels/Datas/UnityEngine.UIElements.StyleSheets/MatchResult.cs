using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ErrorCode                                0001865DE380 ModelEnumType MatchResultErrorCode MatchResultErrorCode MatchResultErrorCode Int32
    // 018 ErrorValue                               0001866722E0 ModelPrimitiveType string string string String
    public partial class MatchResult : DataModel
    {
        public MatchResultErrorCode                     ErrorCode                               { get; set; }
        public string                                   ErrorValue                              { get; set; }

        public static MatchResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MatchResult() { Pointer= p0 };

            value.ErrorCode                                 = (MatchResultErrorCode)GetInt32(new IntPtr(p + 0x010)); // 0245A6848F70 0x10 ErrorCode                   ( 0001865DE380 ModelEnumType MatchResultErrorCode MatchResultErrorCode MatchResultErrorCode Int32 )
            value.ErrorValue                                = GetString(new IntPtr(p + 0x018)); // 0245A6848F90 0x18 ErrorValue                  ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
