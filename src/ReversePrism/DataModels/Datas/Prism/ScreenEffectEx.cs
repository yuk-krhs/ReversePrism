using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TmpRTId                                  ModelPrimitiveType int int int Int32
    // 028 Canvas                                   ModelClassType Canvas Canvas Canvas Pointer
    // 030 CanvasScale                              ModelClassType CanvasScaler CanvasScaler CanvasScaler Pointer
    // 038 FadeMat                                  ModelClassListType Material[] Material[] List<Material> Pointer
    // 040 White                                    ModelClassType Texture2D Texture2D Texture2D Pointer
    // 048 Black                                    ModelClassType Texture2D Texture2D Texture2D Pointer
    // 050 FadeImage                                ModelClassType Texture2D Texture2D Texture2D Pointer
    // 058 FadeColor                                ModelEnumType Color Color Color Int32
    // 068 CopyForDissolve                          ModelClassType Material Material Material Pointer
    // 070 FadeType                                 ModelEnumType FadeType FadeType FadeType Int32
    // 074 LastFadeType                             ModelEnumType FadeType FadeType FadeType Int32
    // 078 EffectType                               ModelEnumType EffectType EffectType EffectType Int32
    // 07C Esing                                    ModelPrimitiveType float float float Single
    // 080 Img                                      ModelClassType RawImage RawImage RawImage Pointer
    // 088 OneShotCapture                           ModelClassType ScreenEffectCapture ScreenEffectCapture ScreenEffectCapture Pointer
    // 090 FrameBufferCapture                       ModelClassType ScreenEffectCapture ScreenEffectCapture ScreenEffectCapture Pointer
    // 098 LastRatio                                ModelPrimitiveType float float float Single
    // 09C FrameUpdate                              ModelPrimitiveType int int int Int32
    // 0A0 IsCameraDisable                          ModelPrimitiveType bool bool bool Bool
    // 0A1 IsExistSplitScreen                       ModelPrimitiveType bool bool bool Bool
    // 0A2 IsNeedFrameBuffer                        ModelPrimitiveType bool bool bool Bool
    // 0A4 FadeCount                                ModelPrimitiveType float float float Single
    // 0A8 TimeScale                                ModelPrimitiveType float float float Single
    // 0AC FadeOut                                  ModelPrimitiveType bool bool bool Bool
    // 0AD ReverseFlag                              ModelPrimitiveType bool bool bool Bool
    // 0AE IsFirst                                  ModelPrimitiveType bool bool bool Bool
    // 0AF IsPause                                  ModelPrimitiveType bool bool bool Bool
    public partial class ScreenEffectEx : DataModel
    {
        public int                                      TmpRTId                                 { get; set; }
        public Canvas?                                  Canvas                                  { get; set; }
        public CanvasScaler?                            CanvasScale                             { get; set; }
        public List<Material>?                          FadeMat                                 { get; set; }
        public Texture2D?                               White                                   { get; set; }
        public Texture2D?                               Black                                   { get; set; }
        public Texture2D?                               FadeImage                               { get; set; }
        public Color                                    FadeColor                               { get; set; }
        public Material?                                CopyForDissolve                         { get; set; }
        public FadeType                                 FadeType                                { get; set; }
        public FadeType                                 LastFadeType                            { get; set; }
        public EffectType                               EffectType                              { get; set; }
        public float                                    Esing                                   { get; set; }
        public RawImage?                                Img                                     { get; set; }
        public ScreenEffectCapture?                     OneShotCapture                          { get; set; }
        public ScreenEffectCapture?                     FrameBufferCapture                      { get; set; }
        public float                                    LastRatio                               { get; set; }
        public int                                      FrameUpdate                             { get; set; }
        public bool                                     IsCameraDisable                         { get; set; }
        public bool                                     IsExistSplitScreen                      { get; set; }
        public bool                                     IsNeedFrameBuffer                       { get; set; }
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
            var value   = new ScreenEffectEx() { Pointer= p0 };

            value.TmpRTId                                   = GetInt32(new IntPtr(p + 0x020)); // 0x20 TmpRTId                     ( ModelPrimitiveType int int int Int32 )
            value.Canvas                                    = GetObject<Canvas>(new IntPtr(p + 0x028), ReversePrism.DataModels.Canvas.FromPointer); // 0x28 Canvas                      ( ModelClassType Canvas Canvas Canvas Pointer )
            value.CanvasScale                               = GetObject<CanvasScaler>(new IntPtr(p + 0x030), ReversePrism.DataModels.CanvasScaler.FromPointer); // 0x30 CanvasScale                 ( ModelClassType CanvasScaler CanvasScaler CanvasScaler Pointer )
            value.FadeMat                                   = GetObjectList<Material>(new IntPtr(p + 0x038), ReversePrism.DataModels.Material.FromPointer); // 0x38 FadeMat                     ( ModelClassListType Material[] Material[] List<Material> Pointer )
            value.White                                     = GetObject<Texture2D>(new IntPtr(p + 0x040), ReversePrism.DataModels.Texture2D.FromPointer); // 0x40 White                       ( ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.Black                                     = GetObject<Texture2D>(new IntPtr(p + 0x048), ReversePrism.DataModels.Texture2D.FromPointer); // 0x48 Black                       ( ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.FadeImage                                 = GetObject<Texture2D>(new IntPtr(p + 0x050), ReversePrism.DataModels.Texture2D.FromPointer); // 0x50 FadeImage                   ( ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.FadeColor                                 = (Color)GetInt32(new IntPtr(p + 0x058)); // 0x58 FadeColor                   ( ModelEnumType Color Color Color Int32 )
            value.CopyForDissolve                           = GetObject<Material>(new IntPtr(p + 0x068), ReversePrism.DataModels.Material.FromPointer); // 0x68 CopyForDissolve             ( ModelClassType Material Material Material Pointer )
            value.FadeType                                  = (FadeType)GetInt32(new IntPtr(p + 0x070)); // 0x70 FadeType                    ( ModelEnumType FadeType FadeType FadeType Int32 )
            value.LastFadeType                              = (FadeType)GetInt32(new IntPtr(p + 0x074)); // 0x74 LastFadeType                ( ModelEnumType FadeType FadeType FadeType Int32 )
            value.EffectType                                = (EffectType)GetInt32(new IntPtr(p + 0x078)); // 0x78 EffectType                  ( ModelEnumType EffectType EffectType EffectType Int32 )
            value.Esing                                     = GetSingle(new IntPtr(p + 0x07C)); // 0x7C Esing                       ( ModelPrimitiveType float float float Single )
            value.Img                                       = GetObject<RawImage>(new IntPtr(p + 0x080), ReversePrism.DataModels.RawImage.FromPointer); // 0x80 Img                         ( ModelClassType RawImage RawImage RawImage Pointer )
            value.OneShotCapture                            = GetObject<ScreenEffectCapture>(new IntPtr(p + 0x088), ReversePrism.DataModels.ScreenEffectCapture.FromPointer); // 0x88 OneShotCapture              ( ModelClassType ScreenEffectCapture ScreenEffectCapture ScreenEffectCapture Pointer )
            value.FrameBufferCapture                        = GetObject<ScreenEffectCapture>(new IntPtr(p + 0x090), ReversePrism.DataModels.ScreenEffectCapture.FromPointer); // 0x90 FrameBufferCapture          ( ModelClassType ScreenEffectCapture ScreenEffectCapture ScreenEffectCapture Pointer )
            value.LastRatio                                 = GetSingle(new IntPtr(p + 0x098)); // 0x98 LastRatio                   ( ModelPrimitiveType float float float Single )
            value.FrameUpdate                               = GetInt32(new IntPtr(p + 0x09C)); // 0x9C FrameUpdate                 ( ModelPrimitiveType int int int Int32 )
            value.IsCameraDisable                           = GetBool(new IntPtr(p + 0x0A0)); // 0xA0 IsCameraDisable             ( ModelPrimitiveType bool bool bool Bool )
            value.IsExistSplitScreen                        = GetBool(new IntPtr(p + 0x0A1)); // 0xA1 IsExistSplitScreen          ( ModelPrimitiveType bool bool bool Bool )
            value.IsNeedFrameBuffer                         = GetBool(new IntPtr(p + 0x0A2)); // 0xA2 IsNeedFrameBuffer           ( ModelPrimitiveType bool bool bool Bool )
            value.FadeCount                                 = GetSingle(new IntPtr(p + 0x0A4)); // 0xA4 FadeCount                   ( ModelPrimitiveType float float float Single )
            value.TimeScale                                 = GetSingle(new IntPtr(p + 0x0A8)); // 0xA8 TimeScale                   ( ModelPrimitiveType float float float Single )
            value.FadeOut                                   = GetBool(new IntPtr(p + 0x0AC)); // 0xAC FadeOut                     ( ModelPrimitiveType bool bool bool Bool )
            value.ReverseFlag                               = GetBool(new IntPtr(p + 0x0AD)); // 0xAD ReverseFlag                 ( ModelPrimitiveType bool bool bool Bool )
            value.IsFirst                                   = GetBool(new IntPtr(p + 0x0AE)); // 0xAE IsFirst                     ( ModelPrimitiveType bool bool bool Bool )
            value.IsPause                                   = GetBool(new IntPtr(p + 0x0AF)); // 0xAF IsPause                     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
