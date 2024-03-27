using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Txt                                      0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 RewardParent                             0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 030 ItemIconPrefab                           00018667FAC0 ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer
    // 038 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 040 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 048 Title                                    000186671910 ModelPrimitiveType string string string String
    // 050 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class FesDataTransferCompletedPopupView
    {
        public UITextMeshProUGUI?                       Txt                                     { get; set; }
        public Transform?                               RewardParent                            { get; set; }
        public RewardItemIcon?                          ItemIconPrefab                          { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }
        public string                                   Title                                   { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static FesDataTransferCompletedPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FesDataTransferCompletedPopupView();

            value.Txt                                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA2AB258 0x20 Txt                         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RewardParent                              = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0270DA2AB278 0x28 RewardParent                ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.ItemIconPrefab                            = GetObject<RewardItemIcon>(new IntPtr(p + 0x030), ReversePrism.DataModels.RewardItemIcon.FromPointer); // 0270DA2AB298 0x30 ItemIconPrefab              ( 00018667FAC0 ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x040), ReversePrism.DataModels.IResourceTag.FromPointer); // 0270DA2AB2D8 0x40 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )
            value.Title                                     = GetString(new IntPtr(p + 0x048)); // 0270DA2AB2F8 0x48 Title                       ( 000186671910 ModelPrimitiveType string string string String )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x050), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DA2AB318 0x50 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
