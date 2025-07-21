using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CharacterLayout                          ModelClassType GameObject GameObject GameObject Pointer
    // 028 ProducerLayout                           ModelClassType GameObject GameObject GameObject Pointer
    // 030 BackgroundParent                         ModelClassType Transform Transform Transform Pointer
    // 038 Animator                                 ModelClassType Animator Animator Animator Pointer
    public partial class IntroductionRewardBackgroundView : DataModel
    {
        public GameObject?                              CharacterLayout                         { get; set; }
        public GameObject?                              ProducerLayout                          { get; set; }
        public Transform?                               BackgroundParent                        { get; set; }
        public Animator?                                Animator                                { get; set; }

        public static IntroductionRewardBackgroundView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionRewardBackgroundView() { Pointer= p0 };

            value.CharacterLayout                           = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 CharacterLayout             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ProducerLayout                            = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 ProducerLayout              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.BackgroundParent                          = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0x30 BackgroundParent            ( ModelClassType Transform Transform Transform Pointer )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x038), ReversePrism.DataModels.Animator.FromPointer); // 0x38 Animator                    ( ModelClassType Animator Animator Animator Pointer )

            return value;
        }
    }
}
