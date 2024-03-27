using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TargetTransform                          0001866AA650 ModelClassType Transform Transform Transform Pointer
    // 018 Renderer                                 0001866041A0 ModelClassType MeshRenderer MeshRenderer MeshRenderer Pointer
    public partial class PlaneDropShadowData
    {
        public Transform?                               TargetTransform                         { get; set; }
        public MeshRenderer?                            Renderer                                { get; set; }

        public static PlaneDropShadowData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlaneDropShadowData();

            value.TargetTransform                           = GetObject<Transform>(new IntPtr(p + 0x010), ReversePrism.DataModels.Transform.FromPointer); // 027006AAF488 0x10 TargetTransform             ( 0001866AA650 ModelClassType Transform Transform Transform Pointer )
            value.Renderer                                  = GetObject<MeshRenderer>(new IntPtr(p + 0x018), ReversePrism.DataModels.MeshRenderer.FromPointer); // 027006AAF4A8 0x18 Renderer                    ( 0001866041A0 ModelClassType MeshRenderer MeshRenderer MeshRenderer Pointer )

            return value;
        }
    }
}
