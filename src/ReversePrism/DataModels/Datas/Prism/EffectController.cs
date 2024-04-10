using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 LifeTime                                 0001866656B0 ModelPrimitiveType float float float Single
    // 024 LifeTimer                                0001866656B0 ModelPrimitiveType float float float Single
    // 028 ParticleSystems                          000185B9AC50 ModelClassListType ParticleSystem[] ParticleSystem[] List<ParticleSystem> Pointer
    // 030 IsCompletedSetup                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 031 IsReusable                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 Pool                                     000186720740 ModelClassType EffectManager EffectManager EffectManager Pointer
    // 040 LoadedObj                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 OnEnd                                    000186679A00 ModelClassType Action Action Action Pointer
    // 050 Children                                 000185CACE28 ModelClassListType Transform[] Transform[] List<Transform> Pointer
    // 058 ChildrenPostProcessVolumes               000185CACE28 ModelClassListType Transform[] Transform[] List<Transform> Pointer
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

            value.LifeTime                                  = GetSingle(new IntPtr(p + 0x020)); // 024664DF69E0 0x20 LifeTime                    ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.LifeTimer                                 = GetSingle(new IntPtr(p + 0x024)); // 024664DF6A00 0x24 LifeTimer                   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ParticleSystems                           = GetObjectList<ParticleSystem>(new IntPtr(p + 0x028), ReversePrism.DataModels.ParticleSystem.FromPointer); // 024664DF6A20 0x28 ParticleSystems             ( 000185B9AC50 ModelClassListType ParticleSystem[] ParticleSystem[] List<ParticleSystem> Pointer )
            value.IsCompletedSetup                          = GetBool(new IntPtr(p + 0x030)); // 024664DF6A40 0x30 IsCompletedSetup            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsReusable                                = GetBool(new IntPtr(p + 0x031)); // 024664DF6A60 0x31 IsReusable                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Pool                                      = GetObject<EffectManager>(new IntPtr(p + 0x038), ReversePrism.DataModels.EffectManager.FromPointer); // 024664DF6A80 0x38 Pool                        ( 000186720740 ModelClassType EffectManager EffectManager EffectManager Pointer )
            value.LoadedObj                                 = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 024664DF6AA0 0x40 LoadedObj                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.OnEnd                                     = GetObject<Action>(new IntPtr(p + 0x048), ReversePrism.DataModels.Action.FromPointer); // 024664DF6AC0 0x48 OnEnd                       ( 000186679A00 ModelClassType Action Action Action Pointer )
            value.Children                                  = GetObjectList<Transform>(new IntPtr(p + 0x050), ReversePrism.DataModels.Transform.FromPointer); // 024664DF6AE0 0x50 Children                    ( 000185CACE28 ModelClassListType Transform[] Transform[] List<Transform> Pointer )
            value.ChildrenPostProcessVolumes                = GetObjectList<Transform>(new IntPtr(p + 0x058), ReversePrism.DataModels.Transform.FromPointer); // 024664DF6B00 0x58 ChildrenPostProcessVolumes  ( 000185CACE28 ModelClassListType Transform[] Transform[] List<Transform> Pointer )

            return value;
        }
    }
}
