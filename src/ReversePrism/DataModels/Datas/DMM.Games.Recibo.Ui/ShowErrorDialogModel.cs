using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Message                                  000186671910 ModelPrimitiveType string string string String
    // 018 OnClickCloseButton                       000186711D50 ModelClassType UnityAction UnityAction UnityAction Pointer
    // 020 OnClickInquiryButton                     000186711D50 ModelClassType UnityAction UnityAction UnityAction Pointer
    // 028 SortingOrder                             0001865F4260 ModelPrimitiveType int int int Int32
    // 030 LogoImage                                00018666B610 ModelClassType Sprite Sprite Sprite Pointer
    public partial class ShowErrorDialogModel : DataModel
    {
        public string                                   Message                                 { get; set; }
        public UnityAction?                             OnClickCloseButton                      { get; set; }
        public UnityAction?                             OnClickInquiryButton                    { get; set; }
        public int                                      SortingOrder                            { get; set; }
        public Sprite?                                  LogoImage                               { get; set; }

        public static ShowErrorDialogModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShowErrorDialogModel() { Pointer= p0 };

            value.Message                                   = GetString(new IntPtr(p + 0x010)); // 02466B4EB0C8 0x10 Message                     ( 000186671910 ModelPrimitiveType string string string String )
            value.OnClickCloseButton                        = GetObject<UnityAction>(new IntPtr(p + 0x018), ReversePrism.DataModels.UnityAction.FromPointer); // 02466B4EB0E8 0x18 OnClickCloseButton          ( 000186711D50 ModelClassType UnityAction UnityAction UnityAction Pointer )
            value.OnClickInquiryButton                      = GetObject<UnityAction>(new IntPtr(p + 0x020), ReversePrism.DataModels.UnityAction.FromPointer); // 02466B4EB108 0x20 OnClickInquiryButton        ( 000186711D50 ModelClassType UnityAction UnityAction UnityAction Pointer )
            value.SortingOrder                              = GetInt32(new IntPtr(p + 0x028)); // 02466B4EB128 0x28 SortingOrder                ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.LogoImage                                 = GetObject<Sprite>(new IntPtr(p + 0x030), ReversePrism.DataModels.Sprite.FromPointer); // 02466B4EB148 0x30 LogoImage                   ( 00018666B610 ModelClassType Sprite Sprite Sprite Pointer )

            return value;
        }
    }
}
