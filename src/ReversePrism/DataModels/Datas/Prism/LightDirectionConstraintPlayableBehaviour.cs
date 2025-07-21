using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Enabled                                  ModelPrimitiveType bool bool bool Bool
    // 014 OffsetEuler                              ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class LightDirectionConstraintPlayableBehaviour : DataModel
    {
        public bool                                     Enabled                                 { get; set; }
        public Vector3                                  OffsetEuler                             { get; set; }

        public static LightDirectionConstraintPlayableBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LightDirectionConstraintPlayableBehaviour() { Pointer= p0 };

            value.Enabled                                   = GetBool(new IntPtr(p + 0x010)); // 0x10 Enabled                     ( ModelPrimitiveType bool bool bool Bool )
            value.OffsetEuler                               = (Vector3)GetInt32(new IntPtr(p + 0x014)); // 0x14 OffsetEuler                 ( ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
