using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Raycast3D                                0001866BD450 ModelClassType Raycast3DCallback Raycast3DCallback Raycast3DCallback Pointer
    // 018 Raycast3DAll                             0001866BD960 ModelClassType RaycastAllCallback RaycastAllCallback RaycastAllCallback Pointer
    // 020 GetRaycastNonAlloc                       0001866BCAD0 ModelClassType GetRaycastNonAllocCallback GetRaycastNonAllocCallback GetRaycastNonAllocCallback Pointer
    // 028 Raycast2D                                0001866BCFB0 ModelClassType Raycast2DCallback Raycast2DCallback Raycast2DCallback Pointer
    // 030 GetRayIntersectionAll                    0001866BC150 ModelClassType GetRayIntersectionAllCallback GetRayIntersectionAllCallback GetRayIntersectionAllCallback Pointer
    // 038 GetRayIntersectionAllNonAlloc            0001866BC5F0 ModelClassType GetRayIntersectionAllNonAllocCallback GetRayIntersectionAllNonAllocCallback GetRayIntersectionAllNonAllocCallback Pointer
    // 000 s_ReflectionMethodsCache                 ReflectionMethodsCache IL2CPP_TYPE_CLASS
    public partial class ReflectionMethodsCache : DataModel
    {
        public Raycast3DCallback?                       Raycast3D                               { get; set; }
        public RaycastAllCallback?                      Raycast3DAll                            { get; set; }
        public GetRaycastNonAllocCallback?              GetRaycastNonAlloc                      { get; set; }
        public Raycast2DCallback?                       Raycast2D                               { get; set; }
        public GetRayIntersectionAllCallback?           GetRayIntersectionAll                   { get; set; }
        public GetRayIntersectionAllNonAllocCallback?   GetRayIntersectionAllNonAlloc           { get; set; }

        public static ReflectionMethodsCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReflectionMethodsCache() { Pointer= p0 };

            value.Raycast3D                                 = GetObject<Raycast3DCallback>(new IntPtr(p + 0x010), ReversePrism.DataModels.Raycast3DCallback.FromPointer); // 0245A68A3FC0 0x10 Raycast3D                   ( 0001866BD450 ModelClassType Raycast3DCallback Raycast3DCallback Raycast3DCallback Pointer )
            value.Raycast3DAll                              = GetObject<RaycastAllCallback>(new IntPtr(p + 0x018), ReversePrism.DataModels.RaycastAllCallback.FromPointer); // 0245A68A3FE0 0x18 Raycast3DAll                ( 0001866BD960 ModelClassType RaycastAllCallback RaycastAllCallback RaycastAllCallback Pointer )
            value.GetRaycastNonAlloc                        = GetObject<GetRaycastNonAllocCallback>(new IntPtr(p + 0x020), ReversePrism.DataModels.GetRaycastNonAllocCallback.FromPointer); // 0245A68A4000 0x20 GetRaycastNonAlloc          ( 0001866BCAD0 ModelClassType GetRaycastNonAllocCallback GetRaycastNonAllocCallback GetRaycastNonAllocCallback Pointer )
            value.Raycast2D                                 = GetObject<Raycast2DCallback>(new IntPtr(p + 0x028), ReversePrism.DataModels.Raycast2DCallback.FromPointer); // 0245A68A4020 0x28 Raycast2D                   ( 0001866BCFB0 ModelClassType Raycast2DCallback Raycast2DCallback Raycast2DCallback Pointer )
            value.GetRayIntersectionAll                     = GetObject<GetRayIntersectionAllCallback>(new IntPtr(p + 0x030), ReversePrism.DataModels.GetRayIntersectionAllCallback.FromPointer); // 0245A68A4040 0x30 GetRayIntersectionAll       ( 0001866BC150 ModelClassType GetRayIntersectionAllCallback GetRayIntersectionAllCallback GetRayIntersectionAllCallback Pointer )
            value.GetRayIntersectionAllNonAlloc             = GetObject<GetRayIntersectionAllNonAllocCallback>(new IntPtr(p + 0x038), ReversePrism.DataModels.GetRayIntersectionAllNonAllocCallback.FromPointer); // 0245A68A4060 0x38 GetRayIntersectionAllNonAlloc ( 0001866BC5F0 ModelClassType GetRayIntersectionAllNonAllocCallback GetRayIntersectionAllNonAllocCallback GetRayIntersectionAllNonAllocCallback Pointer )

            return value;
        }
    }
}
