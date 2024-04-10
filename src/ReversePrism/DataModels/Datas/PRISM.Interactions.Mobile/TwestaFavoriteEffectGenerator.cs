using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 FavoriteEffectAnimatorNameIdle           0001865F4260 ModelPrimitiveType int int int Int32
    // 024 FavoriteEffectAnimatorNameOn             0001865F4260 ModelPrimitiveType int int int Int32
    // 028 TwestaFavoriteEffect                     0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 030 TargetPos                                0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 038 effectPool                               ObjectPool`1<Animator> IL2CPP_TYPE_GENERICINST
    public partial class TwestaFavoriteEffectGenerator : DataModel
    {
        public int                                      FavoriteEffectAnimatorNameIdle          { get; set; }
        public int                                      FavoriteEffectAnimatorNameOn            { get; set; }
        public Animator?                                TwestaFavoriteEffect                    { get; set; }
        public Transform?                               TargetPos                               { get; set; }

        public static TwestaFavoriteEffectGenerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwestaFavoriteEffectGenerator() { Pointer= p0 };

            value.FavoriteEffectAnimatorNameIdle            = GetInt32(new IntPtr(p + 0x020)); // 02466B1D57B0 0x20 FavoriteEffectAnimatorNameIdle ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.FavoriteEffectAnimatorNameOn              = GetInt32(new IntPtr(p + 0x024)); // 02466B1D57D0 0x24 FavoriteEffectAnimatorNameOn ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.TwestaFavoriteEffect                      = GetObject<Animator>(new IntPtr(p + 0x028), ReversePrism.DataModels.Animator.FromPointer); // 02466B1D57F0 0x28 TwestaFavoriteEffect        ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.TargetPos                                 = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 02466B1D5810 0x30 TargetPos                   ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
