using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BeforeStars                              00018656D580 ModelClassType StarDisplay StarDisplay StarDisplay Pointer
    // 028 AfterStars                               00018656D580 ModelClassType StarDisplay StarDisplay StarDisplay Pointer
    // 030 MaxStars                                 00018656D580 ModelClassType StarDisplay StarDisplay StarDisplay Pointer
    // 038 GoBeforeAfter                            0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 GoMax                                    0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 BtnUp                                    0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 050 BtnDown                                  0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 058 onUp                                     Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 060 onDown                                   Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class TrainingLvSelector : DataModel
    {
        public StarDisplay?                             BeforeStars                             { get; set; }
        public StarDisplay?                             AfterStars                              { get; set; }
        public StarDisplay?                             MaxStars                                { get; set; }
        public GameObject?                              GoBeforeAfter                           { get; set; }
        public GameObject?                              GoMax                                   { get; set; }
        public UIButton?                                BtnUp                                   { get; set; }
        public UIButton?                                BtnDown                                 { get; set; }

        public static TrainingLvSelector? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TrainingLvSelector() { Pointer= p0 };

            value.BeforeStars                               = GetObject<StarDisplay>(new IntPtr(p + 0x020), ReversePrism.DataModels.StarDisplay.FromPointer); // 02466A3C01D8 0x20 BeforeStars                 ( 00018656D580 ModelClassType StarDisplay StarDisplay StarDisplay Pointer )
            value.AfterStars                                = GetObject<StarDisplay>(new IntPtr(p + 0x028), ReversePrism.DataModels.StarDisplay.FromPointer); // 02466A3C01F8 0x28 AfterStars                  ( 00018656D580 ModelClassType StarDisplay StarDisplay StarDisplay Pointer )
            value.MaxStars                                  = GetObject<StarDisplay>(new IntPtr(p + 0x030), ReversePrism.DataModels.StarDisplay.FromPointer); // 02466A3C0218 0x30 MaxStars                    ( 00018656D580 ModelClassType StarDisplay StarDisplay StarDisplay Pointer )
            value.GoBeforeAfter                             = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 02466A3C0238 0x38 GoBeforeAfter               ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoMax                                     = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 02466A3C0258 0x40 GoMax                       ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.BtnUp                                     = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 02466A3C0278 0x48 BtnUp                       ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnDown                                   = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 02466A3C0298 0x50 BtnDown                     ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )

            return value;
        }
    }
}
