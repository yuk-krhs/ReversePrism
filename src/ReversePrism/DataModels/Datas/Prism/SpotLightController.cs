using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BeamRotateOffsetEuler                    0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 030 BeamTransform                            0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 038 Rotater                                  0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 040 OnRoot                                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 OffRoot                                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 LightBeam                                000186525040 ModelClassType LightBeam LightBeam LightBeam Pointer
    // 058 SwingTweener                             0001866C3DE0 ModelClassType Tweener Tweener Tweener Pointer
    public partial class SpotLightController
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
            var value   = new SpotLightController();

            value.BeamRotateOffsetEuler                     = (Vector3)GetInt32(new IntPtr(p + 0x020)); // 0270D4E8C078 0x20 BeamRotateOffsetEuler       ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.BeamTransform                             = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0270D4E8C098 0x30 BeamTransform               ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.Rotater                                   = GetObject<Transform>(new IntPtr(p + 0x038), ReversePrism.DataModels.Transform.FromPointer); // 0270D4E8C0B8 0x38 Rotater                     ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.OnRoot                                    = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4E8C0D8 0x40 OnRoot                      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.OffRoot                                   = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4E8C0F8 0x48 OffRoot                     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.LightBeam                                 = GetObject<LightBeam>(new IntPtr(p + 0x050), ReversePrism.DataModels.LightBeam.FromPointer); // 0270D4E8C118 0x50 LightBeam                   ( 000186525040 ModelClassType LightBeam LightBeam LightBeam Pointer )
            value.SwingTweener                              = GetObject<Tweener>(new IntPtr(p + 0x058), ReversePrism.DataModels.Tweener.FromPointer); // 0270D4E8C138 0x58 SwingTweener                ( 0001866C3DE0 ModelClassType Tweener Tweener Tweener Pointer )

            return value;
        }
    }
}
