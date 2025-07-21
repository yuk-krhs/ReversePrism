using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Index                                    ModelPrimitiveType long long long Int64
    public partial class Timer : DataModel
    {
        public long                                     Index                                   { get; set; }

        public static Timer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Timer() { Pointer= p0 };

            value.Index                                     = GetInt64(new IntPtr(p + 0x020)); // 0x20 Index                       ( ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
