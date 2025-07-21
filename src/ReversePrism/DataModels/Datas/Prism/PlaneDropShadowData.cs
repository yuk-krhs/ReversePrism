using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TargetTransform                          ModelClassType Transform Transform Transform Pointer
    // 018 Renderer                                 ModelClassType MeshRenderer MeshRenderer MeshRenderer Pointer
    public partial class PlaneDropShadowData : DataModel
    {
        public Transform?                               TargetTransform                         { get; set; }
        public MeshRenderer?                            Renderer                                { get; set; }

        public static PlaneDropShadowData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlaneDropShadowData() { Pointer= p0 };

            value.TargetTransform                           = GetObject<Transform>(new IntPtr(p + 0x010), ReversePrism.DataModels.Transform.FromPointer); // 0x10 TargetTransform             ( ModelClassType Transform Transform Transform Pointer )
            value.Renderer                                  = GetObject<MeshRenderer>(new IntPtr(p + 0x018), ReversePrism.DataModels.MeshRenderer.FromPointer); // 0x18 Renderer                    ( ModelClassType MeshRenderer MeshRenderer MeshRenderer Pointer )

            return value;
        }
    }
}
