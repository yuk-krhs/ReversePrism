using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsVoicePlayActive                        0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 011 NeedSkipConfirmationFromNextTime         0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 012 IsPopupCanceled                          0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class StoryPlayConfirmationPopupResult
    {
        public bool                                     IsVoicePlayActive                       { get; set; }
        public bool                                     NeedSkipConfirmationFromNextTime        { get; set; }
        public bool                                     IsPopupCanceled                         { get; set; }

        public static StoryPlayConfirmationPopupResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryPlayConfirmationPopupResult();

            value.IsVoicePlayActive                         = GetBool(new IntPtr(p + 0x010)); // 0270D67DD5A8 0x10 IsVoicePlayActive           ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.NeedSkipConfirmationFromNextTime          = GetBool(new IntPtr(p + 0x011)); // 0270D67DD5C8 0x11 NeedSkipConfirmationFromNextTime ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.IsPopupCanceled                           = GetBool(new IntPtr(p + 0x012)); // 0270D67DD5E8 0x12 IsPopupCanceled             ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
