using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MainHeadline                             000186672F10 ModelPrimitiveType string string string String
    // 018 SubHeadline                              000186672F10 ModelPrimitiveType string string string String
    // 020 Summary                                  000186672F10 ModelPrimitiveType string string string String
    // 028 HasAdvInformation                        0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class AdvSkipConfirmationPopupViewModel : DataModel
    {
        public string                                   MainHeadline                            { get; set; }
        public string                                   SubHeadline                             { get; set; }
        public string                                   Summary                                 { get; set; }
        public bool                                     HasAdvInformation                       { get; set; }

        public static AdvSkipConfirmationPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdvSkipConfirmationPopupViewModel() { Pointer= p0 };

            value.MainHeadline                              = GetString(new IntPtr(p + 0x010)); // 024666987E00 0x10 MainHeadline                ( 000186672F10 ModelPrimitiveType string string string String )
            value.SubHeadline                               = GetString(new IntPtr(p + 0x018)); // 024666987E20 0x18 SubHeadline                 ( 000186672F10 ModelPrimitiveType string string string String )
            value.Summary                                   = GetString(new IntPtr(p + 0x020)); // 024666987E40 0x20 Summary                     ( 000186672F10 ModelPrimitiveType string string string String )
            value.HasAdvInformation                         = GetBool(new IntPtr(p + 0x028)); // 024666987E60 0x28 HasAdvInformation           ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
