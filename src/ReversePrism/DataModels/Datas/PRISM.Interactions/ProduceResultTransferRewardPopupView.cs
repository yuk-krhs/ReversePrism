using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RewardParent                             0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 028 ItemIconPrefab                           00018667FAC0 ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer
    // 030 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 038 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProduceResultTransferRewardPopupView : DataModel
    {
        public Transform?                               RewardParent                            { get; set; }
        public RewardItemIcon?                          ItemIconPrefab                          { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ProduceResultTransferRewardPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceResultTransferRewardPopupView() { Pointer= p0 };

            value.RewardParent                              = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 02466A143290 0x20 RewardParent                ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.ItemIconPrefab                            = GetObject<RewardItemIcon>(new IntPtr(p + 0x028), ReversePrism.DataModels.RewardItemIcon.FromPointer); // 02466A1432B0 0x28 ItemIconPrefab              ( 00018667FAC0 ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466A1432F0 0x38 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
