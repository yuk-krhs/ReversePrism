using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 List                                     00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    public partial class TraceListenerCollection
    {
        public ArrayList?                               List                                    { get; set; }

        public static TraceListenerCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TraceListenerCollection();

            value.List                                      = GetObject<ArrayList>(new IntPtr(p + 0x010), ReversePrism.DataModels.ArrayList.FromPointer); // 027004D03058 0x10 List                        ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )

            return value;
        }
    }
}
