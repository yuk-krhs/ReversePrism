using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 M_Offset                                 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 03C M_ApplyAfter                             ModelEnumType Stage Stage Stage Int32
    // 040 M_PreserveComposition                    ModelPrimitiveType bool bool bool Bool
    public partial class CinemachineCameraOffset : DataModel
    {
        public Vector3                                  M_Offset                                { get; set; }
        public Stage                                    M_ApplyAfter                            { get; set; }
        public bool                                     M_PreserveComposition                   { get; set; }

        public static CinemachineCameraOffset? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineCameraOffset() { Pointer= p0 };

            value.M_Offset                                  = (Vector3)GetInt32(new IntPtr(p + 0x030)); // 0x30 M_Offset                    ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_ApplyAfter                              = (Stage)GetInt32(new IntPtr(p + 0x03C)); // 0x3C M_ApplyAfter                ( ModelEnumType Stage Stage Stage Int32 )
            value.M_PreserveComposition                     = GetBool(new IntPtr(p + 0x040)); // 0x40 M_PreserveComposition       ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
