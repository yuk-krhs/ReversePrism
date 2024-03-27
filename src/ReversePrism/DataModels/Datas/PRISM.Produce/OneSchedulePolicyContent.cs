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
    public partial class OneSchedulePolicyContent
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
            var value   = new OneSchedulePolicyContent();

            value.ProducePolicyButton                       = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5D203D0 0x20 ProducePolicyButton         ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ProducePolicyImage                        = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 0270D5D203F0 0x28 ProducePolicyImage          ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.ProducePolicyTitleText                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5D20410 0x30 ProducePolicyTitleText      ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ProducePolicyDescriptionText              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5D20430 0x38 ProducePolicyDescriptionText ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
