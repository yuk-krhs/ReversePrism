using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 430 DragElement                              0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 438 DragMinThumb                             0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 440 DragMaxThumb                             0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 448 <clampedDragger>k__BackingField          ClampedDragger`1<float> IL2CPP_TYPE_GENERICINST
    // 450 M_DragElementStartPos                    0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 458 M_ValueStartPos                          0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 460 M_DragMinThumbRect                       00018664F620 ModelEnumType Rect Rect Rect Int32
    // 470 M_DragMaxThumbRect                       00018664F620 ModelEnumType Rect Rect Rect Int32
    // 480 M_DragState                              00018671F8B0 ModelEnumType DragState DragState DragState Int32
    // 484 M_MinLimit                               0001866656B0 ModelPrimitiveType float float float Single
    // 488 M_MaxLimit                               0001866656B0 ModelPrimitiveType float float float Single
    // 000 ussClassName                             string IL2CPP_TYPE_STRING
    // 008 labelUssClassName                        string IL2CPP_TYPE_STRING
    // 010 InputUssClassName                        000186674040 ModelPrimitiveType string string string String
    // 018 TrackerUssClassName                      000186674040 ModelPrimitiveType string string string String
    // 020 DraggerUssClassName                      000186674040 ModelPrimitiveType string string string String
    // 028 MinThumbUssClassName                     000186674040 ModelPrimitiveType string string string String
    // 030 MaxThumbUssClassName                     000186674040 ModelPrimitiveType string string string String
    public partial class MinMaxSlider
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
            var value   = new MinMaxSlider();

            value.DragElement                               = GetObject<VisualElement>(new IntPtr(p + 0x430), ReversePrism.DataModels.VisualElement.FromPointer); // 027006720920 0x430 DragElement                 ( 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.DragMinThumb                              = GetObject<VisualElement>(new IntPtr(p + 0x438), ReversePrism.DataModels.VisualElement.FromPointer); // 027006720940 0x438 DragMinThumb                ( 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.DragMaxThumb                              = GetObject<VisualElement>(new IntPtr(p + 0x440), ReversePrism.DataModels.VisualElement.FromPointer); // 027006720960 0x440 DragMaxThumb                ( 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_DragElementStartPos                     = (Vector2)GetInt32(new IntPtr(p + 0x450)); // 0270067209A0 0x450 M_DragElementStartPos       ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_ValueStartPos                           = (Vector2)GetInt32(new IntPtr(p + 0x458)); // 0270067209C0 0x458 M_ValueStartPos             ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_DragMinThumbRect                        = (Rect)GetInt32(new IntPtr(p + 0x460)); // 0270067209E0 0x460 M_DragMinThumbRect          ( 00018664F620 ModelEnumType Rect Rect Rect Int32 )
            value.M_DragMaxThumbRect                        = (Rect)GetInt32(new IntPtr(p + 0x470)); // 027006720A00 0x470 M_DragMaxThumbRect          ( 00018664F620 ModelEnumType Rect Rect Rect Int32 )
            value.M_DragState                               = (DragState)GetInt32(new IntPtr(p + 0x480)); // 027006720A20 0x480 M_DragState                 ( 00018671F8B0 ModelEnumType DragState DragState DragState Int32 )
            value.M_MinLimit                                = GetSingle(new IntPtr(p + 0x484)); // 027006720A40 0x484 M_MinLimit                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_MaxLimit                                = GetSingle(new IntPtr(p + 0x488)); // 027006720A60 0x488 M_MaxLimit                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.InputUssClassName                         = GetString(new IntPtr(p + 0x010)); // 027006720AC0 0x10 InputUssClassName           ( 000186674040 ModelPrimitiveType string string string String )
            value.TrackerUssClassName                       = GetString(new IntPtr(p + 0x018)); // 027006720AE0 0x18 TrackerUssClassName         ( 000186674040 ModelPrimitiveType string string string String )
            value.DraggerUssClassName                       = GetString(new IntPtr(p + 0x020)); // 027006720B00 0x20 DraggerUssClassName         ( 000186674040 ModelPrimitiveType string string string String )
            value.MinThumbUssClassName                      = GetString(new IntPtr(p + 0x028)); // 027006720B20 0x28 MinThumbUssClassName        ( 000186674040 ModelPrimitiveType string string string String )
            value.MaxThumbUssClassName                      = GetString(new IntPtr(p + 0x030)); // 027006720B40 0x30 MaxThumbUssClassName        ( 000186674040 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
