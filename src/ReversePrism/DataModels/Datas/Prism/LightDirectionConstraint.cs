using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 OffsetEuler                              ModelEnumType Vector3 Vector3 Vector3 Int32
    // 030 BaseTransform                            ModelClassType Transform Transform Transform Pointer
    // 038 LightRootTransform                       ModelClassType Transform Transform Transform Pointer
    // 040 Lights                                   ModelClassListType Light[] Light[] List<Light> Pointer
    public partial class LightDirectionConstraint : DataModel
    {
        public Vector3                                  OffsetEuler                             { get; set; }
        public Transform?                               BaseTransform                           { get; set; }
        public Transform?                               LightRootTransform                      { get; set; }
        public List<Light>?                             Lights                                  { get; set; }

        public static LightDirectionConstraint? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LightDirectionConstraint() { Pointer= p0 };

            value.OffsetEuler                               = (Vector3)GetInt32(new IntPtr(p + 0x020)); // 0x20 OffsetEuler                 ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.BaseTransform                             = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0x30 BaseTransform               ( ModelClassType Transform Transform Transform Pointer )
            value.LightRootTransform                        = GetObject<Transform>(new IntPtr(p + 0x038), ReversePrism.DataModels.Transform.FromPointer); // 0x38 LightRootTransform          ( ModelClassType Transform Transform Transform Pointer )
            value.Lights                                    = GetObjectList<Light>(new IntPtr(p + 0x040), ReversePrism.DataModels.Light.FromPointer); // 0x40 Lights                      ( ModelClassListType Light[] Light[] List<Light> Pointer )

            return value;
        }
    }
}
