using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Builder                                  000186663A40 ModelClassType ADVLogBuilder ADVLogBuilder ADVLogBuilder Pointer
    public partial class ADVLogCallerImplement : DataModel
    {
        public ADVLogBuilder?                           Builder                                 { get; set; }

        public static ADVLogCallerImplement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ADVLogCallerImplement() { Pointer= p0 };

            value.Builder                                   = GetObject<ADVLogBuilder>(new IntPtr(p + 0x020), ReversePrism.DataModels.ADVLogBuilder.FromPointer); // 02466BA6DA08 0x20 Builder                     ( 000186663A40 ModelClassType ADVLogBuilder ADVLogBuilder ADVLogBuilder Pointer )

            return value;
        }
    }
}
