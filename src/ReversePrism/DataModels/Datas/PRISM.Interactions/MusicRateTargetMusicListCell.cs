using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 ListTitle                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 MusicJacketIcon                          0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 050 MusicBasicInfoView                       0001866630C0 ModelClassType MusicBasicInfoView MusicBasicInfoView MusicBasicInfoView Pointer
    // 058 HighScoreParent                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 HighScoreText                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 HighScoreRateText                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 TechnicalScoreParent                     0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 078 TechnicalScoreText                       0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 TechnicalRateText                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 Canceller                                000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    public partial class MusicRateTargetMusicListCell : DataModel
    {
        public UITextMeshProUGUI?                       ListTitle                               { get; set; }
        public UIRawImage?                              MusicJacketIcon                         { get; set; }
        public MusicBasicInfoView?                      MusicBasicInfoView                      { get; set; }
        public GameObject?                              HighScoreParent                         { get; set; }
        public UITextMeshProUGUI?                       HighScoreText                           { get; set; }
        public UITextMeshProUGUI?                       HighScoreRateText                       { get; set; }
        public GameObject?                              TechnicalScoreParent                    { get; set; }
        public UITextMeshProUGUI?                       TechnicalScoreText                      { get; set; }
        public UITextMeshProUGUI?                       TechnicalRateText                       { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }

        public static MusicRateTargetMusicListCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicRateTargetMusicListCell() { Pointer= p0 };

            value.ListTitle                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B473A18 0x40 ListTitle                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MusicJacketIcon                           = GetObject<UIRawImage>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIRawImage.FromPointer); // 02466B473A38 0x48 MusicJacketIcon             ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.MusicBasicInfoView                        = GetObject<MusicBasicInfoView>(new IntPtr(p + 0x050), ReversePrism.DataModels.MusicBasicInfoView.FromPointer); // 02466B473A58 0x50 MusicBasicInfoView          ( 0001866630C0 ModelClassType MusicBasicInfoView MusicBasicInfoView MusicBasicInfoView Pointer )
            value.HighScoreParent                           = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 02466B473A78 0x58 HighScoreParent             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.HighScoreText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B473A98 0x60 HighScoreText               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.HighScoreRateText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B473AB8 0x68 HighScoreRateText           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TechnicalScoreParent                      = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 02466B473AD8 0x70 TechnicalScoreParent        ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TechnicalScoreText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B473AF8 0x78 TechnicalScoreText          ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TechnicalRateText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B473B18 0x80 TechnicalRateText           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x088)); // 02466B473B38 0x88 Canceller                   ( 000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
