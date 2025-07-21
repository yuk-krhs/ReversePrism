using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BalloonImage                             ModelClassType UIImage UIImage UIImage Pointer
    // 028 BalloonText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class ChainTalkCellBalloon : DataModel
    {
        public UIImage?                                 BalloonImage                            { get; set; }
        public UITextMeshProUGUI?                       BalloonText                             { get; set; }

        public static ChainTalkCellBalloon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkCellBalloon() { Pointer= p0 };

            value.BalloonImage                              = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 0x20 BalloonImage                ( ModelClassType UIImage UIImage UIImage Pointer )
            value.BalloonText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 BalloonText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
