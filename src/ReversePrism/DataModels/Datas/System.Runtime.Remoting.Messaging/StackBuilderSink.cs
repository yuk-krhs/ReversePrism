using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Target                                   ModelClassType MarshalByRefObject MarshalByRefObject MarshalByRefObject Pointer
    // 018 Rp                                       ModelClassType RealProxy RealProxy RealProxy Pointer
    public partial class StackBuilderSink : DataModel
    {
        public MarshalByRefObject?                      Target                                  { get; set; }
        public RealProxy?                               Rp                                      { get; set; }

        public static StackBuilderSink? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StackBuilderSink() { Pointer= p0 };

            value.Target                                    = GetObject<MarshalByRefObject>(new IntPtr(p + 0x010), ReversePrism.DataModels.MarshalByRefObject.FromPointer); // 0x10 Target                      ( ModelClassType MarshalByRefObject MarshalByRefObject MarshalByRefObject Pointer )
            value.Rp                                        = GetObject<RealProxy>(new IntPtr(p + 0x018), ReversePrism.DataModels.RealProxy.FromPointer); // 0x18 Rp                          ( ModelClassType RealProxy RealProxy RealProxy Pointer )

            return value;
        }
    }
}
