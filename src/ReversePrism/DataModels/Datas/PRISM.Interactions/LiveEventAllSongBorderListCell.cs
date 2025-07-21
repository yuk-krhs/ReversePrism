using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 068 GradeIcon                                ModelClassType LiveEventRankingGradeIcon LiveEventRankingGradeIcon LiveEventRankingGradeIcon Pointer
    // 070 DetailText                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 PointText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class LiveEventAllSongBorderListCell : DataModel
    {
        public LiveEventRankingGradeIcon?               GradeIcon                               { get; set; }
        public UITextMeshProUGUI?                       DetailText                              { get; set; }
        public UITextMeshProUGUI?                       PointText                               { get; set; }

        public static LiveEventAllSongBorderListCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventAllSongBorderListCell() { Pointer= p0 };

            value.GradeIcon                                 = GetObject<LiveEventRankingGradeIcon>(new IntPtr(p + 0x068), ReversePrism.DataModels.LiveEventRankingGradeIcon.FromPointer); // 0x68 GradeIcon                   ( ModelClassType LiveEventRankingGradeIcon LiveEventRankingGradeIcon LiveEventRankingGradeIcon Pointer )
            value.DetailText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x70 DetailText                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PointText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x78 PointText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
