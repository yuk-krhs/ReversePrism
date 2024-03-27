using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ussClassName                             string IL2CPP_TYPE_STRING
    // 008 labelUssClassName                        string IL2CPP_TYPE_STRING
    // 010 InputUssClassName                        000186674040 ModelPrimitiveType string string string String
    // 018 CenterFieldUssClassName                  000186674040 ModelPrimitiveType string string string String
    // 020 ExtentsFieldUssClassName                 000186674040 ModelPrimitiveType string string string String
    // 440 M_CenterField                            000186777D30 ModelClassType Vector3Field Vector3Field Vector3Field Pointer
    // 448 M_ExtentsField                           000186777D30 ModelClassType Vector3Field Vector3Field Vector3Field Pointer
    public partial class BoundsField
    {
        public string                                   InputUssClassName                       { get; set; }
        public string                                   CenterFieldUssClassName                 { get; set; }
        public string                                   ExtentsFieldUssClassName                { get; set; }
        public Vector3Field?                            M_CenterField                           { get; set; }
        public Vector3Field?                            M_ExtentsField                          { get; set; }

        public static BoundsField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BoundsField();

            value.InputUssClassName                         = GetString(new IntPtr(p + 0x010)); // 027004FB7EB0 0x10 InputUssClassName           ( 000186674040 ModelPrimitiveType string string string String )
            value.CenterFieldUssClassName                   = GetString(new IntPtr(p + 0x018)); // 027004FB7ED0 0x18 CenterFieldUssClassName     ( 000186674040 ModelPrimitiveType string string string String )
            value.ExtentsFieldUssClassName                  = GetString(new IntPtr(p + 0x020)); // 027004FB7EF0 0x20 ExtentsFieldUssClassName    ( 000186674040 ModelPrimitiveType string string string String )
            value.M_CenterField                             = GetObject<Vector3Field>(new IntPtr(p + 0x440), ReversePrism.DataModels.Vector3Field.FromPointer); // 027004FB7F10 0x440 M_CenterField               ( 000186777D30 ModelClassType Vector3Field Vector3Field Vector3Field Pointer )
            value.M_ExtentsField                            = GetObject<Vector3Field>(new IntPtr(p + 0x448), ReversePrism.DataModels.Vector3Field.FromPointer); // 027004FB7F30 0x448 M_ExtentsField              ( 000186777D30 ModelClassType Vector3Field Vector3Field Vector3Field Pointer )

            return value;
        }
    }
}
