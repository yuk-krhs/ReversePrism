using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RawImage                                 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 028 CostText                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class TrainerSkillIconView : DataModel
    {
        public UIRawImage?                              RawImage                                { get; set; }
        public UITextMeshProUGUI?                       CostText                                { get; set; }

        public static TrainerSkillIconView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TrainerSkillIconView() { Pointer= p0 };

            value.RawImage                                  = GetObject<UIRawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x20 RawImage                    ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.CostText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 CostText                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
