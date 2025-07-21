using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RankText                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 NextRankText                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 RankUpAnimator                           ModelClassType Animator Animator Animator Pointer
    // 038 SkipButton                               ModelClassType UIButton UIButton UIButton Pointer
    public partial class SeasonMissionRankUpStagingView : DataModel
    {
        public UITextMeshProUGUI?                       RankText                                { get; set; }
        public UITextMeshProUGUI?                       NextRankText                            { get; set; }
        public Animator?                                RankUpAnimator                          { get; set; }
        public UIButton?                                SkipButton                              { get; set; }

        public static SeasonMissionRankUpStagingView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SeasonMissionRankUpStagingView() { Pointer= p0 };

            value.RankText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 RankText                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NextRankText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 NextRankText                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RankUpAnimator                            = GetObject<Animator>(new IntPtr(p + 0x030), ReversePrism.DataModels.Animator.FromPointer); // 0x30 RankUpAnimator              ( ModelClassType Animator Animator Animator Pointer )
            value.SkipButton                                = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 SkipButton                  ( ModelClassType UIButton UIButton UIButton Pointer )

            return value;
        }
    }
}
