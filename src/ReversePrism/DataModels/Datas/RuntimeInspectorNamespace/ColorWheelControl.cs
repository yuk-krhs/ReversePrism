using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 RGB_CONST                                float IL2CPP_TYPE_R4
    // 000 G_CONST                                  float IL2CPP_TYPE_R4
    // 000 B_CONST                                  float IL2CPP_TYPE_R4
    // 020 M_color                                  ModelEnumType Color Color Color Int32
    // 030 Alpha                                    ModelPrimitiveType float float float Single
    // 038 RectTransform                            ModelClassType RectTransform RectTransform RectTransform Pointer
    // 040 SelectorOut                              ModelClassType RectTransform RectTransform RectTransform Pointer
    // 048 SelectorIn                               ModelClassType RectTransform RectTransform RectTransform Pointer
    // 050 ColorPickerWindow                        ModelClassType WindowDragHandler WindowDragHandler WindowDragHandler Pointer
    // 058 Outer                                    ModelPrimitiveType float float float Single
    // 05C Inner                                    ModelEnumType Vector2 Vector2 Vector2 Int32
    // 068 Mat                                      ModelClassType Material Material Material Pointer
    // 070 DraggingOuter                            ModelPrimitiveType bool bool bool Bool
    // 071 DraggingInner                            ModelPrimitiveType bool bool bool Bool
    // 074 HalfSize                                 ModelPrimitiveType float float float Single
    // 078 HalfSizeSqr                              ModelPrimitiveType float float float Single
    // 07C OuterCirclePaddingSqr                    ModelPrimitiveType float float float Single
    // 080 InnerSquareHalfSize                      ModelPrimitiveType float float float Single
    // 084 PointerId                                ModelPrimitiveType int int int Int32
    // 088 OnColorChanged                           ModelClassType OnColorChangedDelegate OnColorChangedDelegate OnColorChangedDelegate Pointer
    public partial class ColorWheelControl : DataModel
    {
        public Color                                    M_color                                 { get; set; }
        public float                                    Alpha                                   { get; set; }
        public RectTransform?                           RectTransform                           { get; set; }
        public RectTransform?                           SelectorOut                             { get; set; }
        public RectTransform?                           SelectorIn                              { get; set; }
        public WindowDragHandler?                       ColorPickerWindow                       { get; set; }
        public float                                    Outer                                   { get; set; }
        public Vector2                                  Inner                                   { get; set; }
        public Material?                                Mat                                     { get; set; }
        public bool                                     DraggingOuter                           { get; set; }
        public bool                                     DraggingInner                           { get; set; }
        public float                                    HalfSize                                { get; set; }
        public float                                    HalfSizeSqr                             { get; set; }
        public float                                    OuterCirclePaddingSqr                   { get; set; }
        public float                                    InnerSquareHalfSize                     { get; set; }
        public int                                      PointerId                               { get; set; }
        public OnColorChangedDelegate?                  OnColorChanged                          { get; set; }

        public static ColorWheelControl? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColorWheelControl() { Pointer= p0 };

            value.M_color                                   = (Color)GetInt32(new IntPtr(p + 0x020)); // 0x20 M_color                     ( ModelEnumType Color Color Color Int32 )
            value.Alpha                                     = GetSingle(new IntPtr(p + 0x030)); // 0x30 Alpha                       ( ModelPrimitiveType float float float Single )
            value.RectTransform                             = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 0x38 RectTransform               ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.SelectorOut                               = GetObject<RectTransform>(new IntPtr(p + 0x040), ReversePrism.DataModels.RectTransform.FromPointer); // 0x40 SelectorOut                 ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.SelectorIn                                = GetObject<RectTransform>(new IntPtr(p + 0x048), ReversePrism.DataModels.RectTransform.FromPointer); // 0x48 SelectorIn                  ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.ColorPickerWindow                         = GetObject<WindowDragHandler>(new IntPtr(p + 0x050), ReversePrism.DataModels.WindowDragHandler.FromPointer); // 0x50 ColorPickerWindow           ( ModelClassType WindowDragHandler WindowDragHandler WindowDragHandler Pointer )
            value.Outer                                     = GetSingle(new IntPtr(p + 0x058)); // 0x58 Outer                       ( ModelPrimitiveType float float float Single )
            value.Inner                                     = (Vector2)GetInt32(new IntPtr(p + 0x05C)); // 0x5C Inner                       ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Mat                                       = GetObject<Material>(new IntPtr(p + 0x068), ReversePrism.DataModels.Material.FromPointer); // 0x68 Mat                         ( ModelClassType Material Material Material Pointer )
            value.DraggingOuter                             = GetBool(new IntPtr(p + 0x070)); // 0x70 DraggingOuter               ( ModelPrimitiveType bool bool bool Bool )
            value.DraggingInner                             = GetBool(new IntPtr(p + 0x071)); // 0x71 DraggingInner               ( ModelPrimitiveType bool bool bool Bool )
            value.HalfSize                                  = GetSingle(new IntPtr(p + 0x074)); // 0x74 HalfSize                    ( ModelPrimitiveType float float float Single )
            value.HalfSizeSqr                               = GetSingle(new IntPtr(p + 0x078)); // 0x78 HalfSizeSqr                 ( ModelPrimitiveType float float float Single )
            value.OuterCirclePaddingSqr                     = GetSingle(new IntPtr(p + 0x07C)); // 0x7C OuterCirclePaddingSqr       ( ModelPrimitiveType float float float Single )
            value.InnerSquareHalfSize                       = GetSingle(new IntPtr(p + 0x080)); // 0x80 InnerSquareHalfSize         ( ModelPrimitiveType float float float Single )
            value.PointerId                                 = GetInt32(new IntPtr(p + 0x084)); // 0x84 PointerId                   ( ModelPrimitiveType int int int Int32 )
            value.OnColorChanged                            = GetObject<OnColorChangedDelegate>(new IntPtr(p + 0x088), ReversePrism.DataModels.OnColorChangedDelegate.FromPointer); // 0x88 OnColorChanged              ( ModelClassType OnColorChangedDelegate OnColorChangedDelegate OnColorChangedDelegate Pointer )

            return value;
        }
    }
}
