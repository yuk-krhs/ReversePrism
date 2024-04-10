using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CharaColorBg                             0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 028 UiTabGroup                               0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 030 characterGetEffectOverlayFactory         OverlayViewFactory`1<ICharacterGetEffectOverlayView> IL2CPP_TYPE_GENERICINST
    // 038 OnTabSelectedRP                          000186714660 ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer
    public partial class IdolBaseDetailView : DataModel
    {
        public UIImage?                                 CharaColorBg                            { get; set; }
        public UITabGroup?                              UiTabGroup                              { get; set; }
        public IntReactiveProperty?                     OnTabSelectedRP                         { get; set; }

        public static IdolBaseDetailView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolBaseDetailView() { Pointer= p0 };

            value.CharaColorBg                              = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 02466A2C11C8 0x20 CharaColorBg                ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.UiTabGroup                                = GetObject<UITabGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITabGroup.FromPointer); // 02466A2C11E8 0x28 UiTabGroup                  ( 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.OnTabSelectedRP                           = GetObject<IntReactiveProperty>(new IntPtr(p + 0x038), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 02466A2C1228 0x38 OnTabSelectedRP             ( 000186714660 ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )

            return value;
        }
    }
}
