using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PurchaseState                            ModelPrimitiveType int int int Int32
    public partial class Json : DataModel
    {
        public int                                      PurchaseState                           { get; set; }

        public static Json? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Json() { Pointer= p0 };

            value.PurchaseState                             = GetInt32(new IntPtr(p + 0x010)); // 0x10 PurchaseState               ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
