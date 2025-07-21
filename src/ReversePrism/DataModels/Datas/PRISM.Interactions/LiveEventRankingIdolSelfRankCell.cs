using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 Icon                                     ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 038 PointText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 GradePyramid                             ModelClassType LiveEventRankingGradeIcon LiveEventRankingGradeIcon LiveEventRankingGradeIcon Pointer
    // 048 GradeIcon                                ModelClassType LiveEventRankingGradeIcon LiveEventRankingGradeIcon LiveEventRankingGradeIcon Pointer
    // 050 GradeDetailTexts                         ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 058 BaseImage                                ModelClassType LiveEventRankingGradeIcon LiveEventRankingGradeIcon LiveEventRankingGradeIcon Pointer
    // 060 CancellationTokenSource                  ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class LiveEventRankingIdolSelfRankCell : DataModel
    {
        public PFIdolIconView?                          Icon                                    { get; set; }
        public UITextMeshProUGUI?                       PointText                               { get; set; }
        public LiveEventRankingGradeIcon?               GradePyramid                            { get; set; }
        public LiveEventRankingGradeIcon?               GradeIcon                               { get; set; }
        public List<GameObject>?                        GradeDetailTexts                        { get; set; }
        public LiveEventRankingGradeIcon?               BaseImage                               { get; set; }
        public CancellationTokenSource?                 CancellationTokenSource                 { get; set; }

        public static LiveEventRankingIdolSelfRankCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventRankingIdolSelfRankCell() { Pointer= p0 };

            value.Icon                                      = GetObject<PFIdolIconView>(new IntPtr(p + 0x030), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0x30 Icon                        ( ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.PointText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 PointText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GradePyramid                              = GetObject<LiveEventRankingGradeIcon>(new IntPtr(p + 0x040), ReversePrism.DataModels.LiveEventRankingGradeIcon.FromPointer); // 0x40 GradePyramid                ( ModelClassType LiveEventRankingGradeIcon LiveEventRankingGradeIcon LiveEventRankingGradeIcon Pointer )
            value.GradeIcon                                 = GetObject<LiveEventRankingGradeIcon>(new IntPtr(p + 0x048), ReversePrism.DataModels.LiveEventRankingGradeIcon.FromPointer); // 0x48 GradeIcon                   ( ModelClassType LiveEventRankingGradeIcon LiveEventRankingGradeIcon LiveEventRankingGradeIcon Pointer )
            value.GradeDetailTexts                          = GetObjectList<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 GradeDetailTexts            ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.BaseImage                                 = GetObject<LiveEventRankingGradeIcon>(new IntPtr(p + 0x058), ReversePrism.DataModels.LiveEventRankingGradeIcon.FromPointer); // 0x58 BaseImage                   ( ModelClassType LiveEventRankingGradeIcon LiveEventRankingGradeIcon LiveEventRankingGradeIcon Pointer )
            value.CancellationTokenSource                   = GetObject<CancellationTokenSource>(new IntPtr(p + 0x060), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x60 CancellationTokenSource     ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
