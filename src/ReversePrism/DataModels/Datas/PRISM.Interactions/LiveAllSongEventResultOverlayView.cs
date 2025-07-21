using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PointRankingText                         ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 028 HighScoreRankingText                     ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 030 IdolCellBase                             ModelClassType LiveAllSongEventResultIdolCell LiveAllSongEventResultIdolCell LiveAllSongEventResultIdolCell Pointer
    // 038 PresentText                              ModelClassType GameObject GameObject GameObject Pointer
    // 040 CloseButton                              ModelClassType UIButton UIButton UIButton Pointer
    // 048 BackKeyDisposable                        ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class LiveAllSongEventResultOverlayView : DataModel
    {
        public TextMeshProUGUI?                         PointRankingText                        { get; set; }
        public TextMeshProUGUI?                         HighScoreRankingText                    { get; set; }
        public LiveAllSongEventResultIdolCell?          IdolCellBase                            { get; set; }
        public GameObject?                              PresentText                             { get; set; }
        public UIButton?                                CloseButton                             { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }

        public static LiveAllSongEventResultOverlayView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveAllSongEventResultOverlayView() { Pointer= p0 };

            value.PointRankingText                          = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x20 PointRankingText            ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.HighScoreRankingText                      = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x28 HighScoreRankingText        ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.IdolCellBase                              = GetObject<LiveAllSongEventResultIdolCell>(new IntPtr(p + 0x030), ReversePrism.DataModels.LiveAllSongEventResultIdolCell.FromPointer); // 0x30 IdolCellBase                ( ModelClassType LiveAllSongEventResultIdolCell LiveAllSongEventResultIdolCell LiveAllSongEventResultIdolCell Pointer )
            value.PresentText                               = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 PresentText                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CloseButton                               = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0x40 CloseButton                 ( ModelClassType UIButton UIButton UIButton Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x048), ReversePrism.DataModels.IDisposable.FromPointer); // 0x48 BackKeyDisposable           ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
