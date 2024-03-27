using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RewardArea                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 RewardIcon                               0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 030 RewardText                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 BlankUI                                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class RewardContent
    {
        public GameObject?                              RewardArea                              { get; set; }
        public UIRawImage?                              RewardIcon                              { get; set; }
        public UITextMeshProUGUI?                       RewardText                              { get; set; }
        public GameObject?                              BlankUI                                 { get; set; }

        public static RewardContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RewardContent();

            value.RewardArea                                = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5D30040 0x20 RewardArea                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.RewardIcon                                = GetObject<UIRawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270D5D30060 0x28 RewardIcon                  ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.RewardText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5D30080 0x30 RewardText                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BlankUI                                   = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5D300A0 0x38 BlankUI                     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
