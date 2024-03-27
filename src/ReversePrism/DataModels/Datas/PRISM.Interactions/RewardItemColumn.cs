using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RewardItem                               00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 028 CgRewardItem                             000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 030 ImgReward                                0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 038 CgReward                                 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 040 TxtReward                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class RewardItemColumn
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
            var value   = new RewardItemColumn();

            value.RewardItem                                = GetObject<RewardItem>(new IntPtr(p + 0x020), ReversePrism.DataModels.RewardItem.FromPointer); // 0270DA318D00 0x20 RewardItem                  ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.CgRewardItem                              = GetObject<CanvasGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270DA318D20 0x28 CgRewardItem                ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ImgReward                                 = GetObject<UIRawImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270DA318D40 0x30 ImgReward                   ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.CgReward                                  = GetObject<CanvasGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270DA318D60 0x38 CgReward                    ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TxtReward                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA318D80 0x40 TxtReward                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
