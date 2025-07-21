using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OuterHeadline                            ModelPrimitiveType string string string String
    // 018 InnerHeadline                            ModelPrimitiveType string string string String
    // 020 Summary                                  ModelPrimitiveType string string string String
    // 028 HasAdvInformation                        ModelPrimitiveType bool bool bool Bool
    public partial class AdvSkipConfirmationPopupViewModel : DataModel
    {
        public string                                   OuterHeadline                           { get; set; }
        public string                                   InnerHeadline                           { get; set; }
        public string                                   Summary                                 { get; set; }
        public bool                                     HasAdvInformation                       { get; set; }

        public static AdvSkipConfirmationPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdvSkipConfirmationPopupViewModel() { Pointer= p0 };

            value.OuterHeadline                             = GetString(new IntPtr(p + 0x010)); // 0x10 OuterHeadline               ( ModelPrimitiveType string string string String )
            value.InnerHeadline                             = GetString(new IntPtr(p + 0x018)); // 0x18 InnerHeadline               ( ModelPrimitiveType string string string String )
            value.Summary                                   = GetString(new IntPtr(p + 0x020)); // 0x20 Summary                     ( ModelPrimitiveType string string string String )
            value.HasAdvInformation                         = GetBool(new IntPtr(p + 0x028)); // 0x28 HasAdvInformation           ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
