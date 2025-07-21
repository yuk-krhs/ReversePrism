using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Position                                 ModelEnumType Rect Rect Rect Int32
    // 020 VisibleRect                              ModelEnumType Rect Rect Rect Int32
    // 030 ViewRect                                 ModelEnumType Rect Rect Rect Int32
    // 040 ScrollPosition                           ModelEnumType Vector2 Vector2 Vector2 Int32
    // 048 Apply                                    ModelPrimitiveType bool bool bool Bool
    // 049 IsDuringTouchScroll                      ModelPrimitiveType bool bool bool Bool
    // 04C TouchScrollStartMousePosition            ModelEnumType Vector2 Vector2 Vector2 Int32
    // 054 TouchScrollStartPosition                 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 05C Velocity                                 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 064 PreviousTimeSinceStartup                 ModelPrimitiveType float float float Single
    public partial class ScrollViewState : DataModel
    {
        public Rect                                     Position                                { get; set; }
        public Rect                                     VisibleRect                             { get; set; }
        public Rect                                     ViewRect                                { get; set; }
        public Vector2                                  ScrollPosition                          { get; set; }
        public bool                                     Apply                                   { get; set; }
        public bool                                     IsDuringTouchScroll                     { get; set; }
        public Vector2                                  TouchScrollStartMousePosition           { get; set; }
        public Vector2                                  TouchScrollStartPosition                { get; set; }
        public Vector2                                  Velocity                                { get; set; }
        public float                                    PreviousTimeSinceStartup                { get; set; }

        public static ScrollViewState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScrollViewState() { Pointer= p0 };

            value.Position                                  = (Rect)GetInt32(new IntPtr(p + 0x010)); // 0x10 Position                    ( ModelEnumType Rect Rect Rect Int32 )
            value.VisibleRect                               = (Rect)GetInt32(new IntPtr(p + 0x020)); // 0x20 VisibleRect                 ( ModelEnumType Rect Rect Rect Int32 )
            value.ViewRect                                  = (Rect)GetInt32(new IntPtr(p + 0x030)); // 0x30 ViewRect                    ( ModelEnumType Rect Rect Rect Int32 )
            value.ScrollPosition                            = (Vector2)GetInt32(new IntPtr(p + 0x040)); // 0x40 ScrollPosition              ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Apply                                     = GetBool(new IntPtr(p + 0x048)); // 0x48 Apply                       ( ModelPrimitiveType bool bool bool Bool )
            value.IsDuringTouchScroll                       = GetBool(new IntPtr(p + 0x049)); // 0x49 IsDuringTouchScroll         ( ModelPrimitiveType bool bool bool Bool )
            value.TouchScrollStartMousePosition             = (Vector2)GetInt32(new IntPtr(p + 0x04C)); // 0x4C TouchScrollStartMousePosition ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.TouchScrollStartPosition                  = (Vector2)GetInt32(new IntPtr(p + 0x054)); // 0x54 TouchScrollStartPosition    ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Velocity                                  = (Vector2)GetInt32(new IntPtr(p + 0x05C)); // 0x5C Velocity                    ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.PreviousTimeSinceStartup                  = GetSingle(new IntPtr(p + 0x064)); // 0x64 PreviousTimeSinceStartup    ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
