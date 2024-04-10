using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kNoEventMaskSet                          int IL2CPP_TYPE_I4
    // 028 M_EventCamera                            0001865A2130 ModelClassType Camera Camera Camera Pointer
    // 030 M_EventMask                              00018650B3C0 ModelEnumType LayerMask LayerMask LayerMask Int32
    // 034 M_MaxRayIntersections                    0001865F3220 ModelPrimitiveType int int int Int32
    // 038 M_LastMaxRayIntersections                0001865F3220 ModelPrimitiveType int int int Int32
    // 040 M_Hits                                   000185C9FEB8 ModelEnumListType RaycastHit[] RaycastHit[] List<RaycastHit> Pointer
    public partial class PhysicsRaycaster : DataModel
    {
        public Camera?                                  M_EventCamera                           { get; set; }
        public LayerMask                                M_EventMask                             { get; set; }
        public int                                      M_MaxRayIntersections                   { get; set; }
        public int                                      M_LastMaxRayIntersections               { get; set; }
        public List<RaycastHit>?                        M_Hits                                  { get; set; }

        public static PhysicsRaycaster? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PhysicsRaycaster() { Pointer= p0 };

            value.M_EventCamera                             = GetObject<Camera>(new IntPtr(p + 0x028), ReversePrism.DataModels.Camera.FromPointer); // 0245A68A9098 0x28 M_EventCamera               ( 0001865A2130 ModelClassType Camera Camera Camera Pointer )
            value.M_EventMask                               = (LayerMask)GetInt32(new IntPtr(p + 0x030)); // 0245A68A90B8 0x30 M_EventMask                 ( 00018650B3C0 ModelEnumType LayerMask LayerMask LayerMask Int32 )
            value.M_MaxRayIntersections                     = GetInt32(new IntPtr(p + 0x034)); // 0245A68A90D8 0x34 M_MaxRayIntersections       ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.M_LastMaxRayIntersections                 = GetInt32(new IntPtr(p + 0x038)); // 0245A68A90F8 0x38 M_LastMaxRayIntersections   ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.M_Hits                                    = GetEnumList<RaycastHit>(new IntPtr(p + 0x040)); // 0245A68A9118 0x40 M_Hits                      ( 000185C9FEB8 ModelEnumListType RaycastHit[] RaycastHit[] List<RaycastHit> Pointer )

            return value;
        }
    }
}
