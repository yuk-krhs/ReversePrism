using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Behaviour                                0001865FBB50 ModelClassType SwayBoneWindBehaviour SwayBoneWindBehaviour SwayBoneWindBehaviour Pointer
    public partial class SwayBoneWindClip
    {
        public SwayBoneWindBehaviour?                   Behaviour                               { get; set; }

        public static SwayBoneWindClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SwayBoneWindClip();

            value.Behaviour                                 = GetObject<SwayBoneWindBehaviour>(new IntPtr(p + 0x018), ReversePrism.DataModels.SwayBoneWindBehaviour.FromPointer); // 0270D4E000E8 0x18 Behaviour                   ( 0001865FBB50 ModelClassType SwayBoneWindBehaviour SwayBoneWindBehaviour SwayBoneWindBehaviour Pointer )

            return value;
        }
    }
}
