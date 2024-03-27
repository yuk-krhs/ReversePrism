using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ItemText                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 RewardItem                               00018667FAC0 ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer
    public partial class ReceiveRewardItem
    {
        public UITextMeshProUGUI?                       ItemText                                { get; set; }
        public RewardItemIcon?                          RewardItem                              { get; set; }

        public static ReceiveRewardItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReceiveRewardItem();

            value.ItemText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5976A38 0x20 ItemText                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RewardItem                                = GetObject<RewardItemIcon>(new IntPtr(p + 0x028), ReversePrism.DataModels.RewardItemIcon.FromPointer); // 0270D5976A58 0x28 RewardItem                  ( 00018667FAC0 ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer )

            return value;
        }
    }
}
