using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Context                                  0001866B6090 ModelClassType DefaultSerializationContext DefaultSerializationContext DefaultSerializationContext Pointer
    public partial class UsageScope : DataModel
    {
        public DefaultSerializationContext?             Context                                 { get; set; }

        public static UsageScope? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UsageScope() { Pointer= p0 };

            value.Context                                   = GetObject<DefaultSerializationContext>(new IntPtr(p + 0x010), ReversePrism.DataModels.DefaultSerializationContext.FromPointer); // 0246694135E8 0x10 Context                     ( 0001866B6090 ModelClassType DefaultSerializationContext DefaultSerializationContext DefaultSerializationContext Pointer )

            return value;
        }
    }
}
