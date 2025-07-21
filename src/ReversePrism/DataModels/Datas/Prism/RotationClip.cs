using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Behaviour                                ModelClassType RotationBehaviour RotationBehaviour RotationBehaviour Pointer
    public partial class RotationClip : DataModel
    {
        public RotationBehaviour?                       Behaviour                               { get; set; }

        public static RotationClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RotationClip() { Pointer= p0 };

            value.Behaviour                                 = GetObject<RotationBehaviour>(new IntPtr(p + 0x018), ReversePrism.DataModels.RotationBehaviour.FromPointer); // 0x18 Behaviour                   ( ModelClassType RotationBehaviour RotationBehaviour RotationBehaviour Pointer )

            return value;
        }
    }
}
