using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BalloonImage                             0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 028 BalloonText                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class ChainTalkCellBalloon
    {
        public UIImage?                                 BalloonImage                            { get; set; }
        public UITextMeshProUGUI?                       BalloonText                             { get; set; }

        public static ChainTalkCellBalloon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkCellBalloon();

            value.BalloonImage                              = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 0270DB0E50A8 0x20 BalloonImage                ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.BalloonText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB0E50C8 0x28 BalloonText                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
