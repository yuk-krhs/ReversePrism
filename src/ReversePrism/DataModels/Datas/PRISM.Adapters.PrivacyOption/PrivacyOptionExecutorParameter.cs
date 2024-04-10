using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsOnTitleSequence                        0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 018 SearchUserId                             000186672F10 ModelPrimitiveType string string string String
    public partial class PrivacyOptionExecutorParameter : DataModel
    {
        public bool                                     IsOnTitleSequence                       { get; set; }
        public string                                   SearchUserId                            { get; set; }

        public static PrivacyOptionExecutorParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrivacyOptionExecutorParameter() { Pointer= p0 };

            value.IsOnTitleSequence                         = GetBool(new IntPtr(p + 0x010)); // 0245A4E41B98 0x10 IsOnTitleSequence           ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.SearchUserId                              = GetString(new IntPtr(p + 0x018)); // 0245A4E41BB8 0x18 SearchUserId                ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
