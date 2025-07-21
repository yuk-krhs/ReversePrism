using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0A8 M_LookAt                                 ModelClassType Transform Transform Transform Pointer
    // 0B0 M_Camera                                 ModelClassType Camera Camera Camera Pointer
    // 0B8 M_State                                  ModelEnumType CameraState CameraState CameraState Int32
    // 1A0 Follow                                   ModelClassType Transform Transform Transform Pointer
    // 1A8 M_BlendHint                              ModelEnumType BlendHint BlendHint BlendHint Int32
    public partial class CinemachineExternalCamera : DataModel
    {
        public Transform?                               M_LookAt                                { get; set; }
        public Camera?                                  M_Camera                                { get; set; }
        public CameraState                              M_State                                 { get; set; }
        public Transform?                               Follow                                  { get; set; }
        public BlendHint                                M_BlendHint                             { get; set; }

        public static CinemachineExternalCamera? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineExternalCamera() { Pointer= p0 };

            value.M_LookAt                                  = GetObject<Transform>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Transform.FromPointer); // 0xA8 M_LookAt                    ( ModelClassType Transform Transform Transform Pointer )
            value.M_Camera                                  = GetObject<Camera>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Camera.FromPointer); // 0xB0 M_Camera                    ( ModelClassType Camera Camera Camera Pointer )
            value.M_State                                   = (CameraState)GetInt32(new IntPtr(p + 0x0B8)); // 0xB8 M_State                     ( ModelEnumType CameraState CameraState CameraState Int32 )
            value.Follow                                    = GetObject<Transform>(new IntPtr(p + 0x1A0), ReversePrism.DataModels.Transform.FromPointer); // 0x1A0 Follow                      ( ModelClassType Transform Transform Transform Pointer )
            value.M_BlendHint                               = (BlendHint)GetInt32(new IntPtr(p + 0x1A8)); // 0x1A8 M_BlendHint                 ( ModelEnumType BlendHint BlendHint BlendHint Int32 )

            return value;
        }
    }
}
