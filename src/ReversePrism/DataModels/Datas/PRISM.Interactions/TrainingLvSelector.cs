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
    public partial class TrainingLvSelector
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
            var value   = new TrainingLvSelector();

            value.BeforeStars                               = GetObject<StarDisplay>(new IntPtr(p + 0x020), ReversePrism.DataModels.StarDisplay.FromPointer); // 0270DA34D2F0 0x20 BeforeStars                 ( 00018656D580 ModelClassType StarDisplay StarDisplay StarDisplay Pointer )
            value.AfterStars                                = GetObject<StarDisplay>(new IntPtr(p + 0x028), ReversePrism.DataModels.StarDisplay.FromPointer); // 0270DA34D310 0x28 AfterStars                  ( 00018656D580 ModelClassType StarDisplay StarDisplay StarDisplay Pointer )
            value.MaxStars                                  = GetObject<StarDisplay>(new IntPtr(p + 0x030), ReversePrism.DataModels.StarDisplay.FromPointer); // 0270DA34D330 0x30 MaxStars                    ( 00018656D580 ModelClassType StarDisplay StarDisplay StarDisplay Pointer )
            value.GoBeforeAfter                             = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA34D350 0x38 GoBeforeAfter               ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoMax                                     = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA34D370 0x40 GoMax                       ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.BtnUp                                     = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA34D390 0x48 BtnUp                       ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnDown                                   = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA34D3B0 0x50 BtnDown                     ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )

            return value;
        }
    }
}
