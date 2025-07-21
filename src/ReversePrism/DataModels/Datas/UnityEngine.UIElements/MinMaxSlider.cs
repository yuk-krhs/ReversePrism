using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 440 DragElement                              ModelClassType VisualElement VisualElement VisualElement Pointer
    // 448 DragMinThumb                             ModelClassType VisualElement VisualElement VisualElement Pointer
    // 450 DragMaxThumb                             ModelClassType VisualElement VisualElement VisualElement Pointer
    // 458 <clampedDragger>k__BackingField          ClampedDragger`1<float> IL2CPP_TYPE_GENERICINST
    // 460 M_DragElementStartPos                    ModelEnumType Vector2 Vector2 Vector2 Int32
    // 468 M_ValueStartPos                          ModelEnumType Vector2 Vector2 Vector2 Int32
    // 470 M_DragMinThumbRect                       ModelEnumType Rect Rect Rect Int32
    // 480 M_DragMaxThumbRect                       ModelEnumType Rect Rect Rect Int32
    // 490 M_DragState                              ModelEnumType DragState DragState DragState Int32
    // 494 M_MinLimit                               ModelPrimitiveType float float float Single
    // 498 M_MaxLimit                               ModelPrimitiveType float float float Single
    // 000 ussClassName                             string IL2CPP_TYPE_STRING
    // 008 labelUssClassName                        string IL2CPP_TYPE_STRING
    // 010 InputUssClassName                        ModelPrimitiveType string string string String
    // 018 TrackerUssClassName                      ModelPrimitiveType string string string String
    // 020 DraggerUssClassName                      ModelPrimitiveType string string string String
    // 028 MinThumbUssClassName                     ModelPrimitiveType string string string String
    // 030 MaxThumbUssClassName                     ModelPrimitiveType string string string String
    public partial class MinMaxSlider : DataModel
    {
        public VisualElement?                           DragElement                             { get; set; }
        public VisualElement?                           DragMinThumb                            { get; set; }
        public VisualElement?                           DragMaxThumb                            { get; set; }
        public Vector2                                  M_DragElementStartPos                   { get; set; }
        public Vector2                                  M_ValueStartPos                         { get; set; }
        public Rect                                     M_DragMinThumbRect                      { get; set; }
        public Rect                                     M_DragMaxThumbRect                      { get; set; }
        public DragState                                M_DragState                             { get; set; }
        public float                                    M_MinLimit                              { get; set; }
        public float                                    M_MaxLimit                              { get; set; }
        public string                                   InputUssClassName                       { get; set; }
        public string                                   TrackerUssClassName                     { get; set; }
        public string                                   DraggerUssClassName                     { get; set; }
        public string                                   MinThumbUssClassName                    { get; set; }
        public string                                   MaxThumbUssClassName                    { get; set; }

        public static MinMaxSlider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MinMaxSlider() { Pointer= p0 };

            value.DragElement                               = GetObject<VisualElement>(new IntPtr(p + 0x440), ReversePrism.DataModels.VisualElement.FromPointer); // 0x440 DragElement                 ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.DragMinThumb                              = GetObject<VisualElement>(new IntPtr(p + 0x448), ReversePrism.DataModels.VisualElement.FromPointer); // 0x448 DragMinThumb                ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.DragMaxThumb                              = GetObject<VisualElement>(new IntPtr(p + 0x450), ReversePrism.DataModels.VisualElement.FromPointer); // 0x450 DragMaxThumb                ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_DragElementStartPos                     = (Vector2)GetInt32(new IntPtr(p + 0x460)); // 0x460 M_DragElementStartPos       ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_ValueStartPos                           = (Vector2)GetInt32(new IntPtr(p + 0x468)); // 0x468 M_ValueStartPos             ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_DragMinThumbRect                        = (Rect)GetInt32(new IntPtr(p + 0x470)); // 0x470 M_DragMinThumbRect          ( ModelEnumType Rect Rect Rect Int32 )
            value.M_DragMaxThumbRect                        = (Rect)GetInt32(new IntPtr(p + 0x480)); // 0x480 M_DragMaxThumbRect          ( ModelEnumType Rect Rect Rect Int32 )
            value.M_DragState                               = (DragState)GetInt32(new IntPtr(p + 0x490)); // 0x490 M_DragState                 ( ModelEnumType DragState DragState DragState Int32 )
            value.M_MinLimit                                = GetSingle(new IntPtr(p + 0x494)); // 0x494 M_MinLimit                  ( ModelPrimitiveType float float float Single )
            value.M_MaxLimit                                = GetSingle(new IntPtr(p + 0x498)); // 0x498 M_MaxLimit                  ( ModelPrimitiveType float float float Single )
            value.InputUssClassName                         = GetString(new IntPtr(p + 0x010)); // 0x10 InputUssClassName           ( ModelPrimitiveType string string string String )
            value.TrackerUssClassName                       = GetString(new IntPtr(p + 0x018)); // 0x18 TrackerUssClassName         ( ModelPrimitiveType string string string String )
            value.DraggerUssClassName                       = GetString(new IntPtr(p + 0x020)); // 0x20 DraggerUssClassName         ( ModelPrimitiveType string string string String )
            value.MinThumbUssClassName                      = GetString(new IntPtr(p + 0x028)); // 0x28 MinThumbUssClassName        ( ModelPrimitiveType string string string String )
            value.MaxThumbUssClassName                      = GetString(new IntPtr(p + 0x030)); // 0x30 MaxThumbUssClassName        ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
