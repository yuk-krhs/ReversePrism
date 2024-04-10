using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BeforeDiamond                            0001866CF8A0 ModelClassType DiamondDisplay DiamondDisplay DiamondDisplay Pointer
    // 028 AfterDiamond                             0001866CF8A0 ModelClassType DiamondDisplay DiamondDisplay DiamondDisplay Pointer
    // 030 MaxDiamond                               0001866CF8A0 ModelClassType DiamondDisplay DiamondDisplay DiamondDisplay Pointer
    // 038 GoBeforeAfter                            0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 GoMax                                    0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 BtnUp                                    0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 050 BtnDown                                  0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 058 onUp                                     Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 060 onDown                                   Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class DiamondLvSelector : DataModel
    {
        public DiamondDisplay?                          BeforeDiamond                           { get; set; }
        public DiamondDisplay?                          AfterDiamond                            { get; set; }
        public DiamondDisplay?                          MaxDiamond                              { get; set; }
        public GameObject?                              GoBeforeAfter                           { get; set; }
        public GameObject?                              GoMax                                   { get; set; }
        public UIButton?                                BtnUp                                   { get; set; }
        public UIButton?                                BtnDown                                 { get; set; }

        public static DiamondLvSelector? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DiamondLvSelector() { Pointer= p0 };

            value.BeforeDiamond                             = GetObject<DiamondDisplay>(new IntPtr(p + 0x020), ReversePrism.DataModels.DiamondDisplay.FromPointer); // 02466A3C4B90 0x20 BeforeDiamond               ( 0001866CF8A0 ModelClassType DiamondDisplay DiamondDisplay DiamondDisplay Pointer )
            value.AfterDiamond                              = GetObject<DiamondDisplay>(new IntPtr(p + 0x028), ReversePrism.DataModels.DiamondDisplay.FromPointer); // 02466A3C4BB0 0x28 AfterDiamond                ( 0001866CF8A0 ModelClassType DiamondDisplay DiamondDisplay DiamondDisplay Pointer )
            value.MaxDiamond                                = GetObject<DiamondDisplay>(new IntPtr(p + 0x030), ReversePrism.DataModels.DiamondDisplay.FromPointer); // 02466A3C4BD0 0x30 MaxDiamond                  ( 0001866CF8A0 ModelClassType DiamondDisplay DiamondDisplay DiamondDisplay Pointer )
            value.GoBeforeAfter                             = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 02466A3C4BF0 0x38 GoBeforeAfter               ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoMax                                     = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 02466A3C4C10 0x40 GoMax                       ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.BtnUp                                     = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 02466A3C4C30 0x48 BtnUp                       ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnDown                                   = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 02466A3C4C50 0x50 BtnDown                     ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )

            return value;
        }
    }
}
