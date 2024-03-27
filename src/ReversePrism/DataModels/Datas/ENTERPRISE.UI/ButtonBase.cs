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
    public partial class ButtonBase
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
            var value   = new ButtonBase();

            value.IsValidOnClick                            = GetBool(new IntPtr(p + 0x108)); // 0270D0C9BB18 0x108 IsValidOnClick              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsValidLongPress                          = GetBool(new IntPtr(p + 0x109)); // 0270D0C9BB38 0x109 IsValidLongPress            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsValidRepeatPress                        = GetBool(new IntPtr(p + 0x10A)); // 0270D0C9BB58 0x10A IsValidRepeatPress          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PressingTime                              = GetSingle(new IntPtr(p + 0x10C)); // 0270D0C9BB78 0x10C PressingTime                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ClickDelayTime                            = GetSingle(new IntPtr(p + 0x110)); // 0270D0C9BB98 0x110 ClickDelayTime              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.OnLongPress                               = GetObject<ButtonPressedEvent>(new IntPtr(p + 0x120), ReversePrism.DataModels.ButtonPressedEvent.FromPointer); // 0270D0C9BBF8 0x120 OnLongPress                 ( 000186715660 ModelClassType ButtonPressedEvent ButtonPressedEvent ButtonPressedEvent Pointer )
            value.OnRepeatPress                             = GetObject<ButtonPressedEvent>(new IntPtr(p + 0x128), ReversePrism.DataModels.ButtonPressedEvent.FromPointer); // 0270D0C9BC18 0x128 OnRepeatPress               ( 000186715660 ModelClassType ButtonPressedEvent ButtonPressedEvent ButtonPressedEvent Pointer )
            value.ParentBeginDrag                           = GetObject<MonoBehaviour>(new IntPtr(p + 0x130), ReversePrism.DataModels.MonoBehaviour.FromPointer); // 0270D0C9BC38 0x130 ParentBeginDrag             ( 00018663D7E0 ModelClassType MonoBehaviour MonoBehaviour MonoBehaviour Pointer )
            value.ParentEndDrag                             = GetObject<MonoBehaviour>(new IntPtr(p + 0x138), ReversePrism.DataModels.MonoBehaviour.FromPointer); // 0270D0C9BC58 0x138 ParentEndDrag               ( 00018663D7E0 ModelClassType MonoBehaviour MonoBehaviour MonoBehaviour Pointer )
            value.ParentDrag                                = GetObject<MonoBehaviour>(new IntPtr(p + 0x140), ReversePrism.DataModels.MonoBehaviour.FromPointer); // 0270D0C9BC78 0x140 ParentDrag                  ( 00018663D7E0 ModelClassType MonoBehaviour MonoBehaviour MonoBehaviour Pointer )
            value.PassDragEventToParent                     = GetBool(new IntPtr(p + 0x148)); // 0270D0C9BC98 0x148 PassDragEventToParent       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.OnClickDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x150), ReversePrism.DataModels.IDisposable.FromPointer); // 0270D0C9BCB8 0x150 OnClickDisposable           ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.OnLongClickDisposable                     = GetObject<IDisposable>(new IntPtr(p + 0x158), ReversePrism.DataModels.IDisposable.FromPointer); // 0270D0C9BCD8 0x158 OnLongClickDisposable       ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.OnClickFallbackDisposable                 = GetObject<IDisposable>(new IntPtr(p + 0x160), ReversePrism.DataModels.IDisposable.FromPointer); // 0270D0C9BCF8 0x160 OnClickFallbackDisposable   ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.ClickSE                                   = (SoundKey)GetInt32(new IntPtr(p + 0x170)); // 0270D0C9BD38 0x170 ClickSE                     ( 000186536200 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.LongPressSE                               = (SoundKey)GetInt32(new IntPtr(p + 0x180)); // 0270D0C9BD58 0x180 LongPressSE                 ( 000186536200 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.IsPlaySound                               = GetBool(new IntPtr(p + 0x190)); // 0270D0C9BD78 0x190 IsPlaySound                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsPlayLongPressSound                      = GetBool(new IntPtr(p + 0x191)); // 0270D0C9BD98 0x191 IsPlayLongPressSound        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsDragging                                = GetBool(new IntPtr(p + 0x192)); // 0270D0C9BDB8 0x192 IsDragging                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsLongClicked                             = GetBool(new IntPtr(p + 0x193)); // 0270D0C9BDD8 0x193 IsLongClicked               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.LongPressEnabled                          = GetBool(new IntPtr(p + 0x194)); // 0270D0C9BDF8 0x194 LongPressEnabled            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.RepeatInterval                            = GetSingle(new IntPtr(p + 0x198)); // 0270D0C9BE18 0x198 RepeatInterval              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ClickedInterval                           = GetSingle(new IntPtr(p + 0x19C)); // 0270D0C9BE38 0x19C ClickedInterval             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.PressScale                                = GetSingle(new IntPtr(p + 0x1A0)); // 0270D0C9BE58 0x1A0 PressScale                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ScaleSecond                               = GetSingle(new IntPtr(p + 0x1A4)); // 0270D0C9BE78 0x1A4 ScaleSecond                 ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.EnableScaleAnimation                      = GetBool(new IntPtr(p + 0x1A8)); // 0270D0C9BE98 0x1A8 EnableScaleAnimation        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ScaleEase                                 = (Ease)GetInt32(new IntPtr(p + 0x1AC)); // 0270D0C9BEB8 0x1AC ScaleEase                   ( 000186716C50 ModelEnumType Ease Ease Ease Int32 )

            return value;
        }
    }
}
