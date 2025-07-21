using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RewardArea                               ModelClassType GameObject GameObject GameObject Pointer
    // 028 RewardIcon                               ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 030 RewardText                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 BlankUI                                  ModelClassType GameObject GameObject GameObject Pointer
    public partial class RewardContent : DataModel
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
            var value   = new RewardContent() { Pointer= p0 };

            value.RewardArea                                = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 RewardArea                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.RewardIcon                                = GetObject<UIRawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x28 RewardIcon                  ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.RewardText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 RewardText                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BlankUI                                   = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 BlankUI                     ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
