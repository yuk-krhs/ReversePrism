using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 100 M_FillRect                               000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 108 M_HandleRect                             000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 110 M_Direction                              000186540C80 ModelEnumType Direction Direction Direction Int32
    // 114 M_MinValue                               0001866656B0 ModelPrimitiveType float float float Single
    // 118 M_MaxValue                               0001866656B0 ModelPrimitiveType float float float Single
    // 11C M_WholeNumbers                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 120 M_Value                                  000186665B50 ModelPrimitiveType float float float Single
    // 128 M_OnValueChanged                         000186541470 ModelClassType SliderEvent SliderEvent SliderEvent Pointer
    // 130 M_FillImage                              0001866CCDB0 ModelClassType Image Image Image Pointer
    // 138 M_FillTransform                          0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 140 M_FillContainerRect                      000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 148 M_HandleTransform                        0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 150 M_HandleContainerRect                    000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 158 M_Offset                                 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 160 M_Tracker                                000186705B80 ModelEnumType DrivenRectTransformTracker DrivenRectTransformTracker DrivenRectTransformTracker Int32
    // 161 M_DelayedUpdateVisuals                   000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class Slider
    {
        public RectTransform?                           M_FillRect                              { get; set; }
        public RectTransform?                           M_HandleRect                            { get; set; }
        public Direction                                M_Direction                             { get; set; }
        public float                                    M_MinValue                              { get; set; }
        public float                                    M_MaxValue                              { get; set; }
        public bool                                     M_WholeNumbers                          { get; set; }
        public float                                    M_Value                                 { get; set; }
        public SliderEvent?                             M_OnValueChanged                        { get; set; }
        public Image?                                   M_FillImage                             { get; set; }
        public Transform?                               M_FillTransform                         { get; set; }
        public RectTransform?                           M_FillContainerRect                     { get; set; }
        public Transform?                               M_HandleTransform                       { get; set; }
        public RectTransform?                           M_HandleContainerRect                   { get; set; }
        public Vector2                                  M_Offset                                { get; set; }
        public DrivenRectTransformTracker               M_Tracker                               { get; set; }
        public bool                                     M_DelayedUpdateVisuals                  { get; set; }

        public static Slider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Slider();

            value.M_FillRect                                = GetObject<RectTransform>(new IntPtr(p + 0x100), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D0A8A408 0x100 M_FillRect                  ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_HandleRect                              = GetObject<RectTransform>(new IntPtr(p + 0x108), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D0A8A428 0x108 M_HandleRect                ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_Direction                               = (Direction)GetInt32(new IntPtr(p + 0x110)); // 0270D0A8A448 0x110 M_Direction                 ( 000186540C80 ModelEnumType Direction Direction Direction Int32 )
            value.M_MinValue                                = GetSingle(new IntPtr(p + 0x114)); // 0270D0A8A468 0x114 M_MinValue                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_MaxValue                                = GetSingle(new IntPtr(p + 0x118)); // 0270D0A8A488 0x118 M_MaxValue                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_WholeNumbers                            = GetBool(new IntPtr(p + 0x11C)); // 0270D0A8A4A8 0x11C M_WholeNumbers              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_Value                                   = GetSingle(new IntPtr(p + 0x120)); // 0270D0A8A4C8 0x120 M_Value                     ( 000186665B50 ModelPrimitiveType float float float Single )
            value.M_OnValueChanged                          = GetObject<SliderEvent>(new IntPtr(p + 0x128), ReversePrism.DataModels.SliderEvent.FromPointer); // 0270D0A8A4E8 0x128 M_OnValueChanged            ( 000186541470 ModelClassType SliderEvent SliderEvent SliderEvent Pointer )
            value.M_FillImage                               = GetObject<Image>(new IntPtr(p + 0x130), ReversePrism.DataModels.Image.FromPointer); // 0270D0A8A508 0x130 M_FillImage                 ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.M_FillTransform                           = GetObject<Transform>(new IntPtr(p + 0x138), ReversePrism.DataModels.Transform.FromPointer); // 0270D0A8A528 0x138 M_FillTransform             ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.M_FillContainerRect                       = GetObject<RectTransform>(new IntPtr(p + 0x140), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D0A8A548 0x140 M_FillContainerRect         ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_HandleTransform                         = GetObject<Transform>(new IntPtr(p + 0x148), ReversePrism.DataModels.Transform.FromPointer); // 0270D0A8A568 0x148 M_HandleTransform           ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.M_HandleContainerRect                     = GetObject<RectTransform>(new IntPtr(p + 0x150), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D0A8A588 0x150 M_HandleContainerRect       ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_Offset                                  = (Vector2)GetInt32(new IntPtr(p + 0x158)); // 0270D0A8A5A8 0x158 M_Offset                    ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_Tracker                                 = (DrivenRectTransformTracker)GetInt32(new IntPtr(p + 0x160)); // 0270D0A8A5C8 0x160 M_Tracker                   ( 000186705B80 ModelEnumType DrivenRectTransformTracker DrivenRectTransformTracker DrivenRectTransformTracker Int32 )
            value.M_DelayedUpdateVisuals                    = GetBool(new IntPtr(p + 0x161)); // 0270D0A8A5E8 0x161 M_DelayedUpdateVisuals      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
