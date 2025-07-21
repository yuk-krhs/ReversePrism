using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_UiScaleMode                            ModelEnumType ScaleMode ScaleMode ScaleMode Int32
    // 024 M_ReferencePixelsPerUnit                 ModelPrimitiveType float float float Single
    // 028 M_ScaleFactor                            ModelPrimitiveType float float float Single
    // 02C M_ReferenceResolution                    ModelEnumType Vector2 Vector2 Vector2 Int32
    // 034 M_ScreenMatchMode                        ModelEnumType ScreenMatchMode ScreenMatchMode ScreenMatchMode Int32
    // 038 M_MatchWidthOrHeight                     ModelPrimitiveType float float float Single
    // 000 kLogBase                                 float IL2CPP_TYPE_R4
    // 03C M_PhysicalUnit                           ModelEnumType Unit Unit Unit Int32
    // 040 M_FallbackScreenDPI                      ModelPrimitiveType float float float Single
    // 044 M_DefaultSpriteDPI                       ModelPrimitiveType float float float Single
    // 048 M_DynamicPixelsPerUnit                   ModelPrimitiveType float float float Single
    // 050 M_Canvas                                 ModelClassType Canvas Canvas Canvas Pointer
    // 058 M_PrevScaleFactor                        ModelPrimitiveType float float float Single
    // 05C M_PrevReferencePixelsPerUnit             ModelPrimitiveType float float float Single
    // 060 M_PresetInfoIsWorld                      ModelPrimitiveType bool bool bool Bool
    public partial class CanvasScaler : DataModel
    {
        public ScaleMode                                M_UiScaleMode                           { get; set; }
        public float                                    M_ReferencePixelsPerUnit                { get; set; }
        public float                                    M_ScaleFactor                           { get; set; }
        public Vector2                                  M_ReferenceResolution                   { get; set; }
        public ScreenMatchMode                          M_ScreenMatchMode                       { get; set; }
        public float                                    M_MatchWidthOrHeight                    { get; set; }
        public Unit                                     M_PhysicalUnit                          { get; set; }
        public float                                    M_FallbackScreenDPI                     { get; set; }
        public float                                    M_DefaultSpriteDPI                      { get; set; }
        public float                                    M_DynamicPixelsPerUnit                  { get; set; }
        public Canvas?                                  M_Canvas                                { get; set; }
        public float                                    M_PrevScaleFactor                       { get; set; }
        public float                                    M_PrevReferencePixelsPerUnit            { get; set; }
        public bool                                     M_PresetInfoIsWorld                     { get; set; }

        public static CanvasScaler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CanvasScaler() { Pointer= p0 };

            value.M_UiScaleMode                             = (ScaleMode)GetInt32(new IntPtr(p + 0x020)); // 0x20 M_UiScaleMode               ( ModelEnumType ScaleMode ScaleMode ScaleMode Int32 )
            value.M_ReferencePixelsPerUnit                  = GetSingle(new IntPtr(p + 0x024)); // 0x24 M_ReferencePixelsPerUnit    ( ModelPrimitiveType float float float Single )
            value.M_ScaleFactor                             = GetSingle(new IntPtr(p + 0x028)); // 0x28 M_ScaleFactor               ( ModelPrimitiveType float float float Single )
            value.M_ReferenceResolution                     = (Vector2)GetInt32(new IntPtr(p + 0x02C)); // 0x2C M_ReferenceResolution       ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_ScreenMatchMode                         = (ScreenMatchMode)GetInt32(new IntPtr(p + 0x034)); // 0x34 M_ScreenMatchMode           ( ModelEnumType ScreenMatchMode ScreenMatchMode ScreenMatchMode Int32 )
            value.M_MatchWidthOrHeight                      = GetSingle(new IntPtr(p + 0x038)); // 0x38 M_MatchWidthOrHeight        ( ModelPrimitiveType float float float Single )
            value.M_PhysicalUnit                            = (Unit)GetInt32(new IntPtr(p + 0x03C)); // 0x3C M_PhysicalUnit              ( ModelEnumType Unit Unit Unit Int32 )
            value.M_FallbackScreenDPI                       = GetSingle(new IntPtr(p + 0x040)); // 0x40 M_FallbackScreenDPI         ( ModelPrimitiveType float float float Single )
            value.M_DefaultSpriteDPI                        = GetSingle(new IntPtr(p + 0x044)); // 0x44 M_DefaultSpriteDPI          ( ModelPrimitiveType float float float Single )
            value.M_DynamicPixelsPerUnit                    = GetSingle(new IntPtr(p + 0x048)); // 0x48 M_DynamicPixelsPerUnit      ( ModelPrimitiveType float float float Single )
            value.M_Canvas                                  = GetObject<Canvas>(new IntPtr(p + 0x050), ReversePrism.DataModels.Canvas.FromPointer); // 0x50 M_Canvas                    ( ModelClassType Canvas Canvas Canvas Pointer )
            value.M_PrevScaleFactor                         = GetSingle(new IntPtr(p + 0x058)); // 0x58 M_PrevScaleFactor           ( ModelPrimitiveType float float float Single )
            value.M_PrevReferencePixelsPerUnit              = GetSingle(new IntPtr(p + 0x05C)); // 0x5C M_PrevReferencePixelsPerUnit ( ModelPrimitiveType float float float Single )
            value.M_PresetInfoIsWorld                       = GetBool(new IntPtr(p + 0x060)); // 0x60 M_PresetInfoIsWorld         ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
