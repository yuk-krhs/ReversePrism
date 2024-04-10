using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_UiScaleMode                            0001867295E0 ModelEnumType ScaleMode ScaleMode ScaleMode Int32
    // 024 M_ReferencePixelsPerUnit                 000186665B50 ModelPrimitiveType float float float Single
    // 028 M_ScaleFactor                            000186665B50 ModelPrimitiveType float float float Single
    // 02C M_ReferenceResolution                    0001866A8470 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 034 M_ScreenMatchMode                        000186729D00 ModelEnumType ScreenMatchMode ScreenMatchMode ScreenMatchMode Int32
    // 038 M_MatchWidthOrHeight                     000186665B50 ModelPrimitiveType float float float Single
    // 000 kLogBase                                 float IL2CPP_TYPE_R4
    // 03C M_PhysicalUnit                           00018672A440 ModelEnumType Unit Unit Unit Int32
    // 040 M_FallbackScreenDPI                      000186665B50 ModelPrimitiveType float float float Single
    // 044 M_DefaultSpriteDPI                       000186665B50 ModelPrimitiveType float float float Single
    // 048 M_DynamicPixelsPerUnit                   000186665B50 ModelPrimitiveType float float float Single
    // 050 M_Canvas                                 00018653FDA0 ModelClassType Canvas Canvas Canvas Pointer
    // 058 M_PrevScaleFactor                        0001866678D0 ModelPrimitiveType float float float Single
    // 05C M_PrevReferencePixelsPerUnit             0001866678D0 ModelPrimitiveType float float float Single
    // 060 M_PresetInfoIsWorld                      000186595480 ModelPrimitiveType bool bool bool Bool
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

            value.M_UiScaleMode                             = (ScaleMode)GetInt32(new IntPtr(p + 0x020)); // 0245A35E73A8 0x20 M_UiScaleMode               ( 0001867295E0 ModelEnumType ScaleMode ScaleMode ScaleMode Int32 )
            value.M_ReferencePixelsPerUnit                  = GetSingle(new IntPtr(p + 0x024)); // 0245A35E73C8 0x24 M_ReferencePixelsPerUnit    ( 000186665B50 ModelPrimitiveType float float float Single )
            value.M_ScaleFactor                             = GetSingle(new IntPtr(p + 0x028)); // 0245A35E73E8 0x28 M_ScaleFactor               ( 000186665B50 ModelPrimitiveType float float float Single )
            value.M_ReferenceResolution                     = (Vector2)GetInt32(new IntPtr(p + 0x02C)); // 0245A35E7408 0x2C M_ReferenceResolution       ( 0001866A8470 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_ScreenMatchMode                         = (ScreenMatchMode)GetInt32(new IntPtr(p + 0x034)); // 0245A35E7428 0x34 M_ScreenMatchMode           ( 000186729D00 ModelEnumType ScreenMatchMode ScreenMatchMode ScreenMatchMode Int32 )
            value.M_MatchWidthOrHeight                      = GetSingle(new IntPtr(p + 0x038)); // 0245A35E7448 0x38 M_MatchWidthOrHeight        ( 000186665B50 ModelPrimitiveType float float float Single )
            value.M_PhysicalUnit                            = (Unit)GetInt32(new IntPtr(p + 0x03C)); // 0245A35E7488 0x3C M_PhysicalUnit              ( 00018672A440 ModelEnumType Unit Unit Unit Int32 )
            value.M_FallbackScreenDPI                       = GetSingle(new IntPtr(p + 0x040)); // 0245A35E74A8 0x40 M_FallbackScreenDPI         ( 000186665B50 ModelPrimitiveType float float float Single )
            value.M_DefaultSpriteDPI                        = GetSingle(new IntPtr(p + 0x044)); // 0245A35E74C8 0x44 M_DefaultSpriteDPI          ( 000186665B50 ModelPrimitiveType float float float Single )
            value.M_DynamicPixelsPerUnit                    = GetSingle(new IntPtr(p + 0x048)); // 0245A35E74E8 0x48 M_DynamicPixelsPerUnit      ( 000186665B50 ModelPrimitiveType float float float Single )
            value.M_Canvas                                  = GetObject<Canvas>(new IntPtr(p + 0x050), ReversePrism.DataModels.Canvas.FromPointer); // 0245A35E7508 0x50 M_Canvas                    ( 00018653FDA0 ModelClassType Canvas Canvas Canvas Pointer )
            value.M_PrevScaleFactor                         = GetSingle(new IntPtr(p + 0x058)); // 0245A35E7528 0x58 M_PrevScaleFactor           ( 0001866678D0 ModelPrimitiveType float float float Single )
            value.M_PrevReferencePixelsPerUnit              = GetSingle(new IntPtr(p + 0x05C)); // 0245A35E7548 0x5C M_PrevReferencePixelsPerUnit ( 0001866678D0 ModelPrimitiveType float float float Single )
            value.M_PresetInfoIsWorld                       = GetBool(new IntPtr(p + 0x060)); // 0245A35E7568 0x60 M_PresetInfoIsWorld         ( 000186595480 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
