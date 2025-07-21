using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Icon                                     ModelClassType RawImage RawImage RawImage Pointer
    // 028 SpecialIcons                             ModelEnumListType SpecialIcon[] SpecialIcon[] List<SpecialIcon> Pointer
    // 030 AmountText                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class GashaHistoryProductLabelView : DataModel
    {
        public RawImage?                                Icon                                    { get; set; }
        public List<SpecialIcon>?                       SpecialIcons                            { get; set; }
        public UITextMeshProUGUI?                       AmountText                              { get; set; }

        public static GashaHistoryProductLabelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaHistoryProductLabelView() { Pointer= p0 };

            value.Icon                                      = GetObject<RawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.RawImage.FromPointer); // 0x20 Icon                        ( ModelClassType RawImage RawImage RawImage Pointer )
            value.SpecialIcons                              = GetEnumList<SpecialIcon>(new IntPtr(p + 0x028)); // 0x28 SpecialIcons                ( ModelEnumListType SpecialIcon[] SpecialIcon[] List<SpecialIcon> Pointer )
            value.AmountText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 AmountText                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
