using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Selectables                            Selectable[] IL2CPP_TYPE_SZARRAY
    // 008 s_SelectableCount                        int IL2CPP_TYPE_I4
    // 020 M_EnableCalled                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 M_Navigation                             000186696550 ModelEnumType Navigation Navigation Navigation Int32
    // 050 M_Transition                             00018675A500 ModelEnumType Transition Transition Transition Int32
    // 054 M_Colors                                 0001865CC0F0 ModelEnumType ColorBlock ColorBlock ColorBlock Int32
    // 0B0 M_SpriteState                            0001865536B0 ModelEnumType SpriteState SpriteState SpriteState Int32
    // 0D0 M_AnimationTriggers                      0001866B89A0 ModelClassType AnimationTriggers AnimationTriggers AnimationTriggers Pointer
    // 0D8 M_Interactable                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0E0 M_TargetGraphic                          0001866920B0 ModelClassType Graphic Graphic Graphic Pointer
    // 0E8 M_GroupsAllowInteraction                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0EC M_CurrentIndex                           0001865F3220 ModelPrimitiveType int int int Int32
    // 0F0 IsPointerInside                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0F1 IsPointerDown                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0F2 HasSelection                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0F8 M_CanvasGroupCache                       000185CD13E8 ModelClassListType List`1<CanvasGroup> List`1<CanvasGroup> List<CanvasGroup> Pointer
    public partial class Selectable
    {
        public bool                                     M_EnableCalled                          { get; set; }
        public Navigation                               M_Navigation                            { get; set; }
        public Transition                               M_Transition                            { get; set; }
        public ColorBlock                               M_Colors                                { get; set; }
        public SpriteState                              M_SpriteState                           { get; set; }
        public AnimationTriggers?                       M_AnimationTriggers                     { get; set; }
        public bool                                     M_Interactable                          { get; set; }
        public Graphic?                                 M_TargetGraphic                         { get; set; }
        public bool                                     M_GroupsAllowInteraction                { get; set; }
        public int                                      M_CurrentIndex                          { get; set; }
        public bool                                     IsPointerInside                         { get; set; }
        public bool                                     IsPointerDown                           { get; set; }
        public bool                                     HasSelection                            { get; set; }
        public List<CanvasGroup>?                       M_CanvasGroupCache                      { get; set; }

        public static Selectable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Selectable();

            value.M_EnableCalled                            = GetBool(new IntPtr(p + 0x020)); // 0270D0A888D8 0x20 M_EnableCalled              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_Navigation                              = (Navigation)GetInt32(new IntPtr(p + 0x028)); // 0270D0A888F8 0x28 M_Navigation                ( 000186696550 ModelEnumType Navigation Navigation Navigation Int32 )
            value.M_Transition                              = (Transition)GetInt32(new IntPtr(p + 0x050)); // 0270D0A88918 0x50 M_Transition                ( 00018675A500 ModelEnumType Transition Transition Transition Int32 )
            value.M_Colors                                  = (ColorBlock)GetInt32(new IntPtr(p + 0x054)); // 0270D0A88938 0x54 M_Colors                    ( 0001865CC0F0 ModelEnumType ColorBlock ColorBlock ColorBlock Int32 )
            value.M_SpriteState                             = (SpriteState)GetInt32(new IntPtr(p + 0x0B0)); // 0270D0A88958 0xB0 M_SpriteState               ( 0001865536B0 ModelEnumType SpriteState SpriteState SpriteState Int32 )
            value.M_AnimationTriggers                       = GetObject<AnimationTriggers>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.AnimationTriggers.FromPointer); // 0270D0A88978 0xD0 M_AnimationTriggers         ( 0001866B89A0 ModelClassType AnimationTriggers AnimationTriggers AnimationTriggers Pointer )
            value.M_Interactable                            = GetBool(new IntPtr(p + 0x0D8)); // 0270D0A88998 0xD8 M_Interactable              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_TargetGraphic                           = GetObject<Graphic>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.Graphic.FromPointer); // 0270D0A889B8 0xE0 M_TargetGraphic             ( 0001866920B0 ModelClassType Graphic Graphic Graphic Pointer )
            value.M_GroupsAllowInteraction                  = GetBool(new IntPtr(p + 0x0E8)); // 0270D0A889D8 0xE8 M_GroupsAllowInteraction    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_CurrentIndex                            = GetInt32(new IntPtr(p + 0x0EC)); // 0270D0A889F8 0xEC M_CurrentIndex              ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.IsPointerInside                           = GetBool(new IntPtr(p + 0x0F0)); // 0270D0A88A18 0xF0 IsPointerInside             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsPointerDown                             = GetBool(new IntPtr(p + 0x0F1)); // 0270D0A88A38 0xF1 IsPointerDown               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.HasSelection                              = GetBool(new IntPtr(p + 0x0F2)); // 0270D0A88A58 0xF2 HasSelection                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_CanvasGroupCache                        = GetObjectList<CanvasGroup>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270D0A88A78 0xF8 M_CanvasGroupCache          ( 000185CD13E8 ModelClassListType List`1<CanvasGroup> List`1<CanvasGroup> List<CanvasGroup> Pointer )

            return value;
        }
    }
}
