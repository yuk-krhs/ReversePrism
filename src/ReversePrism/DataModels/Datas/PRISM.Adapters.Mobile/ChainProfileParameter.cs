using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ChainUserId                              0001865F4260 ModelPrimitiveType int int int Int32
    public partial class ChainProfileParameter : DataModel
    {
        public int                                      ChainUserId                             { get; set; }

        public static ChainProfileParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainProfileParameter() { Pointer= p0 };

            value.ChainUserId                               = GetInt32(new IntPtr(p + 0x010)); // 0246668C5F18 0x10 ChainUserId                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
