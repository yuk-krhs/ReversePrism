using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _baseLight                               Light IL2CPP_TYPE_CLASS
    // 020 MainCamera                               000186536460 ModelClassType CameraController CameraController CameraController Pointer
    // 028 DropShadowRenderer                       00018665F150 ModelClassType Renderer Renderer Renderer Pointer
    // 030 ShadowMat                                00018660C4B0 ModelClassType Material Material Material Pointer
    // 038 ShadowHairMat                            00018660C4B0 ModelClassType Material Material Material Pointer
    // 040 RootObjList                              000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 008 needReset                                bool IL2CPP_TYPE_BOOLEAN
    // 009 stopDuplicate                            bool IL2CPP_TYPE_BOOLEAN
    // 00A disableDropShadow                        bool IL2CPP_TYPE_BOOLEAN
    // 010 CachedRendererListExecutor               000186522DC0 ModelClassType CachedRendererListExecutor CachedRendererListExecutor CachedRendererListExecutor Pointer
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

            value.MainCamera                                = GetObject<CameraController>(new IntPtr(p + 0x020), ReversePrism.DataModels.CameraController.FromPointer); // 024660EC0FF8 0x20 MainCamera                  ( 000186536460 ModelClassType CameraController CameraController CameraController Pointer )
            value.DropShadowRenderer                        = GetObject<Renderer>(new IntPtr(p + 0x028), ReversePrism.DataModels.Renderer.FromPointer); // 024660EC1018 0x28 DropShadowRenderer          ( 00018665F150 ModelClassType Renderer Renderer Renderer Pointer )
            value.ShadowMat                                 = GetObject<Material>(new IntPtr(p + 0x030), ReversePrism.DataModels.Material.FromPointer); // 024660EC1038 0x30 ShadowMat                   ( 00018660C4B0 ModelClassType Material Material Material Pointer )
            value.ShadowHairMat                             = GetObject<Material>(new IntPtr(p + 0x038), ReversePrism.DataModels.Material.FromPointer); // 024660EC1058 0x38 ShadowHairMat               ( 00018660C4B0 ModelClassType Material Material Material Pointer )
            value.RootObjList                               = GetObjectList<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 024660EC1078 0x40 RootObjList                 ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.CachedRendererListExecutor                = GetObject<CachedRendererListExecutor>(new IntPtr(p + 0x010), ReversePrism.DataModels.CachedRendererListExecutor.FromPointer); // 024660EC10F8 0x10 CachedRendererListExecutor  ( 000186522DC0 ModelClassType CachedRendererListExecutor CachedRendererListExecutor CachedRendererListExecutor Pointer )

            return value;
        }
    }
}
