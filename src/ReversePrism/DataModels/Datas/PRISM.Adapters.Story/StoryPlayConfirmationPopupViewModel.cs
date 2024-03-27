using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TotalDownloadSize                        000186666CB0 ModelPrimitiveType float float float Single
    // 014 TotalDownloadSizeWithoutVoice            000186666CB0 ModelPrimitiveType float float float Single
    // 018 NeedDownload                             0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class StoryPlayConfirmationPopupViewModel
    {
        public float                                    TotalDownloadSize                       { get; set; }
        public float                                    TotalDownloadSizeWithoutVoice           { get; set; }
        public bool                                     NeedDownload                            { get; set; }

        public static StoryPlayConfirmationPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryPlayConfirmationPopupViewModel();

            value.TotalDownloadSize                         = GetSingle(new IntPtr(p + 0x010)); // 0270D67DD4D0 0x10 TotalDownloadSize           ( 000186666CB0 ModelPrimitiveType float float float Single )
            value.TotalDownloadSizeWithoutVoice             = GetSingle(new IntPtr(p + 0x014)); // 0270D67DD4F0 0x14 TotalDownloadSizeWithoutVoice ( 000186666CB0 ModelPrimitiveType float float float Single )
            value.NeedDownload                              = GetBool(new IntPtr(p + 0x018)); // 0270D67DD510 0x18 NeedDownload                ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
