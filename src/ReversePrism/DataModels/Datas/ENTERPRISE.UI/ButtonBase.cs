using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 108 IsValidOnClick                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 109 IsValidLongPress                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 10A IsValidRepeatPress                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 10C PressingTime                             0001866656B0 ModelPrimitiveType float float float Single
    // 110 ClickDelayTime                           0001866656B0 ModelPrimitiveType float float float Single
    // 000 longPressThreshold                       float IL2CPP_TYPE_R4
    // 118 currentButtonState                       ReactiveProperty`1<ClickerState> IL2CPP_TYPE_GENERICINST
    // 120 OnLongPress                              000186715660 ModelClassType ButtonPressedEvent ButtonPressedEvent ButtonPressedEvent Pointer
    // 128 OnRepeatPress                            000186715660 ModelClassType ButtonPressedEvent ButtonPressedEvent ButtonPressedEvent Pointer
    // 130 ParentBeginDrag                          00018663D7E0 ModelClassType MonoBehaviour MonoBehaviour MonoBehaviour Pointer
    // 138 ParentEndDrag                            00018663D7E0 ModelClassType MonoBehaviour MonoBehaviour MonoBehaviour Pointer
    // 140 ParentDrag                               00018663D7E0 ModelClassType MonoBehaviour MonoBehaviour MonoBehaviour Pointer
    // 148 PassDragEventToParent                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 150 OnClickDisposable                        0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 158 OnLongClickDisposable                    0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 160 OnClickFallbackDisposable                0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 168 onClickSubject                           Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 170 ClickSE                                  000186536200 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 180 LongPressSE                              000186536200 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 190 IsPlaySound                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 191 IsPlayLongPressSound                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 192 IsDragging                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 193 IsLongClicked                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 194 LongPressEnabled                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 198 RepeatInterval                           0001866656B0 ModelPrimitiveType float float float Single
    // 19C ClickedInterval                          0001866656B0 ModelPrimitiveType float float float Single
    // 1A0 PressScale                               0001866656B0 ModelPrimitiveType float float float Single
    // 1A4 ScaleSecond                              0001866656B0 ModelPrimitiveType float float float Single
    // 1A8 EnableScaleAnimation                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 1AC ScaleEase                                000186716C50 ModelEnumType Ease Ease Ease Int32
    public partial class ButtonBase : DataModel
    {
        public bool                                     IsValidOnClick                          { get; set; }
        public bool                                     IsValidLongPress                        { get; set; }
        public bool                                     IsValidRepeatPress                      { get; set; }
        public float                                    PressingTime                            { get; set; }
        public float                                    ClickDelayTime                          { get; set; }
        public ButtonPressedEvent?                      OnLongPress                             { get; set; }
        public ButtonPressedEvent?                      OnRepeatPress                           { get; set; }
        public MonoBehaviour?                           ParentBeginDrag                         { get; set; }
        public MonoBehaviour?                           ParentEndDrag                           { get; set; }
        public MonoBehaviour?                           ParentDrag                              { get; set; }
        public bool                                     PassDragEventToParent                   { get; set; }
        public IDisposable?                             OnClickDisposable                       { get; set; }
        public IDisposable?                             OnLongClickDisposable                   { get; set; }
        public IDisposable?                             OnClickFallbackDisposable               { get; set; }
        public SoundKey                                 ClickSE                                 { get; set; }
        public SoundKey                                 LongPressSE                             { get; set; }
        public bool                                     IsPlaySound                             { get; set; }
        public bool                                     IsPlayLongPressSound                    { get; set; }
        public bool                                     IsDragging                              { get; set; }
        public bool                                     IsLongClicked                           { get; set; }
        public bool                                     LongPressEnabled                        { get; set; }
        public float                                    RepeatInterval                          { get; set; }
        public float                                    ClickedInterval                         { get; set; }
        public float                                    PressScale                              { get; set; }
        public float                                    ScaleSecond                             { get; set; }
        public bool                                     EnableScaleAnimation                    { get; set; }
        public Ease                                     ScaleEase                               { get; set; }

        public static ButtonBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ButtonBase() { Pointer= p0 };

            value.IsValidOnClick                            = GetBool(new IntPtr(p + 0x108)); // 024660CCA0E0 0x108 IsValidOnClick              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsValidLongPress                          = GetBool(new IntPtr(p + 0x109)); // 024660CCA100 0x109 IsValidLongPress            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsValidRepeatPress                        = GetBool(new IntPtr(p + 0x10A)); // 024660CCA120 0x10A IsValidRepeatPress          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PressingTime                              = GetSingle(new IntPtr(p + 0x10C)); // 024660CCA140 0x10C PressingTime                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ClickDelayTime                            = GetSingle(new IntPtr(p + 0x110)); // 024660CCA160 0x110 ClickDelayTime              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.OnLongPress                               = GetObject<ButtonPressedEvent>(new IntPtr(p + 0x120), ReversePrism.DataModels.ButtonPressedEvent.FromPointer); // 024660CCA1C0 0x120 OnLongPress                 ( 000186715660 ModelClassType ButtonPressedEvent ButtonPressedEvent ButtonPressedEvent Pointer )
            value.OnRepeatPress                             = GetObject<ButtonPressedEvent>(new IntPtr(p + 0x128), ReversePrism.DataModels.ButtonPressedEvent.FromPointer); // 024660CCA1E0 0x128 OnRepeatPress               ( 000186715660 ModelClassType ButtonPressedEvent ButtonPressedEvent ButtonPressedEvent Pointer )
            value.ParentBeginDrag                           = GetObject<MonoBehaviour>(new IntPtr(p + 0x130), ReversePrism.DataModels.MonoBehaviour.FromPointer); // 024660CCA200 0x130 ParentBeginDrag             ( 00018663D7E0 ModelClassType MonoBehaviour MonoBehaviour MonoBehaviour Pointer )
            value.ParentEndDrag                             = GetObject<MonoBehaviour>(new IntPtr(p + 0x138), ReversePrism.DataModels.MonoBehaviour.FromPointer); // 024660CCA220 0x138 ParentEndDrag               ( 00018663D7E0 ModelClassType MonoBehaviour MonoBehaviour MonoBehaviour Pointer )
            value.ParentDrag                                = GetObject<MonoBehaviour>(new IntPtr(p + 0x140), ReversePrism.DataModels.MonoBehaviour.FromPointer); // 024660CCA240 0x140 ParentDrag                  ( 00018663D7E0 ModelClassType MonoBehaviour MonoBehaviour MonoBehaviour Pointer )
            value.PassDragEventToParent                     = GetBool(new IntPtr(p + 0x148)); // 024660CCA260 0x148 PassDragEventToParent       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.OnClickDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x150), ReversePrism.DataModels.IDisposable.FromPointer); // 024660CCA280 0x150 OnClickDisposable           ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.OnLongClickDisposable                     = GetObject<IDisposable>(new IntPtr(p + 0x158), ReversePrism.DataModels.IDisposable.FromPointer); // 024660CCA2A0 0x158 OnLongClickDisposable       ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.OnClickFallbackDisposable                 = GetObject<IDisposable>(new IntPtr(p + 0x160), ReversePrism.DataModels.IDisposable.FromPointer); // 024660CCA2C0 0x160 OnClickFallbackDisposable   ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.ClickSE                                   = (SoundKey)GetInt32(new IntPtr(p + 0x170)); // 024660CCA300 0x170 ClickSE                     ( 000186536200 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.LongPressSE                               = (SoundKey)GetInt32(new IntPtr(p + 0x180)); // 024660CCA320 0x180 LongPressSE                 ( 000186536200 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.IsPlaySound                               = GetBool(new IntPtr(p + 0x190)); // 024660CCA340 0x190 IsPlaySound                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsPlayLongPressSound                      = GetBool(new IntPtr(p + 0x191)); // 024660CCA360 0x191 IsPlayLongPressSound        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsDragging                                = GetBool(new IntPtr(p + 0x192)); // 024660CCA380 0x192 IsDragging                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsLongClicked                             = GetBool(new IntPtr(p + 0x193)); // 024660CCA3A0 0x193 IsLongClicked               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.LongPressEnabled                          = GetBool(new IntPtr(p + 0x194)); // 024660CCA3C0 0x194 LongPressEnabled            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.RepeatInterval                            = GetSingle(new IntPtr(p + 0x198)); // 024660CCA3E0 0x198 RepeatInterval              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ClickedInterval                           = GetSingle(new IntPtr(p + 0x19C)); // 024660CCA400 0x19C ClickedInterval             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.PressScale                                = GetSingle(new IntPtr(p + 0x1A0)); // 024660CCA420 0x1A0 PressScale                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ScaleSecond                               = GetSingle(new IntPtr(p + 0x1A4)); // 024660CCA440 0x1A4 ScaleSecond                 ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.EnableScaleAnimation                      = GetBool(new IntPtr(p + 0x1A8)); // 024660CCA460 0x1A8 EnableScaleAnimation        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ScaleEase                                 = (Ease)GetInt32(new IntPtr(p + 0x1AC)); // 024660CCA480 0x1AC ScaleEase                   ( 000186716C50 ModelEnumType Ease Ease Ease Int32 )

            return value;
        }
    }
}
