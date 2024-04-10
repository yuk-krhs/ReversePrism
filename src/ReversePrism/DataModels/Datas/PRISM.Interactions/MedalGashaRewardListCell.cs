using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 BoxNumberText                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 IconBase                                 0001865EC5C0 ModelClassType MedalGashaRewardIcon MedalGashaRewardIcon MedalGashaRewardIcon Pointer
    // 070 IconArea                                 0001866AA150 ModelClassType Transform Transform Transform Pointer
    public partial class MedalGashaRewardListCell : DataModel
    {
        public UITextMeshProUGUI?                       BoxNumberText                           { get; set; }
        public MedalGashaRewardIcon?                    IconBase                                { get; set; }
        public Transform?                               IconArea                                { get; set; }

        public static MedalGashaRewardListCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaRewardListCell() { Pointer= p0 };

            value.BoxNumberText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B9B3EA8 0x60 BoxNumberText               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.IconBase                                  = GetObject<MedalGashaRewardIcon>(new IntPtr(p + 0x068), ReversePrism.DataModels.MedalGashaRewardIcon.FromPointer); // 02466B9B3EC8 0x68 IconBase                    ( 0001865EC5C0 ModelClassType MedalGashaRewardIcon MedalGashaRewardIcon MedalGashaRewardIcon Pointer )
            value.IconArea                                  = GetObject<Transform>(new IntPtr(p + 0x070), ReversePrism.DataModels.Transform.FromPointer); // 02466B9B3EE8 0x70 IconArea                    ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
