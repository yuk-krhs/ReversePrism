using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Color                                    0001865AB0A0 ModelEnumType Color Color Color Int32
    // 020 PlaneDropShadowColor                     0001865AB0A0 ModelEnumType Color Color Color Int32
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

            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x010)); // 024664E72570 0x10 Color                       ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.PlaneDropShadowColor                      = (Color)GetInt32(new IntPtr(p + 0x020)); // 024664E72590 0x20 PlaneDropShadowColor        ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
