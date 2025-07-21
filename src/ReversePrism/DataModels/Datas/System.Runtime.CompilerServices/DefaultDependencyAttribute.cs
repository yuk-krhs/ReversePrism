using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LoadHint                                 ModelEnumType LoadHint LoadHint LoadHint Int32
    public partial class DefaultDependencyAttribute : DataModel
    {
        public LoadHint                                 LoadHint                                { get; set; }

        public static DefaultDependencyAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DefaultDependencyAttribute() { Pointer= p0 };

            value.LoadHint                                  = (LoadHint)GetInt32(new IntPtr(p + 0x010)); // 0x10 LoadHint                    ( ModelEnumType LoadHint LoadHint LoadHint Int32 )

            return value;
        }
    }
}
