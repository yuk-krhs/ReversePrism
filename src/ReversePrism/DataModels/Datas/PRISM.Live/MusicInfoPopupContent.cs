using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 MusicName                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 JacketImage                              0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 070 PurchaseMusicButton                      000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 078 MusicCredits                             0001866647E0 ModelClassType MusicCreditsView MusicCreditsView MusicCreditsView Pointer
    // 080 CreditInfoScrollRect                     0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer
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

            value.MusicName                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466523EA20 0x60 MusicName                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.JacketImage                               = GetObject<UIRawImage>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIRawImage.FromPointer); // 02466523EA40 0x68 JacketImage                 ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.PurchaseMusicButton                       = GetObject<ButtonBase>(new IntPtr(p + 0x070), ReversePrism.DataModels.ButtonBase.FromPointer); // 02466523EA60 0x70 PurchaseMusicButton         ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.MusicCredits                              = GetObject<MusicCreditsView>(new IntPtr(p + 0x078), ReversePrism.DataModels.MusicCreditsView.FromPointer); // 02466523EA80 0x78 MusicCredits                ( 0001866647E0 ModelClassType MusicCreditsView MusicCreditsView MusicCreditsView Pointer )
            value.CreditInfoScrollRect                      = GetObject<ScrollRect>(new IntPtr(p + 0x080), ReversePrism.DataModels.ScrollRect.FromPointer); // 02466523EAA0 0x80 CreditInfoScrollRect        ( 0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer )

            return value;
        }
    }
}
