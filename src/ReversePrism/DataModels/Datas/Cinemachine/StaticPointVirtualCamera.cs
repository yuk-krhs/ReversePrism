using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 Priority                                 ModelPrimitiveType int int int Int32
    // 020 LookAt                                   ModelClassType Transform Transform Transform Pointer
    // 028 Follow                                   ModelClassType Transform Transform Transform Pointer
    // 030 State                                    ModelEnumType CameraState CameraState CameraState Int32
    public partial class StaticPointVirtualCamera : DataModel
    {
        public string                                   Name                                    { get; set; }
        public int                                      Priority                                { get; set; }
        public Transform?                               LookAt                                  { get; set; }
        public Transform?                               Follow                                  { get; set; }
        public CameraState                              State                                   { get; set; }

        public static StaticPointVirtualCamera? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StaticPointVirtualCamera() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Priority                                  = GetInt32(new IntPtr(p + 0x018)); // 0x18 Priority                    ( ModelPrimitiveType int int int Int32 )
            value.LookAt                                    = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0x20 LookAt                      ( ModelClassType Transform Transform Transform Pointer )
            value.Follow                                    = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0x28 Follow                      ( ModelClassType Transform Transform Transform Pointer )
            value.State                                     = (CameraState)GetInt32(new IntPtr(p + 0x030)); // 0x30 State                       ( ModelEnumType CameraState CameraState CameraState Int32 )

            return value;
        }
    }
}
