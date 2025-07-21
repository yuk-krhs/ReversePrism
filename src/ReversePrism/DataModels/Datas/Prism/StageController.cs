using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SpotLight                                ModelClassType GameObject GameObject GameObject Pointer
    // 028 CaptureDisplay                           ModelClassType CaptureDisplay CaptureDisplay CaptureDisplay Pointer
    // 030 MainLight                                ModelClassType Light Light Light Pointer
    // 038 NeonPattern                              ModelClassType Texture2D Texture2D Texture2D Pointer
    // 040 _lightObjectGroups                       Dictionary`2<int, List`1<GameObject>> IL2CPP_TYPE_GENERICINST
    // 048 SpotLightList                            ModelClassListType List`1<SpotLightController> List`1<SpotLightController> List<SpotLightController> Pointer
    // 050 ReflectionPlanes                         ModelClassListType ReflectionPlane[] ReflectionPlane[] List<ReflectionPlane> Pointer
    // 058 EffectControllerList                     ModelClassListType List`1<EffectController> List`1<EffectController> List<EffectController> Pointer
    // 060 CachedRendererListExecutor               ModelClassType CachedRendererListExecutor CachedRendererListExecutor CachedRendererListExecutor Pointer
    public partial class StageController : DataModel
    {
        public GameObject?                              SpotLight                               { get; set; }
        public CaptureDisplay?                          CaptureDisplay                          { get; set; }
        public Light?                                   MainLight                               { get; set; }
        public Texture2D?                               NeonPattern                             { get; set; }
        public List<SpotLightController>?               SpotLightList                           { get; set; }
        public List<ReflectionPlane>?                   ReflectionPlanes                        { get; set; }
        public List<EffectController>?                  EffectControllerList                    { get; set; }
        public CachedRendererListExecutor?              CachedRendererListExecutor              { get; set; }

        public static StageController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StageController() { Pointer= p0 };

            value.SpotLight                                 = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 SpotLight                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CaptureDisplay                            = GetObject<CaptureDisplay>(new IntPtr(p + 0x028), ReversePrism.DataModels.CaptureDisplay.FromPointer); // 0x28 CaptureDisplay              ( ModelClassType CaptureDisplay CaptureDisplay CaptureDisplay Pointer )
            value.MainLight                                 = GetObject<Light>(new IntPtr(p + 0x030), ReversePrism.DataModels.Light.FromPointer); // 0x30 MainLight                   ( ModelClassType Light Light Light Pointer )
            value.NeonPattern                               = GetObject<Texture2D>(new IntPtr(p + 0x038), ReversePrism.DataModels.Texture2D.FromPointer); // 0x38 NeonPattern                 ( ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.SpotLightList                             = GetObjectList<SpotLightController>(new IntPtr(p + 0x048), ReversePrism.DataModels.SpotLightController.FromPointer); // 0x48 SpotLightList               ( ModelClassListType List`1<SpotLightController> List`1<SpotLightController> List<SpotLightController> Pointer )
            value.ReflectionPlanes                          = GetObjectList<ReflectionPlane>(new IntPtr(p + 0x050), ReversePrism.DataModels.ReflectionPlane.FromPointer); // 0x50 ReflectionPlanes            ( ModelClassListType ReflectionPlane[] ReflectionPlane[] List<ReflectionPlane> Pointer )
            value.EffectControllerList                      = GetObjectList<EffectController>(new IntPtr(p + 0x058), ReversePrism.DataModels.EffectController.FromPointer); // 0x58 EffectControllerList        ( ModelClassListType List`1<EffectController> List`1<EffectController> List<EffectController> Pointer )
            value.CachedRendererListExecutor                = GetObject<CachedRendererListExecutor>(new IntPtr(p + 0x060), ReversePrism.DataModels.CachedRendererListExecutor.FromPointer); // 0x60 CachedRendererListExecutor  ( ModelClassType CachedRendererListExecutor CachedRendererListExecutor CachedRendererListExecutor Pointer )

            return value;
        }
    }
}
