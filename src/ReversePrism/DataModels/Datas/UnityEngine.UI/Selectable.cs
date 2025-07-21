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
    // 020 M_EnableCalled                           ModelPrimitiveType bool bool bool Bool
    // 028 M_Navigation                             ModelEnumType Navigation Navigation Navigation Int32
    // 050 M_Transition                             ModelEnumType Transition Transition Transition Int32
    // 054 M_Colors                                 ModelEnumType ColorBlock ColorBlock ColorBlock Int32
    // 0B0 M_SpriteState                            ModelEnumType SpriteState SpriteState SpriteState Int32
    // 0D0 M_AnimationTriggers                      ModelClassType AnimationTriggers AnimationTriggers AnimationTriggers Pointer
    // 0D8 M_Interactable                           ModelPrimitiveType bool bool bool Bool
    // 0E0 M_TargetGraphic                          ModelClassType Graphic Graphic Graphic Pointer
    // 0E8 M_GroupsAllowInteraction                 ModelPrimitiveType bool bool bool Bool
    // 0EC M_CurrentIndex                           ModelPrimitiveType int int int Int32
    // 0F0 IsPointerInside                          ModelPrimitiveType bool bool bool Bool
    // 0F1 IsPointerDown                            ModelPrimitiveType bool bool bool Bool
    // 0F2 HasSelection                             ModelPrimitiveType bool bool bool Bool
    // 0F8 M_CanvasGroupCache                       ModelClassListType List`1<CanvasGroup> List`1<CanvasGroup> List<CanvasGroup> Pointer
    public partial class Selectable : DataModel
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
            var value   = new Selectable() { Pointer= p0 };

            value.M_EnableCalled                            = GetBool(new IntPtr(p + 0x020)); // 0x20 M_EnableCalled              ( ModelPrimitiveType bool bool bool Bool )
            value.M_Navigation                              = (Navigation)GetInt32(new IntPtr(p + 0x028)); // 0x28 M_Navigation                ( ModelEnumType Navigation Navigation Navigation Int32 )
            value.M_Transition                              = (Transition)GetInt32(new IntPtr(p + 0x050)); // 0x50 M_Transition                ( ModelEnumType Transition Transition Transition Int32 )
            value.M_Colors                                  = (ColorBlock)GetInt32(new IntPtr(p + 0x054)); // 0x54 M_Colors                    ( ModelEnumType ColorBlock ColorBlock ColorBlock Int32 )
            value.M_SpriteState                             = (SpriteState)GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 M_SpriteState               ( ModelEnumType SpriteState SpriteState SpriteState Int32 )
            value.M_AnimationTriggers                       = GetObject<AnimationTriggers>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.AnimationTriggers.FromPointer); // 0xD0 M_AnimationTriggers         ( ModelClassType AnimationTriggers AnimationTriggers AnimationTriggers Pointer )
            value.M_Interactable                            = GetBool(new IntPtr(p + 0x0D8)); // 0xD8 M_Interactable              ( ModelPrimitiveType bool bool bool Bool )
            value.M_TargetGraphic                           = GetObject<Graphic>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.Graphic.FromPointer); // 0xE0 M_TargetGraphic             ( ModelClassType Graphic Graphic Graphic Pointer )
            value.M_GroupsAllowInteraction                  = GetBool(new IntPtr(p + 0x0E8)); // 0xE8 M_GroupsAllowInteraction    ( ModelPrimitiveType bool bool bool Bool )
            value.M_CurrentIndex                            = GetInt32(new IntPtr(p + 0x0EC)); // 0xEC M_CurrentIndex              ( ModelPrimitiveType int int int Int32 )
            value.IsPointerInside                           = GetBool(new IntPtr(p + 0x0F0)); // 0xF0 IsPointerInside             ( ModelPrimitiveType bool bool bool Bool )
            value.IsPointerDown                             = GetBool(new IntPtr(p + 0x0F1)); // 0xF1 IsPointerDown               ( ModelPrimitiveType bool bool bool Bool )
            value.HasSelection                              = GetBool(new IntPtr(p + 0x0F2)); // 0xF2 HasSelection                ( ModelPrimitiveType bool bool bool Bool )
            value.M_CanvasGroupCache                        = GetObjectList<CanvasGroup>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0xF8 M_CanvasGroupCache          ( ModelClassListType List`1<CanvasGroup> List`1<CanvasGroup> List<CanvasGroup> Pointer )

            return value;
        }
    }
}
