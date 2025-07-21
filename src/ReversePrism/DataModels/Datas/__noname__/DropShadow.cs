using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _baseLight                               Light IL2CPP_TYPE_CLASS
    // 020 MainCamera                               ModelClassType CameraController CameraController CameraController Pointer
    // 028 DropShadowRenderer                       ModelClassType Renderer Renderer Renderer Pointer
    // 030 ShadowMat                                ModelClassType Material Material Material Pointer
    // 038 ShadowHairMat                            ModelClassType Material Material Material Pointer
    // 040 RootObjList                              ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 008 needReset                                bool IL2CPP_TYPE_BOOLEAN
    // 009 stopDuplicate                            bool IL2CPP_TYPE_BOOLEAN
    // 00A disableDropShadow                        bool IL2CPP_TYPE_BOOLEAN
    // 010 CachedRendererListExecutor               ModelClassType CachedRendererListExecutor CachedRendererListExecutor CachedRendererListExecutor Pointer
    public partial class DropShadow : DataModel
    {
        public CameraController?                        MainCamera                              { get; set; }
        public Renderer?                                DropShadowRenderer                      { get; set; }
        public Material?                                ShadowMat                               { get; set; }
        public Material?                                ShadowHairMat                           { get; set; }
        public List<GameObject>?                        RootObjList                             { get; set; }
        public CachedRendererListExecutor?              CachedRendererListExecutor              { get; set; }

        public static DropShadow? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DropShadow() { Pointer= p0 };

            value.MainCamera                                = GetObject<CameraController>(new IntPtr(p + 0x020), ReversePrism.DataModels.CameraController.FromPointer); // 0x20 MainCamera                  ( ModelClassType CameraController CameraController CameraController Pointer )
            value.DropShadowRenderer                        = GetObject<Renderer>(new IntPtr(p + 0x028), ReversePrism.DataModels.Renderer.FromPointer); // 0x28 DropShadowRenderer          ( ModelClassType Renderer Renderer Renderer Pointer )
            value.ShadowMat                                 = GetObject<Material>(new IntPtr(p + 0x030), ReversePrism.DataModels.Material.FromPointer); // 0x30 ShadowMat                   ( ModelClassType Material Material Material Pointer )
            value.ShadowHairMat                             = GetObject<Material>(new IntPtr(p + 0x038), ReversePrism.DataModels.Material.FromPointer); // 0x38 ShadowHairMat               ( ModelClassType Material Material Material Pointer )
            value.RootObjList                               = GetObjectList<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 RootObjList                 ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.CachedRendererListExecutor                = GetObject<CachedRendererListExecutor>(new IntPtr(p + 0x010), ReversePrism.DataModels.CachedRendererListExecutor.FromPointer); // 0x10 CachedRendererListExecutor  ( ModelClassType CachedRendererListExecutor CachedRendererListExecutor CachedRendererListExecutor Pointer )

            return value;
        }
    }
}
