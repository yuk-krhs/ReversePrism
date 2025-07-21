using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RewardImage                              ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 028 RewardText                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 HorizontalPartitionImageObject           ModelClassType GameObject GameObject GameObject Pointer
    // 038 EmptyImageObject                         ModelClassType GameObject GameObject GameObject Pointer
    public partial class ScheduleRewardContent : DataModel
    {
        public UIRawImage?                              RewardImage                             { get; set; }
        public UITextMeshProUGUI?                       RewardText                              { get; set; }
        public GameObject?                              HorizontalPartitionImageObject          { get; set; }
        public GameObject?                              EmptyImageObject                        { get; set; }

        public static ScheduleRewardContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleRewardContent() { Pointer= p0 };

            value.RewardImage                               = GetObject<UIRawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x20 RewardImage                 ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.RewardText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 RewardText                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.HorizontalPartitionImageObject            = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 HorizontalPartitionImageObject ( ModelClassType GameObject GameObject GameObject Pointer )
            value.EmptyImageObject                          = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 EmptyImageObject            ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
