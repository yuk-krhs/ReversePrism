using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Icon                                     000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 028 SpecialIcons                             000185CBAE08 ModelEnumListType SpecialIcon[] SpecialIcon[] List<SpecialIcon> Pointer
    // 030 AmountText                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class GashaHistoryProductLabel
    {
        public RawImage?                                Icon                                    { get; set; }
        public List<SpecialIcon>?                       SpecialIcons                            { get; set; }
        public UITextMeshProUGUI?                       AmountText                              { get; set; }

        public static GashaHistoryProductLabel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaHistoryProductLabel();

            value.Icon                                      = GetObject<RawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.RawImage.FromPointer); // 0270D5306B98 0x20 Icon                        ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.SpecialIcons                              = GetEnumList<SpecialIcon>(new IntPtr(p + 0x028)); // 0270D5306BB8 0x28 SpecialIcons                ( 000185CBAE08 ModelEnumListType SpecialIcon[] SpecialIcon[] List<SpecialIcon> Pointer )
            value.AmountText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5306BD8 0x30 AmountText                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
