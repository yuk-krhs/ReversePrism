using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 LogoImage                                ModelClassType RawImage RawImage RawImage Pointer
    // 028 Gauge                                    ModelClassType Image Image Image Pointer
    // 030 NextRankExpText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 RankText                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 AutoCancellation                         ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    public partial class SeasonMissionRankView : DataModel
    {
        public RawImage?                                LogoImage                               { get; set; }
        public Image?                                   Gauge                                   { get; set; }
        public UITextMeshProUGUI?                       NextRankExpText                         { get; set; }
        public UITextMeshProUGUI?                       RankText                                { get; set; }
        public AutoCancellationTokenSource              AutoCancellation                        { get; set; }

        public static SeasonMissionRankView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SeasonMissionRankView() { Pointer= p0 };

            value.LogoImage                                 = GetObject<RawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.RawImage.FromPointer); // 0x20 LogoImage                   ( ModelClassType RawImage RawImage RawImage Pointer )
            value.Gauge                                     = GetObject<Image>(new IntPtr(p + 0x028), ReversePrism.DataModels.Image.FromPointer); // 0x28 Gauge                       ( ModelClassType Image Image Image Pointer )
            value.NextRankExpText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 NextRankExpText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RankText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 RankText                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AutoCancellation                          = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x040)); // 0x40 AutoCancellation            ( ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
