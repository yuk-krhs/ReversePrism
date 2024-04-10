using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Es                                       0001866B1520 ModelClassType DefaultEventSystem DefaultEventSystem DefaultEventSystem Pointer
    public partial class FocusBasedEventSequenceContext : DataModel
    {
        public DefaultEventSystem?                      Es                                      { get; set; }

        public static FocusBasedEventSequenceContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FocusBasedEventSequenceContext() { Pointer= p0 };

            value.Es                                        = GetObject<DefaultEventSystem>(new IntPtr(p + 0x010), ReversePrism.DataModels.DefaultEventSystem.FromPointer); // 0245A6713760 0x10 Es                          ( 0001866B1520 ModelClassType DefaultEventSystem DefaultEventSystem DefaultEventSystem Pointer )

            return value;
        }
    }
}
