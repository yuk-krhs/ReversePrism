using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Behaviour                                ModelClassType LightDirectionConstraintPlayableBehaviour LightDirectionConstraintPlayableBehaviour LightDirectionConstraintPlayableBehaviour Pointer
    public partial class LightDirectionConstraintPlayableAsset : DataModel
    {
        public LightDirectionConstraintPlayableBehaviour? Behaviour                               { get; set; }

        public static LightDirectionConstraintPlayableAsset? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LightDirectionConstraintPlayableAsset() { Pointer= p0 };

            value.Behaviour                                 = GetObject<LightDirectionConstraintPlayableBehaviour>(new IntPtr(p + 0x018), ReversePrism.DataModels.LightDirectionConstraintPlayableBehaviour.FromPointer); // 0x18 Behaviour                   ( ModelClassType LightDirectionConstraintPlayableBehaviour LightDirectionConstraintPlayableBehaviour LightDirectionConstraintPlayableBehaviour Pointer )

            return value;
        }
    }
}
