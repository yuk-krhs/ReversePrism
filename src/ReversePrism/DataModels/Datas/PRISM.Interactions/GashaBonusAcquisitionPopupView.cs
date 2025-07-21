using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RewardItemPrefab                         ModelClassType RewardItem RewardItem RewardItem Pointer
    // 028 ItemParent                               ModelClassType Transform Transform Transform Pointer
    // 030 GridLayoutGroup                          ModelClassType GridLayoutGroup GridLayoutGroup GridLayoutGroup Pointer
    // 038 IconTapInfoText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 048 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class GashaBonusAcquisitionPopupView : DataModel
    {
        public RewardItem?                              RewardItemPrefab                        { get; set; }
        public Transform?                               ItemParent                              { get; set; }
        public GridLayoutGroup?                         GridLayoutGroup                         { get; set; }
        public UITextMeshProUGUI?                       IconTapInfoText                         { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static GashaBonusAcquisitionPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaBonusAcquisitionPopupView() { Pointer= p0 };

            value.RewardItemPrefab                          = GetObject<RewardItem>(new IntPtr(p + 0x020), ReversePrism.DataModels.RewardItem.FromPointer); // 0x20 RewardItemPrefab            ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.ItemParent                                = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0x28 ItemParent                  ( ModelClassType Transform Transform Transform Pointer )
            value.GridLayoutGroup                           = GetObject<GridLayoutGroup>(new IntPtr(p + 0x030), ReversePrism.DataModels.GridLayoutGroup.FromPointer); // 0x30 GridLayoutGroup             ( ModelClassType GridLayoutGroup GridLayoutGroup GridLayoutGroup Pointer )
            value.IconTapInfoText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 IconTapInfoText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x48 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
