using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Txt                                      ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 RewardParent                             ModelClassType Transform Transform Transform Pointer
    // 030 ItemIconPrefab                           ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer
    // 038 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 040 Title                                    ModelPrimitiveType string string string String
    // 048 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class FesDataTransferCompletedPopupView : DataModel
    {
        public UITextMeshProUGUI?                       Txt                                     { get; set; }
        public Transform?                               RewardParent                            { get; set; }
        public RewardItemIcon?                          ItemIconPrefab                          { get; set; }
        public string                                   Title                                   { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static FesDataTransferCompletedPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FesDataTransferCompletedPopupView() { Pointer= p0 };

            value.Txt                                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 Txt                         ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RewardParent                              = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0x28 RewardParent                ( ModelClassType Transform Transform Transform Pointer )
            value.ItemIconPrefab                            = GetObject<RewardItemIcon>(new IntPtr(p + 0x030), ReversePrism.DataModels.RewardItemIcon.FromPointer); // 0x30 ItemIconPrefab              ( ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer )
            value.Title                                     = GetString(new IntPtr(p + 0x040)); // 0x40 Title                       ( ModelPrimitiveType string string string String )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x48 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
