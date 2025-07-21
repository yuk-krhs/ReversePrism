using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 GradientType                             ModelEnumType GradientType GradientType GradientType Int32
    // 014 AddressMode                              ModelEnumType AddressMode AddressMode AddressMode Int32
    // 018 RadialFocus                              ModelEnumType Vector2 Vector2 Vector2 Int32
    // 020 Location                                 ModelEnumType RectInt RectInt RectInt Int32
    public partial class GradientSettings : DataModel
    {
        public GradientType                             GradientType                            { get; set; }
        public AddressMode                              AddressMode                             { get; set; }
        public Vector2                                  RadialFocus                             { get; set; }
        public RectInt                                  Location                                { get; set; }

        public static GradientSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GradientSettings() { Pointer= p0 };

            value.GradientType                              = (GradientType)GetInt32(new IntPtr(p + 0x010)); // 0x10 GradientType                ( ModelEnumType GradientType GradientType GradientType Int32 )
            value.AddressMode                               = (AddressMode)GetInt32(new IntPtr(p + 0x014)); // 0x14 AddressMode                 ( ModelEnumType AddressMode AddressMode AddressMode Int32 )
            value.RadialFocus                               = (Vector2)GetInt32(new IntPtr(p + 0x018)); // 0x18 RadialFocus                 ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Location                                  = (RectInt)GetInt32(new IntPtr(p + 0x020)); // 0x20 Location                    ( ModelEnumType RectInt RectInt RectInt Int32 )

            return value;
        }
    }
}
