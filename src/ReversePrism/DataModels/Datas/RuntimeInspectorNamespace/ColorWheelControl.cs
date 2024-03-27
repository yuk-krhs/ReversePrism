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
    // 020 M_color                                  0001865AA8E0 ModelEnumType Color Color Color Int32
    // 030 Alpha                                    0001866656B0 ModelPrimitiveType float float float Single
    // 038 RectTransform                            000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 040 SelectorOut                              000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 048 SelectorIn                               000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 050 ColorPickerWindow                        00018655C2D0 ModelClassType WindowDragHandler WindowDragHandler WindowDragHandler Pointer
    // 058 Outer                                    0001866656B0 ModelPrimitiveType float float float Single
    // 05C Inner                                    0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 068 Mat                                      00018660BDD0 ModelClassType Material Material Material Pointer
    // 070 DraggingOuter                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 071 DraggingInner                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 074 HalfSize                                 0001866656B0 ModelPrimitiveType float float float Single
    // 078 HalfSizeSqr                              0001866656B0 ModelPrimitiveType float float float Single
    // 07C OuterCirclePaddingSqr                    0001866656B0 ModelPrimitiveType float float float Single
    // 080 InnerSquareHalfSize                      0001866656B0 ModelPrimitiveType float float float Single
    // 084 PointerId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 088 OnColorChanged                           000186778100 ModelClassType OnColorChangedDelegate OnColorChangedDelegate OnColorChangedDelegate Pointer
    public partial class ColorWheelControl
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
            var value   = new ColorWheelControl();

            value.M_color                                   = (Color)GetInt32(new IntPtr(p + 0x020)); // 0270DB1900A0 0x20 M_color                     ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.Alpha                                     = GetSingle(new IntPtr(p + 0x030)); // 0270DB1900C0 0x30 Alpha                       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.RectTransform                             = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 0270DB1900E0 0x38 RectTransform               ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.SelectorOut                               = GetObject<RectTransform>(new IntPtr(p + 0x040), ReversePrism.DataModels.RectTransform.FromPointer); // 0270DB190100 0x40 SelectorOut                 ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.SelectorIn                                = GetObject<RectTransform>(new IntPtr(p + 0x048), ReversePrism.DataModels.RectTransform.FromPointer); // 0270DB190120 0x48 SelectorIn                  ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.ColorPickerWindow                         = GetObject<WindowDragHandler>(new IntPtr(p + 0x050), ReversePrism.DataModels.WindowDragHandler.FromPointer); // 0270DB190140 0x50 ColorPickerWindow           ( 00018655C2D0 ModelClassType WindowDragHandler WindowDragHandler WindowDragHandler Pointer )
            value.Outer                                     = GetSingle(new IntPtr(p + 0x058)); // 0270DB190160 0x58 Outer                       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Inner                                     = (Vector2)GetInt32(new IntPtr(p + 0x05C)); // 0270DB190180 0x5C Inner                       ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Mat                                       = GetObject<Material>(new IntPtr(p + 0x068), ReversePrism.DataModels.Material.FromPointer); // 0270DB1901A0 0x68 Mat                         ( 00018660BDD0 ModelClassType Material Material Material Pointer )
            value.DraggingOuter                             = GetBool(new IntPtr(p + 0x070)); // 0270DB1901C0 0x70 DraggingOuter               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DraggingInner                             = GetBool(new IntPtr(p + 0x071)); // 0270DB1901E0 0x71 DraggingInner               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.HalfSize                                  = GetSingle(new IntPtr(p + 0x074)); // 0270DB190200 0x74 HalfSize                    ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.HalfSizeSqr                               = GetSingle(new IntPtr(p + 0x078)); // 0270DB190220 0x78 HalfSizeSqr                 ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.OuterCirclePaddingSqr                     = GetSingle(new IntPtr(p + 0x07C)); // 0270DB190240 0x7C OuterCirclePaddingSqr       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.InnerSquareHalfSize                       = GetSingle(new IntPtr(p + 0x080)); // 0270DB190260 0x80 InnerSquareHalfSize         ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.PointerId                                 = GetInt32(new IntPtr(p + 0x084)); // 0270DB190280 0x84 PointerId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OnColorChanged                            = GetObject<OnColorChangedDelegate>(new IntPtr(p + 0x088), ReversePrism.DataModels.OnColorChangedDelegate.FromPointer); // 0270DB1902A0 0x88 OnColorChanged              ( 000186778100 ModelClassType OnColorChangedDelegate OnColorChangedDelegate OnColorChangedDelegate Pointer )

            return value;
        }
    }
}
