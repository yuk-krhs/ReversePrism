using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 SeasonImage                              000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 048 ExpiryDate                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 AchieveRank                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 PassImage                                000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 060 Canceller                                000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    public partial class ProfileSeasonArchiveListViewCell : DataModel
    {
        public RawImage?                                SeasonImage                             { get; set; }
        public UITextMeshProUGUI?                       ExpiryDate                              { get; set; }
        public UITextMeshProUGUI?                       AchieveRank                             { get; set; }
        public RawImage?                                PassImage                               { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }

        public static ProfileSeasonArchiveListViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileSeasonArchiveListViewCell() { Pointer= p0 };

            value.SeasonImage                               = GetObject<RawImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.RawImage.FromPointer); // 02466B77B708 0x40 SeasonImage                 ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.ExpiryDate                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B77B728 0x48 ExpiryDate                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AchieveRank                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B77B748 0x50 AchieveRank                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PassImage                                 = GetObject<RawImage>(new IntPtr(p + 0x058), ReversePrism.DataModels.RawImage.FromPointer); // 02466B77B768 0x58 PassImage                   ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x060)); // 02466B77B788 0x60 Canceller                   ( 000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
