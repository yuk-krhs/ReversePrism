using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Target                                   0001865D6F20 ModelClassType MarshalByRefObject MarshalByRefObject MarshalByRefObject Pointer
    // 018 Rp                                       000186620660 ModelClassType RealProxy RealProxy RealProxy Pointer
    public partial class StackBuilderSink
    {
        public MarshalByRefObject?                      Target                                  { get; set; }
        public RealProxy?                               Rp                                      { get; set; }

        public static StackBuilderSink? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StackBuilderSink();

            value.Target                                    = GetObject<MarshalByRefObject>(new IntPtr(p + 0x010), ReversePrism.DataModels.MarshalByRefObject.FromPointer); // 0270D6BECAE8 0x10 Target                      ( 0001865D6F20 ModelClassType MarshalByRefObject MarshalByRefObject MarshalByRefObject Pointer )
            value.Rp                                        = GetObject<RealProxy>(new IntPtr(p + 0x018), ReversePrism.DataModels.RealProxy.FromPointer); // 0270D6BECB08 0x18 Rp                          ( 000186620660 ModelClassType RealProxy RealProxy RealProxy Pointer )

            return value;
        }
    }
}
