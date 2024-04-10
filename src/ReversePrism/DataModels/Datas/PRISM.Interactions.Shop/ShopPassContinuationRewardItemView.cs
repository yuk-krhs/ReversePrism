using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RewardItem                               00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 028 ContinuationCountText                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 NextRewardBalloonObj                     0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 NextRewardBalloonText                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 NextRewardLight                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 NextRewardLightFrame                     0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class ShopPassContinuationRewardItemView : DataModel
    {
        public RewardItem?                              RewardItem                              { get; set; }
        public UITextMeshProUGUI?                       ContinuationCountText                   { get; set; }
        public GameObject?                              NextRewardBalloonObj                    { get; set; }
        public UITextMeshProUGUI?                       NextRewardBalloonText                   { get; set; }
        public GameObject?                              NextRewardLight                         { get; set; }
        public GameObject?                              NextRewardLightFrame                    { get; set; }

        public static ShopPassContinuationRewardItemView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopPassContinuationRewardItemView() { Pointer= p0 };

            value.RewardItem                                = GetObject<RewardItem>(new IntPtr(p + 0x020), ReversePrism.DataModels.RewardItem.FromPointer); // 02466B890478 0x20 RewardItem                  ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.ContinuationCountText                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B890498 0x28 ContinuationCountText       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NextRewardBalloonObj                      = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 02466B8904B8 0x30 NextRewardBalloonObj        ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.NextRewardBalloonText                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B8904D8 0x38 NextRewardBalloonText       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NextRewardLight                           = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 02466B8904F8 0x40 NextRewardLight             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.NextRewardLightFrame                      = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 02466B890518 0x48 NextRewardLightFrame        ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
