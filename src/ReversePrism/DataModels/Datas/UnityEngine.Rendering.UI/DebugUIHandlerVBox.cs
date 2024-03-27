using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 M_Container                              0001866A1D00 ModelClassType DebugUIHandlerContainer DebugUIHandlerContainer DebugUIHandlerContainer Pointer
    public partial class DebugUIHandlerVBox
    {
        public DebugUIHandlerContainer?                 M_Container                             { get; set; }

        public static DebugUIHandlerVBox? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugUIHandlerVBox();

            value.M_Container                               = GetObject<DebugUIHandlerContainer>(new IntPtr(p + 0x060), ReversePrism.DataModels.DebugUIHandlerContainer.FromPointer); // 0270D9343598 0x60 M_Container                 ( 0001866A1D00 ModelClassType DebugUIHandlerContainer DebugUIHandlerContainer DebugUIHandlerContainer Pointer )

            return value;
        }
    }
}
