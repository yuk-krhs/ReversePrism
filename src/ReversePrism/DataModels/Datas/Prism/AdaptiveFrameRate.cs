using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 <move3DFlag>k__BackingField              bool IL2CPP_TYPE_BOOLEAN
    // 001 <force60Flag>k__BackingField             bool IL2CPP_TYPE_BOOLEAN
    // 002 <moveFlag>k__BackingField                bool IL2CPP_TYPE_BOOLEAN
    // 003 <pause3DFlag>k__BackingField             bool IL2CPP_TYPE_BOOLEAN
    public partial class AdaptiveFrameRate
    {

        public static AdaptiveFrameRate? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdaptiveFrameRate();


            return value;
        }
    }
}
