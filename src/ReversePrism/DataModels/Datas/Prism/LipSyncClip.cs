using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Behaviour                                ModelClassType LipSyncBehaviour LipSyncBehaviour LipSyncBehaviour Pointer
    public partial class LipSyncClip : DataModel
    {
        public LipSyncBehaviour?                        Behaviour                               { get; set; }

        public static LipSyncClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LipSyncClip() { Pointer= p0 };

            value.Behaviour                                 = GetObject<LipSyncBehaviour>(new IntPtr(p + 0x018), ReversePrism.DataModels.LipSyncBehaviour.FromPointer); // 0x18 Behaviour                   ( ModelClassType LipSyncBehaviour LipSyncBehaviour LipSyncBehaviour Pointer )

            return value;
        }
    }
}
