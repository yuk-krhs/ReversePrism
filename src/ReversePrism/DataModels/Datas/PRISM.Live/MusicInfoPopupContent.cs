using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 MusicName                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 JacketImage                              ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 070 PurchaseMusicButton                      ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 078 MusicCredits                             ModelClassType MusicCreditsView MusicCreditsView MusicCreditsView Pointer
    // 080 CreditInfoScrollRect                     ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    public partial class MusicInfoPopupContent : DataModel
    {
        public UITextMeshProUGUI?                       MusicName                               { get; set; }
        public UIRawImage?                              JacketImage                             { get; set; }
        public ButtonBase?                              PurchaseMusicButton                     { get; set; }
        public MusicCreditsView?                        MusicCredits                            { get; set; }
        public ScrollRect?                              CreditInfoScrollRect                    { get; set; }

        public static MusicInfoPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicInfoPopupContent() { Pointer= p0 };

            value.MusicName                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 MusicName                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.JacketImage                               = GetObject<UIRawImage>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x68 JacketImage                 ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.PurchaseMusicButton                       = GetObject<ButtonBase>(new IntPtr(p + 0x070), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x70 PurchaseMusicButton         ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.MusicCredits                              = GetObject<MusicCreditsView>(new IntPtr(p + 0x078), ReversePrism.DataModels.MusicCreditsView.FromPointer); // 0x78 MusicCredits                ( ModelClassType MusicCreditsView MusicCreditsView MusicCreditsView Pointer )
            value.CreditInfoScrollRect                      = GetObject<ScrollRect>(new IntPtr(p + 0x080), ReversePrism.DataModels.ScrollRect.FromPointer); // 0x80 CreditInfoScrollRect        ( ModelClassType ScrollRect ScrollRect ScrollRect Pointer )

            return value;
        }
    }
}
