using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 BoxNumberText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 IconBase                                 ModelClassType MedalGashaRewardIcon MedalGashaRewardIcon MedalGashaRewardIcon Pointer
    // 070 IconArea                                 ModelClassType Transform Transform Transform Pointer
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

            value.BoxNumberText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 BoxNumberText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.IconBase                                  = GetObject<MedalGashaRewardIcon>(new IntPtr(p + 0x068), ReversePrism.DataModels.MedalGashaRewardIcon.FromPointer); // 0x68 IconBase                    ( ModelClassType MedalGashaRewardIcon MedalGashaRewardIcon MedalGashaRewardIcon Pointer )
            value.IconArea                                  = GetObject<Transform>(new IntPtr(p + 0x070), ReversePrism.DataModels.Transform.FromPointer); // 0x70 IconArea                    ( ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
