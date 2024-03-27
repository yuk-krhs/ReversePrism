using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 T                                        0001866BF4B0 ModelClassType Tween Tween Tween Pointer
    public partial class WaitForRewind
    {
        public Tween?                                   T                                       { get; set; }

        public static WaitForRewind? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WaitForRewind();

            value.T                                         = GetObject<Tween>(new IntPtr(p + 0x010), ReversePrism.DataModels.Tween.FromPointer); // 0270DBD46490 0x10 T                           ( 0001866BF4B0 ModelClassType Tween Tween Tween Pointer )

            return value;
        }
    }
}
