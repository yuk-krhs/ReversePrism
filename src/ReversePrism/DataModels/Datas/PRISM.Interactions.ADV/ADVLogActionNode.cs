using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ActionContent                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 ViewModel                                ModelClassType ADVLogActionNodeViewModel ADVLogActionNodeViewModel ADVLogActionNodeViewModel Pointer
    public partial class ADVLogActionNode : DataModel
    {
        public UITextMeshProUGUI?                       ActionContent                           { get; set; }
        public ADVLogActionNodeViewModel?               ViewModel                               { get; set; }

        public static ADVLogActionNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ADVLogActionNode() { Pointer= p0 };

            value.ActionContent                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 ActionContent               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ViewModel                                 = GetObject<ADVLogActionNodeViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.ADVLogActionNodeViewModel.FromPointer); // 0x28 ViewModel                   ( ModelClassType ADVLogActionNodeViewModel ADVLogActionNodeViewModel ADVLogActionNodeViewModel Pointer )

            return value;
        }
    }
}
