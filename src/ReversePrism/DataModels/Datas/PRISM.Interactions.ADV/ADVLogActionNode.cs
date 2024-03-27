using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ActionContent                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 ViewModel                                000186663560 ModelClassType ADVLogActionNodeViewModel ADVLogActionNodeViewModel ADVLogActionNodeViewModel Pointer
    public partial class ADVLogActionNode
    {
        public UITextMeshProUGUI?                       ActionContent                           { get; set; }
        public ADVLogActionNodeViewModel?               ViewModel                               { get; set; }

        public static ADVLogActionNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ADVLogActionNode();

            value.ActionContent                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA1F7110 0x20 ActionContent               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ViewModel                                 = GetObject<ADVLogActionNodeViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.ADVLogActionNodeViewModel.FromPointer); // 0270DA1F7130 0x28 ViewModel                   ( 000186663560 ModelClassType ADVLogActionNodeViewModel ADVLogActionNodeViewModel ADVLogActionNodeViewModel Pointer )

            return value;
        }
    }
}
