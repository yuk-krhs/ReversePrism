using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IsSwipeConsecutive                       ModelPrimitiveType bool bool bool Bool
    // 024 SwipeDistanceValueType                   ModelEnumType SwipeDistanceValueType SwipeDistanceValueType SwipeDistanceValueType Int32
    // 028 MinSwipeDistance                         ModelPrimitiveType float float float Single
    // 02C MinSwipeDistanceScreenPercentage         ModelPrimitiveType float float float Single
    // 030 StartTouchPosition                       ModelEnumType Vector2 Vector2 Vector2 Int32
    // 038 DragTouchPosition                        ModelEnumType Vector2 Vector2 Vector2 Int32
    // 040 EndTouchPosition                         ModelEnumType Vector2 Vector2 Vector2 Int32
    // 048 DragLastStatusHorizontal                 ModelPrimitiveType int int int Int32
    // 04C DragLastStatusVertical                   ModelPrimitiveType int int int Int32
    // 050 IsSwiped                                 ModelPrimitiveType bool bool bool Bool
    // 058 TapDisposables                           ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 060 onTapSubject                             Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 068 onDragSwipeHorizontalSubject             Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 070 onDragSwipeVerticalSubject               Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 078 onEndSwipeHorizontalSubject              Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 080 onEndSwipeVerticalSubject                Subject`1<bool> IL2CPP_TYPE_GENERICINST
    public partial class SwipeButton : DataModel
    {
        public bool                                     IsSwipeConsecutive                      { get; set; }
        public SwipeDistanceValueType                   SwipeDistanceValueType                  { get; set; }
        public float                                    MinSwipeDistance                        { get; set; }
        public float                                    MinSwipeDistanceScreenPercentage        { get; set; }
        public Vector2                                  StartTouchPosition                      { get; set; }
        public Vector2                                  DragTouchPosition                       { get; set; }
        public Vector2                                  EndTouchPosition                        { get; set; }
        public int                                      DragLastStatusHorizontal                { get; set; }
        public int                                      DragLastStatusVertical                  { get; set; }
        public bool                                     IsSwiped                                { get; set; }
        public CompositeDisposable?                     TapDisposables                          { get; set; }

        public static SwipeButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SwipeButton() { Pointer= p0 };

            value.IsSwipeConsecutive                        = GetBool(new IntPtr(p + 0x020)); // 0x20 IsSwipeConsecutive          ( ModelPrimitiveType bool bool bool Bool )
            value.SwipeDistanceValueType                    = (SwipeDistanceValueType)GetInt32(new IntPtr(p + 0x024)); // 0x24 SwipeDistanceValueType      ( ModelEnumType SwipeDistanceValueType SwipeDistanceValueType SwipeDistanceValueType Int32 )
            value.MinSwipeDistance                          = GetSingle(new IntPtr(p + 0x028)); // 0x28 MinSwipeDistance            ( ModelPrimitiveType float float float Single )
            value.MinSwipeDistanceScreenPercentage          = GetSingle(new IntPtr(p + 0x02C)); // 0x2C MinSwipeDistanceScreenPercentage ( ModelPrimitiveType float float float Single )
            value.StartTouchPosition                        = (Vector2)GetInt32(new IntPtr(p + 0x030)); // 0x30 StartTouchPosition          ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.DragTouchPosition                         = (Vector2)GetInt32(new IntPtr(p + 0x038)); // 0x38 DragTouchPosition           ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.EndTouchPosition                          = (Vector2)GetInt32(new IntPtr(p + 0x040)); // 0x40 EndTouchPosition            ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.DragLastStatusHorizontal                  = GetInt32(new IntPtr(p + 0x048)); // 0x48 DragLastStatusHorizontal    ( ModelPrimitiveType int int int Int32 )
            value.DragLastStatusVertical                    = GetInt32(new IntPtr(p + 0x04C)); // 0x4C DragLastStatusVertical      ( ModelPrimitiveType int int int Int32 )
            value.IsSwiped                                  = GetBool(new IntPtr(p + 0x050)); // 0x50 IsSwiped                    ( ModelPrimitiveType bool bool bool Bool )
            value.TapDisposables                            = GetObject<CompositeDisposable>(new IntPtr(p + 0x058), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x58 TapDisposables              ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
