using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BackgroundImage                          0001866EFB70 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 028 ChangeMemberButton                       0001866E11C0 ModelClassType UIButton UIButton UIButton Pointer
    // 030 ChangeMemberButtonGrayOutController      0001866EA6A0 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    public partial class LiveUnitMemberChangeViewBase
    {
        public UIRawImage?                              BackgroundImage                         { get; set; }
        public UIButton?                                ChangeMemberButton                      { get; set; }
        public UIGrayOutController?                     ChangeMemberButtonGrayOutController     { get; set; }

        public static LiveUnitMemberChangeViewBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitMemberChangeViewBase();

            value.BackgroundImage                           = GetObject<UIRawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270D5113FE8 0x20 BackgroundImage             ( 0001866EFB70 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.ChangeMemberButton                        = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5114008 0x28 ChangeMemberButton          ( 0001866E11C0 ModelClassType UIButton UIButton UIButton Pointer )
            value.ChangeMemberButtonGrayOutController       = GetObject<UIGrayOutController>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0270D5114028 0x30 ChangeMemberButtonGrayOutController ( 0001866EA6A0 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )

            return value;
        }
    }
}
