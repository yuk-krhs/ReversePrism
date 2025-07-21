using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CharaColorBg                             ModelClassType UIImage UIImage UIImage Pointer
    // 028 UiTabGroup                               ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 030 OnTabSelectedRP                          ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer
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

            value.CharaColorBg                              = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 0x20 CharaColorBg                ( ModelClassType UIImage UIImage UIImage Pointer )
            value.UiTabGroup                                = GetObject<UITabGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITabGroup.FromPointer); // 0x28 UiTabGroup                  ( ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.OnTabSelectedRP                           = GetObject<IntReactiveProperty>(new IntPtr(p + 0x030), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 0x30 OnTabSelectedRP             ( ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )

            return value;
        }
    }
}
