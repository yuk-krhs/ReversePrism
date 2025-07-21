using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 088 OldRect                                  ModelEnumType Rect Rect Rect Int32
    // 098 NewRect                                  ModelEnumType Rect Rect Rect Int32
    // 0A8 LayoutPass                               ModelPrimitiveType int int int Int32
    public partial class GeometryChangedEvent : DataModel
    {
        public Rect                                     OldRect                                 { get; set; }
        public Rect                                     NewRect                                 { get; set; }
        public int                                      LayoutPass                              { get; set; }

        public static GeometryChangedEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GeometryChangedEvent() { Pointer= p0 };

            value.OldRect                                   = (Rect)GetInt32(new IntPtr(p + 0x088)); // 0x88 OldRect                     ( ModelEnumType Rect Rect Rect Int32 )
            value.NewRect                                   = (Rect)GetInt32(new IntPtr(p + 0x098)); // 0x98 NewRect                     ( ModelEnumType Rect Rect Rect Int32 )
            value.LayoutPass                                = GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 LayoutPass                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
