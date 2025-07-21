using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RewardItem                               ModelClassType RewardItem RewardItem RewardItem Pointer
    // 028 CgRewardItem                             ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 030 ImgReward                                ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 038 CgReward                                 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 040 TxtReward                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class RewardItemColumn : DataModel
    {
        public RewardItem?                              RewardItem                              { get; set; }
        public CanvasGroup?                             CgRewardItem                            { get; set; }
        public UIRawImage?                              ImgReward                               { get; set; }
        public CanvasGroup?                             CgReward                                { get; set; }
        public UITextMeshProUGUI?                       TxtReward                               { get; set; }

        public static RewardItemColumn? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RewardItemColumn() { Pointer= p0 };

            value.RewardItem                                = GetObject<RewardItem>(new IntPtr(p + 0x020), ReversePrism.DataModels.RewardItem.FromPointer); // 0x20 RewardItem                  ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.CgRewardItem                              = GetObject<CanvasGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x28 CgRewardItem                ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ImgReward                                 = GetObject<UIRawImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x30 ImgReward                   ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.CgReward                                  = GetObject<CanvasGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x38 CgReward                    ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TxtReward                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 TxtReward                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
