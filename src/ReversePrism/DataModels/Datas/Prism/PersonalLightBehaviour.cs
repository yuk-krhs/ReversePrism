using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Color                                    ModelEnumType Color Color Color Int32
    // 020 PlaneDropShadowColor                     ModelEnumType Color Color Color Int32
    public partial class PersonalLightBehaviour : DataModel
    {
        public Color                                    Color                                   { get; set; }
        public Color                                    PlaneDropShadowColor                    { get; set; }

        public static PersonalLightBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PersonalLightBehaviour() { Pointer= p0 };

            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x010)); // 0x10 Color                       ( ModelEnumType Color Color Color Int32 )
            value.PlaneDropShadowColor                      = (Color)GetInt32(new IntPtr(p + 0x020)); // 0x20 PlaneDropShadowColor        ( ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
