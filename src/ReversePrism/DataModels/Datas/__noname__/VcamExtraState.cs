using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MProfileCopy                             ModelClassType VolumeProfile VolumeProfile VolumeProfile Pointer
    public partial class VcamExtraState : DataModel
    {
        public VolumeProfile?                           MProfileCopy                            { get; set; }

        public static VcamExtraState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VcamExtraState() { Pointer= p0 };

            value.MProfileCopy                              = GetObject<VolumeProfile>(new IntPtr(p + 0x010), ReversePrism.DataModels.VolumeProfile.FromPointer); // 0x10 MProfileCopy                ( ModelClassType VolumeProfile VolumeProfile VolumeProfile Pointer )

            return value;
        }
    }
}
