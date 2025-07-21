using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Behaviour                                ModelClassType SwayBoneWindBehaviour SwayBoneWindBehaviour SwayBoneWindBehaviour Pointer
    public partial class SwayBoneWindClip : DataModel
    {
        public SwayBoneWindBehaviour?                   Behaviour                               { get; set; }

        public static SwayBoneWindClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SwayBoneWindClip() { Pointer= p0 };

            value.Behaviour                                 = GetObject<SwayBoneWindBehaviour>(new IntPtr(p + 0x018), ReversePrism.DataModels.SwayBoneWindBehaviour.FromPointer); // 0x18 Behaviour                   ( ModelClassType SwayBoneWindBehaviour SwayBoneWindBehaviour SwayBoneWindBehaviour Pointer )

            return value;
        }
    }
}
