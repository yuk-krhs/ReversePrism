using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Current                                  000186671910 ModelPrimitiveType string string string String
    public partial class Environments : DataModel
    {
        public string                                   Current                                 { get; set; }

        public static Environments? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Environments() { Pointer= p0 };

            value.Current                                   = GetString(new IntPtr(p + 0x010)); // 0245A6637470 0x10 Current                     ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
