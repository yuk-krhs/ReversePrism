using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 LogoImage                                000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 028 Gauge                                    0001866CCDB0 ModelClassType Image Image Image Pointer
    // 030 NextRankExpText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 RankText                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 AutoCancellation                         000186724700 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    public partial class SeasonMissionRankView
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
            var value   = new SeasonMissionRankView();

            value.LogoImage                                 = GetObject<RawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.RawImage.FromPointer); // 0270DBD24158 0x20 LogoImage                   ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.Gauge                                     = GetObject<Image>(new IntPtr(p + 0x028), ReversePrism.DataModels.Image.FromPointer); // 0270DBD24178 0x28 Gauge                       ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.NextRankExpText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBD24198 0x30 NextRankExpText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RankText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBD241B8 0x38 RankText                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AutoCancellation                          = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x040)); // 0270DBD241D8 0x40 AutoCancellation            ( 000186724700 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
