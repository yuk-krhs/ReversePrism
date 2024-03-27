using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GridView                                 0001867366B0 ModelClassType EnhancedUnitSelectGridView EnhancedUnitSelectGridView EnhancedUnitSelectGridView Pointer
    // 028 Amounts                                  000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 030 onClick                                  Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 038 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class FesUnitTransferConfirmedPopupView
    {
        public EnhancedUnitSelectGridView?              GridView                                { get; set; }
        public List<UITextMeshProUGUI>?                 Amounts                                 { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static FesUnitTransferConfirmedPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FesUnitTransferConfirmedPopupView();

            value.GridView                                  = GetObject<EnhancedUnitSelectGridView>(new IntPtr(p + 0x020), ReversePrism.DataModels.EnhancedUnitSelectGridView.FromPointer); // 0270DA2ADAE8 0x20 GridView                    ( 0001867366B0 ModelClassType EnhancedUnitSelectGridView EnhancedUnitSelectGridView EnhancedUnitSelectGridView Pointer )
            value.Amounts                                   = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA2ADB08 0x28 Amounts                     ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DA2ADB48 0x38 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
