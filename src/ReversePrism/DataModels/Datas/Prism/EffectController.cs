using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 LifeTime                                 ModelPrimitiveType float float float Single
    // 024 LifeTimer                                ModelPrimitiveType float float float Single
    // 028 ParticleSystems                          ModelClassListType ParticleSystem[] ParticleSystem[] List<ParticleSystem> Pointer
    // 030 IsCompletedSetup                         ModelPrimitiveType bool bool bool Bool
    // 031 IsReusable                               ModelPrimitiveType bool bool bool Bool
    // 038 Pool                                     ModelClassType EffectManager EffectManager EffectManager Pointer
    // 040 LoadedObj                                ModelClassType GameObject GameObject GameObject Pointer
    // 048 OnEnd                                    ModelClassType Action Action Action Pointer
    // 050 Children                                 ModelClassListType Transform[] Transform[] List<Transform> Pointer
    // 058 ChildrenPostProcessVolumes               ModelClassListType Transform[] Transform[] List<Transform> Pointer
    public partial class EffectController : DataModel
    {
        public float                                    LifeTime                                { get; set; }
        public float                                    LifeTimer                               { get; set; }
        public List<ParticleSystem>?                    ParticleSystems                         { get; set; }
        public bool                                     IsCompletedSetup                        { get; set; }
        public bool                                     IsReusable                              { get; set; }
        public EffectManager?                           Pool                                    { get; set; }
        public GameObject?                              LoadedObj                               { get; set; }
        public Action?                                  OnEnd                                   { get; set; }
        public List<Transform>?                         Children                                { get; set; }
        public List<Transform>?                         ChildrenPostProcessVolumes              { get; set; }

        public static EffectController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EffectController() { Pointer= p0 };

            value.LifeTime                                  = GetSingle(new IntPtr(p + 0x020)); // 0x20 LifeTime                    ( ModelPrimitiveType float float float Single )
            value.LifeTimer                                 = GetSingle(new IntPtr(p + 0x024)); // 0x24 LifeTimer                   ( ModelPrimitiveType float float float Single )
            value.ParticleSystems                           = GetObjectList<ParticleSystem>(new IntPtr(p + 0x028), ReversePrism.DataModels.ParticleSystem.FromPointer); // 0x28 ParticleSystems             ( ModelClassListType ParticleSystem[] ParticleSystem[] List<ParticleSystem> Pointer )
            value.IsCompletedSetup                          = GetBool(new IntPtr(p + 0x030)); // 0x30 IsCompletedSetup            ( ModelPrimitiveType bool bool bool Bool )
            value.IsReusable                                = GetBool(new IntPtr(p + 0x031)); // 0x31 IsReusable                  ( ModelPrimitiveType bool bool bool Bool )
            value.Pool                                      = GetObject<EffectManager>(new IntPtr(p + 0x038), ReversePrism.DataModels.EffectManager.FromPointer); // 0x38 Pool                        ( ModelClassType EffectManager EffectManager EffectManager Pointer )
            value.LoadedObj                                 = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 LoadedObj                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.OnEnd                                     = GetObject<Action>(new IntPtr(p + 0x048), ReversePrism.DataModels.Action.FromPointer); // 0x48 OnEnd                       ( ModelClassType Action Action Action Pointer )
            value.Children                                  = GetObjectList<Transform>(new IntPtr(p + 0x050), ReversePrism.DataModels.Transform.FromPointer); // 0x50 Children                    ( ModelClassListType Transform[] Transform[] List<Transform> Pointer )
            value.ChildrenPostProcessVolumes                = GetObjectList<Transform>(new IntPtr(p + 0x058), ReversePrism.DataModels.Transform.FromPointer); // 0x58 ChildrenPostProcessVolumes  ( ModelClassListType Transform[] Transform[] List<Transform> Pointer )

            return value;
        }
    }
}
