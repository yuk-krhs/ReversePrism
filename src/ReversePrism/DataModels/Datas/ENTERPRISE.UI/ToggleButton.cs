using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 1E0 IsOn                                     000186595480 ModelPrimitiveType bool bool bool Bool
    // 1E1 IsHandledByGroup                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 1E8 SubscribedOnClick                        0001866792B0 ModelClassType Action Action Action Pointer
    // 1F0 statusChangeSubject                      Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 1F8 SpriteOn                                 00018666B610 ModelClassType Sprite Sprite Sprite Pointer
    // 200 SpriteColorOn                            0001865AA8E0 ModelEnumType Color Color Color Int32
    // 210 TextColorOn                              0001865AA8E0 ModelEnumType Color Color Color Int32
    // 220 SpriteOff                                00018666B610 ModelClassType Sprite Sprite Sprite Pointer
    // 228 SpriteColorOff                           0001865AA8E0 ModelEnumType Color Color Color Int32
    // 238 TextColorOff                             0001865AA8E0 ModelEnumType Color Color Color Int32
    public partial class ToggleButton
    {
        public bool                                     IsOn                                    { get; set; }
        public bool                                     IsHandledByGroup                        { get; set; }
        public Action?                                  SubscribedOnClick                       { get; set; }
        public Sprite?                                  SpriteOn                                { get; set; }
        public Color                                    SpriteColorOn                           { get; set; }
        public Color                                    TextColorOn                             { get; set; }
        public Sprite?                                  SpriteOff                               { get; set; }
        public Color                                    SpriteColorOff                          { get; set; }
        public Color                                    TextColorOff                            { get; set; }

        public static ToggleButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ToggleButton();

            value.IsOn                                      = GetBool(new IntPtr(p + 0x1E0)); // 0270D4C09158 0x1E0 IsOn                        ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.IsHandledByGroup                          = GetBool(new IntPtr(p + 0x1E1)); // 0270D4C09178 0x1E1 IsHandledByGroup            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SubscribedOnClick                         = GetObject<Action>(new IntPtr(p + 0x1E8), ReversePrism.DataModels.Action.FromPointer); // 0270D4C09198 0x1E8 SubscribedOnClick           ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.SpriteOn                                  = GetObject<Sprite>(new IntPtr(p + 0x1F8), ReversePrism.DataModels.Sprite.FromPointer); // 0270D4C091D8 0x1F8 SpriteOn                    ( 00018666B610 ModelClassType Sprite Sprite Sprite Pointer )
            value.SpriteColorOn                             = (Color)GetInt32(new IntPtr(p + 0x200)); // 0270D4C091F8 0x200 SpriteColorOn               ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.TextColorOn                               = (Color)GetInt32(new IntPtr(p + 0x210)); // 0270D4C09218 0x210 TextColorOn                 ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.SpriteOff                                 = GetObject<Sprite>(new IntPtr(p + 0x220), ReversePrism.DataModels.Sprite.FromPointer); // 0270D4C09238 0x220 SpriteOff                   ( 00018666B610 ModelClassType Sprite Sprite Sprite Pointer )
            value.SpriteColorOff                            = (Color)GetInt32(new IntPtr(p + 0x228)); // 0270D4C09258 0x228 SpriteColorOff              ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.TextColorOff                              = (Color)GetInt32(new IntPtr(p + 0x238)); // 0270D4C09278 0x238 TextColorOff                ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
