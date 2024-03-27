using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Canvas                                   00018653FDA0 ModelClassType Canvas Canvas Canvas Pointer
    // 028 CanvasScale                              000186542610 ModelClassType CanvasScaler CanvasScaler CanvasScaler Pointer
    // 030 FadeMat                                  000185B929A0 ModelClassListType Material[] Material[] List<Material> Pointer
    // 038 White                                    000186685A20 ModelClassType Texture2D Texture2D Texture2D Pointer
    // 040 Black                                    000186685A20 ModelClassType Texture2D Texture2D Texture2D Pointer
    // 048 FadeImage                                000186685A20 ModelClassType Texture2D Texture2D Texture2D Pointer
    // 050 FadeColor                                0001865AA8E0 ModelEnumType Color Color Color Int32
    // 060 FadeType                                 000186735FD0 ModelEnumType FadeType FadeType FadeType Int32
    // 064 LastFadeType                             000186735FD0 ModelEnumType FadeType FadeType FadeType Int32
    // 068 EffectType                               000186735570 ModelEnumType EffectType EffectType EffectType Int32
    // 06C Esing                                    0001866656B0 ModelPrimitiveType float float float Single
    // 070 Img                                      000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 078 Screen                                   0001866DDE50 ModelClassType DisposableRenderTexture DisposableRenderTexture DisposableRenderTexture Pointer
    // 080 LastRatio                                0001866656B0 ModelPrimitiveType float float float Single
    // 084 FrameUpdate                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 088 FadeCount                                0001866656B0 ModelPrimitiveType float float float Single
    // 08C TimeScale                                0001866656B0 ModelPrimitiveType float float float Single
    // 090 FadeOut                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 091 ReverseFlag                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 092 IsFirst                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 093 IsPause                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ScreenEffectEx
    {
        public Canvas?                                  Canvas                                  { get; set; }
        public CanvasScaler?                            CanvasScale                             { get; set; }
        public List<Material>?                          FadeMat                                 { get; set; }
        public Texture2D?                               White                                   { get; set; }
        public Texture2D?                               Black                                   { get; set; }
        public Texture2D?                               FadeImage                               { get; set; }
        public Color                                    FadeColor                               { get; set; }
        public FadeType                                 FadeType                                { get; set; }
        public FadeType                                 LastFadeType                            { get; set; }
        public EffectType                               EffectType                              { get; set; }
        public float                                    Esing                                   { get; set; }
        public RawImage?                                Img                                     { get; set; }
        public DisposableRenderTexture?                 Screen                                  { get; set; }
        public float                                    LastRatio                               { get; set; }
        public int                                      FrameUpdate                             { get; set; }
        public float                                    FadeCount                               { get; set; }
        public float                                    TimeScale                               { get; set; }
        public bool                                     FadeOut                                 { get; set; }
        public bool                                     ReverseFlag                             { get; set; }
        public bool                                     IsFirst                                 { get; set; }
        public bool                                     IsPause                                 { get; set; }

        public static ScreenEffectEx? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScreenEffectEx();

            value.Canvas                                    = GetObject<Canvas>(new IntPtr(p + 0x020), ReversePrism.DataModels.Canvas.FromPointer); // 0270069A5248 0x20 Canvas                      ( 00018653FDA0 ModelClassType Canvas Canvas Canvas Pointer )
            value.CanvasScale                               = GetObject<CanvasScaler>(new IntPtr(p + 0x028), ReversePrism.DataModels.CanvasScaler.FromPointer); // 0270069A5268 0x28 CanvasScale                 ( 000186542610 ModelClassType CanvasScaler CanvasScaler CanvasScaler Pointer )
            value.FadeMat                                   = GetObjectList<Material>(new IntPtr(p + 0x030), ReversePrism.DataModels.Material.FromPointer); // 0270069A5288 0x30 FadeMat                     ( 000185B929A0 ModelClassListType Material[] Material[] List<Material> Pointer )
            value.White                                     = GetObject<Texture2D>(new IntPtr(p + 0x038), ReversePrism.DataModels.Texture2D.FromPointer); // 0270069A52A8 0x38 White                       ( 000186685A20 ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.Black                                     = GetObject<Texture2D>(new IntPtr(p + 0x040), ReversePrism.DataModels.Texture2D.FromPointer); // 0270069A52C8 0x40 Black                       ( 000186685A20 ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.FadeImage                                 = GetObject<Texture2D>(new IntPtr(p + 0x048), ReversePrism.DataModels.Texture2D.FromPointer); // 0270069A52E8 0x48 FadeImage                   ( 000186685A20 ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.FadeColor                                 = (Color)GetInt32(new IntPtr(p + 0x050)); // 0270069A5308 0x50 FadeColor                   ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.FadeType                                  = (FadeType)GetInt32(new IntPtr(p + 0x060)); // 0270069A5328 0x60 FadeType                    ( 000186735FD0 ModelEnumType FadeType FadeType FadeType Int32 )
            value.LastFadeType                              = (FadeType)GetInt32(new IntPtr(p + 0x064)); // 0270069A5348 0x64 LastFadeType                ( 000186735FD0 ModelEnumType FadeType FadeType FadeType Int32 )
            value.EffectType                                = (EffectType)GetInt32(new IntPtr(p + 0x068)); // 0270069A5368 0x68 EffectType                  ( 000186735570 ModelEnumType EffectType EffectType EffectType Int32 )
            value.Esing                                     = GetSingle(new IntPtr(p + 0x06C)); // 0270069A5388 0x6C Esing                       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Img                                       = GetObject<RawImage>(new IntPtr(p + 0x070), ReversePrism.DataModels.RawImage.FromPointer); // 0270069A53A8 0x70 Img                         ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.Screen                                    = GetObject<DisposableRenderTexture>(new IntPtr(p + 0x078), ReversePrism.DataModels.DisposableRenderTexture.FromPointer); // 0270069A53C8 0x78 Screen                      ( 0001866DDE50 ModelClassType DisposableRenderTexture DisposableRenderTexture DisposableRenderTexture Pointer )
            value.LastRatio                                 = GetSingle(new IntPtr(p + 0x080)); // 0270069A53E8 0x80 LastRatio                   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.FrameUpdate                               = GetInt32(new IntPtr(p + 0x084)); // 0270069A5408 0x84 FrameUpdate                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.FadeCount                                 = GetSingle(new IntPtr(p + 0x088)); // 0270069A5428 0x88 FadeCount                   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.TimeScale                                 = GetSingle(new IntPtr(p + 0x08C)); // 0270069A5448 0x8C TimeScale                   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.FadeOut                                   = GetBool(new IntPtr(p + 0x090)); // 0270069A5468 0x90 FadeOut                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ReverseFlag                               = GetBool(new IntPtr(p + 0x091)); // 0270069A5488 0x91 ReverseFlag                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsFirst                                   = GetBool(new IntPtr(p + 0x092)); // 0270069A54A8 0x92 IsFirst                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsPause                                   = GetBool(new IntPtr(p + 0x093)); // 0270069A54C8 0x93 IsPause                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
