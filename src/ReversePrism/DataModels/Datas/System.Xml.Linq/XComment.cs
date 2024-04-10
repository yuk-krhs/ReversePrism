using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Value                                    000186671BA0 ModelPrimitiveType string string string String
    public partial class XComment : DataModel
    {
        public string                                   Value                                   { get; set; }

        public static XComment? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XComment() { Pointer= p0 };

            value.Value                                     = GetString(new IntPtr(p + 0x028)); // 0246688C3600 0x28 Value                       ( 000186671BA0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
