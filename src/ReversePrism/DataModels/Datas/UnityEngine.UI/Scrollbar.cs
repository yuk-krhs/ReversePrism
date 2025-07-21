using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 100 M_HandleRect                             ModelClassType RectTransform RectTransform RectTransform Pointer
    // 108 M_Direction                              ModelEnumType Direction Direction Direction Int32
    // 10C M_Value                                  ModelPrimitiveType float float float Single
    // 110 M_Size                                   ModelPrimitiveType float float float Single
    // 114 M_NumberOfSteps                          ModelPrimitiveType int int int Int32
    // 118 M_OnValueChanged                         ModelClassType ScrollEvent ScrollEvent ScrollEvent Pointer
    // 120 M_ContainerRect                          ModelClassType RectTransform RectTransform RectTransform Pointer
    // 128 M_Offset                                 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 130 M_Tracker                                ModelEnumType DrivenRectTransformTracker DrivenRectTransformTracker DrivenRectTransformTracker Int32
    // 138 M_PointerDownRepeat                      ModelClassType Coroutine Coroutine Coroutine Pointer
    // 140 IsPointerDownAndNotDragging              ModelPrimitiveType bool bool bool Bool
    // 141 M_DelayedUpdateVisuals                   ModelPrimitiveType bool bool bool Bool
    public partial class Scrollbar : DataModel
    {
        public RectTransform?                           M_HandleRect                            { get; set; }
        public Direction                                M_Direction                             { get; set; }
        public float                                    M_Value                                 { get; set; }
        public float                                    M_Size                                  { get; set; }
        public int                                      M_NumberOfSteps                         { get; set; }
        public ScrollEvent?                             M_OnValueChanged                        { get; set; }
        public RectTransform?                           M_ContainerRect                         { get; set; }
        public Vector2                                  M_Offset                                { get; set; }
        public DrivenRectTransformTracker               M_Tracker                               { get; set; }
        public Coroutine?                               M_PointerDownRepeat                     { get; set; }
        public bool                                     IsPointerDownAndNotDragging             { get; set; }
        public bool                                     M_DelayedUpdateVisuals                  { get; set; }

        public static Scrollbar? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Scrollbar() { Pointer= p0 };

            value.M_HandleRect                              = GetObject<RectTransform>(new IntPtr(p + 0x100), ReversePrism.DataModels.RectTransform.FromPointer); // 0x100 M_HandleRect                ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_Direction                               = (Direction)GetInt32(new IntPtr(p + 0x108)); // 0x108 M_Direction                 ( ModelEnumType Direction Direction Direction Int32 )
            value.M_Value                                   = GetSingle(new IntPtr(p + 0x10C)); // 0x10C M_Value                     ( ModelPrimitiveType float float float Single )
            value.M_Size                                    = GetSingle(new IntPtr(p + 0x110)); // 0x110 M_Size                      ( ModelPrimitiveType float float float Single )
            value.M_NumberOfSteps                           = GetInt32(new IntPtr(p + 0x114)); // 0x114 M_NumberOfSteps             ( ModelPrimitiveType int int int Int32 )
            value.M_OnValueChanged                          = GetObject<ScrollEvent>(new IntPtr(p + 0x118), ReversePrism.DataModels.ScrollEvent.FromPointer); // 0x118 M_OnValueChanged            ( ModelClassType ScrollEvent ScrollEvent ScrollEvent Pointer )
            value.M_ContainerRect                           = GetObject<RectTransform>(new IntPtr(p + 0x120), ReversePrism.DataModels.RectTransform.FromPointer); // 0x120 M_ContainerRect             ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_Offset                                  = (Vector2)GetInt32(new IntPtr(p + 0x128)); // 0x128 M_Offset                    ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_Tracker                                 = (DrivenRectTransformTracker)GetInt32(new IntPtr(p + 0x130)); // 0x130 M_Tracker                   ( ModelEnumType DrivenRectTransformTracker DrivenRectTransformTracker DrivenRectTransformTracker Int32 )
            value.M_PointerDownRepeat                       = GetObject<Coroutine>(new IntPtr(p + 0x138), ReversePrism.DataModels.Coroutine.FromPointer); // 0x138 M_PointerDownRepeat         ( ModelClassType Coroutine Coroutine Coroutine Pointer )
            value.IsPointerDownAndNotDragging               = GetBool(new IntPtr(p + 0x140)); // 0x140 IsPointerDownAndNotDragging ( ModelPrimitiveType bool bool bool Bool )
            value.M_DelayedUpdateVisuals                    = GetBool(new IntPtr(p + 0x141)); // 0x141 M_DelayedUpdateVisuals      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
