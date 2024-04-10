using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Timer                                    00018658D980 ModelClassType StopWatchBase StopWatchBase StopWatchBase Pointer
    // 028 ConstructedDateTime                      0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
    public partial class StopWatchObject : DataModel
    {
        public StopWatchBase?                           Timer                                   { get; set; }
        public DateTime                                 ConstructedDateTime                     { get; set; }

        public static StopWatchObject? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StopWatchObject() { Pointer= p0 };

            value.Timer                                     = GetObject<StopWatchBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.StopWatchBase.FromPointer); // 024660EB28C0 0x20 Timer                       ( 00018658D980 ModelClassType StopWatchBase StopWatchBase StopWatchBase Pointer )
            value.ConstructedDateTime                       = GetDateTime(new IntPtr(p + 0x028)); // 024660EB28E0 0x28 ConstructedDateTime         ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
