using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Scale                                  0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 01C M_IsNone                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class Scale : DataModel
    {
        public Vector3                                  M_Scale                                 { get; set; }
        public bool                                     M_IsNone                                { get; set; }

        public static Scale? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Scale() { Pointer= p0 };

            value.M_Scale                                   = (Vector3)GetInt32(new IntPtr(p + 0x010)); // 0245A3F20BA0 0x10 M_Scale                     ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_IsNone                                  = GetBool(new IntPtr(p + 0x01C)); // 0245A3F20BC0 0x1C M_IsNone                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
