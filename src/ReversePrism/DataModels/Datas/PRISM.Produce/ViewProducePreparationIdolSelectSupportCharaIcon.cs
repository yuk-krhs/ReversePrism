using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Icon                                     0001866ABAC0 ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer
    // 028 EmptyButton                              0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    public partial class ViewProducePreparationIdolSelectSupportCharaIcon
    {
        public SCharaIconView?                          Icon                                    { get; set; }
        public UIButton?                                EmptyButton                             { get; set; }

        public static ViewProducePreparationIdolSelectSupportCharaIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ViewProducePreparationIdolSelectSupportCharaIcon();

            value.Icon                                      = GetObject<SCharaIconView>(new IntPtr(p + 0x020), ReversePrism.DataModels.SCharaIconView.FromPointer); // 0270D5A66958 0x20 Icon                        ( 0001866ABAC0 ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer )
            value.EmptyButton                               = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5A66978 0x28 EmptyButton                 ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )

            return value;
        }
    }
}
