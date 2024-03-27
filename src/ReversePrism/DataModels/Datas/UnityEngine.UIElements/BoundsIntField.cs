using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 440 M_PositionField                          000186778210 ModelClassType Vector3IntField Vector3IntField Vector3IntField Pointer
    // 448 M_SizeField                              000186778210 ModelClassType Vector3IntField Vector3IntField Vector3IntField Pointer
    // 000 ussClassName                             string IL2CPP_TYPE_STRING
    // 008 labelUssClassName                        string IL2CPP_TYPE_STRING
    // 010 InputUssClassName                        000186674040 ModelPrimitiveType string string string String
    // 018 PositionUssClassName                     000186674040 ModelPrimitiveType string string string String
    // 020 SizeUssClassName                         000186674040 ModelPrimitiveType string string string String
    public partial class BoundsIntField
    {
        public Vector3IntField?                         M_PositionField                         { get; set; }
        public Vector3IntField?                         M_SizeField                             { get; set; }
        public string                                   InputUssClassName                       { get; set; }
        public string                                   PositionUssClassName                    { get; set; }
        public string                                   SizeUssClassName                        { get; set; }

        public static BoundsIntField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BoundsIntField();

            value.M_PositionField                           = GetObject<Vector3IntField>(new IntPtr(p + 0x440), ReversePrism.DataModels.Vector3IntField.FromPointer); // 027005062CB0 0x440 M_PositionField             ( 000186778210 ModelClassType Vector3IntField Vector3IntField Vector3IntField Pointer )
            value.M_SizeField                               = GetObject<Vector3IntField>(new IntPtr(p + 0x448), ReversePrism.DataModels.Vector3IntField.FromPointer); // 027005062CD0 0x448 M_SizeField                 ( 000186778210 ModelClassType Vector3IntField Vector3IntField Vector3IntField Pointer )
            value.InputUssClassName                         = GetString(new IntPtr(p + 0x010)); // 027005062D30 0x10 InputUssClassName           ( 000186674040 ModelPrimitiveType string string string String )
            value.PositionUssClassName                      = GetString(new IntPtr(p + 0x018)); // 027005062D50 0x18 PositionUssClassName        ( 000186674040 ModelPrimitiveType string string string String )
            value.SizeUssClassName                          = GetString(new IntPtr(p + 0x020)); // 027005062D70 0x20 SizeUssClassName            ( 000186674040 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
