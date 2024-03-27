using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LoadHint                                 00018659AC80 ModelEnumType LoadHint LoadHint LoadHint Int32
    public partial class DefaultDependencyAttribute
    {
        public LoadHint                                 LoadHint                                { get; set; }

        public static DefaultDependencyAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DefaultDependencyAttribute();

            value.LoadHint                                  = (LoadHint)GetInt32(new IntPtr(p + 0x010)); // 0270D6CB0000 0x10 LoadHint                    ( 00018659AC80 ModelEnumType LoadHint LoadHint LoadHint Int32 )

            return value;
        }
    }
}
