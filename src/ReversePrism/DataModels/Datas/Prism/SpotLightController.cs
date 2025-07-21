using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BeamRotateOffsetEuler                    ModelEnumType Vector3 Vector3 Vector3 Int32
    // 030 BeamTransform                            ModelClassType Transform Transform Transform Pointer
    // 038 Rotater                                  ModelClassType Transform Transform Transform Pointer
    // 040 OnRoot                                   ModelClassType GameObject GameObject GameObject Pointer
    // 048 OffRoot                                  ModelClassType GameObject GameObject GameObject Pointer
    // 050 LightBeam                                ModelClassType LightBeam LightBeam LightBeam Pointer
    // 058 SwingTweener                             ModelClassType Tweener Tweener Tweener Pointer
    public partial class SpotLightController : DataModel
    {
        public Vector3                                  BeamRotateOffsetEuler                   { get; set; }
        public Transform?                               BeamTransform                           { get; set; }
        public Transform?                               Rotater                                 { get; set; }
        public GameObject?                              OnRoot                                  { get; set; }
        public GameObject?                              OffRoot                                 { get; set; }
        public LightBeam?                               LightBeam                               { get; set; }
        public Tweener?                                 SwingTweener                            { get; set; }

        public static SpotLightController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpotLightController() { Pointer= p0 };

            value.BeamRotateOffsetEuler                     = (Vector3)GetInt32(new IntPtr(p + 0x020)); // 0x20 BeamRotateOffsetEuler       ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.BeamTransform                             = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0x30 BeamTransform               ( ModelClassType Transform Transform Transform Pointer )
            value.Rotater                                   = GetObject<Transform>(new IntPtr(p + 0x038), ReversePrism.DataModels.Transform.FromPointer); // 0x38 Rotater                     ( ModelClassType Transform Transform Transform Pointer )
            value.OnRoot                                    = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 OnRoot                      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.OffRoot                                   = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 OffRoot                     ( ModelClassType GameObject GameObject GameObject Pointer )
            value.LightBeam                                 = GetObject<LightBeam>(new IntPtr(p + 0x050), ReversePrism.DataModels.LightBeam.FromPointer); // 0x50 LightBeam                   ( ModelClassType LightBeam LightBeam LightBeam Pointer )
            value.SwingTweener                              = GetObject<Tweener>(new IntPtr(p + 0x058), ReversePrism.DataModels.Tweener.FromPointer); // 0x58 SwingTweener                ( ModelClassType Tweener Tweener Tweener Pointer )

            return value;
        }
    }
}
