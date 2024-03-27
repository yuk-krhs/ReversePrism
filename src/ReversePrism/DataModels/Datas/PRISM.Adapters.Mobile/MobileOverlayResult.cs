using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ViewJumper                               00018667A3C0 ModelClassType Action Action Action Pointer
    public partial class MobileOverlayResult
    {
        public Action?                                  ViewJumper                              { get; set; }

        public static MobileOverlayResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MobileOverlayResult();

            value.ViewJumper                                = GetObject<Action>(new IntPtr(p + 0x010), ReversePrism.DataModels.Action.FromPointer); // 0270D61EF7F0 0x10 ViewJumper                  ( 00018667A3C0 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
