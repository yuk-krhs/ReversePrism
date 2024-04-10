using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ProducePolicyButton                      0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 ProducePolicyImage                       0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 030 ProducePolicyTitleText                   0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 ProducePolicyDescriptionText             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class OneSchedulePolicyContent : DataModel
    {
        public UIButton?                                ProducePolicyButton                     { get; set; }
        public UIImage?                                 ProducePolicyImage                      { get; set; }
        public UITextMeshProUGUI?                       ProducePolicyTitleText                  { get; set; }
        public UITextMeshProUGUI?                       ProducePolicyDescriptionText            { get; set; }

        public static OneSchedulePolicyContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OneSchedulePolicyContent() { Pointer= p0 };

            value.ProducePolicyButton                       = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 024665D81910 0x20 ProducePolicyButton         ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ProducePolicyImage                        = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 024665D81930 0x28 ProducePolicyImage          ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.ProducePolicyTitleText                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665D81950 0x30 ProducePolicyTitleText      ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ProducePolicyDescriptionText              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665D81970 0x38 ProducePolicyDescriptionText ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
