using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    public partial class MstProduceStrategyType
    {
        public int                                      Id                                      { get; set; }

        public static MstProduceStrategyType? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstProduceStrategyType();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0270045A02A8 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
