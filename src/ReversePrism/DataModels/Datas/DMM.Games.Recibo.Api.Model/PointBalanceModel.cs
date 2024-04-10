using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PointBalance                             0001865F7700 ModelPrimitiveType long long long Int64
    public partial class PointBalanceModel : DataModel
    {
        public long                                     PointBalance                            { get; set; }

        public static PointBalanceModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PointBalanceModel() { Pointer= p0 };

            value.PointBalance                              = GetInt64(new IntPtr(p + 0x010)); // 02466B4E8080 0x10 PointBalance                ( 0001865F7700 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
