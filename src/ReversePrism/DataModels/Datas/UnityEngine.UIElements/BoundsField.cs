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
    // 010 InputUssClassName                        ModelPrimitiveType string string string String
    // 018 CenterFieldUssClassName                  ModelPrimitiveType string string string String
    // 020 ExtentsFieldUssClassName                 ModelPrimitiveType string string string String
    // 450 M_CenterField                            ModelClassType Vector3Field Vector3Field Vector3Field Pointer
    // 458 M_ExtentsField                           ModelClassType Vector3Field Vector3Field Vector3Field Pointer
    public partial class BoundsField : DataModel
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
            var value   = new BoundsField() { Pointer= p0 };

            value.InputUssClassName                         = GetString(new IntPtr(p + 0x010)); // 0x10 InputUssClassName           ( ModelPrimitiveType string string string String )
            value.CenterFieldUssClassName                   = GetString(new IntPtr(p + 0x018)); // 0x18 CenterFieldUssClassName     ( ModelPrimitiveType string string string String )
            value.ExtentsFieldUssClassName                  = GetString(new IntPtr(p + 0x020)); // 0x20 ExtentsFieldUssClassName    ( ModelPrimitiveType string string string String )
            value.M_CenterField                             = GetObject<Vector3Field>(new IntPtr(p + 0x450), ReversePrism.DataModels.Vector3Field.FromPointer); // 0x450 M_CenterField               ( ModelClassType Vector3Field Vector3Field Vector3Field Pointer )
            value.M_ExtentsField                            = GetObject<Vector3Field>(new IntPtr(p + 0x458), ReversePrism.DataModels.Vector3Field.FromPointer); // 0x458 M_ExtentsField              ( ModelClassType Vector3Field Vector3Field Vector3Field Pointer )

            return value;
        }
    }
}
