using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Time                                     000186666F40 ModelPrimitiveType float float float Single
    // 014 Speed                                    000186666F40 ModelPrimitiveType float float float Single
    public partial class SpeedChangeEntity
    {
        public float                                    Time                                    { get; set; }
        public float                                    Speed                                   { get; set; }

        public static SpeedChangeEntity? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpeedChangeEntity();

            value.Time                                      = GetSingle(new IntPtr(p + 0x010)); // 0270D4F72FE0 0x10 Time                        ( 000186666F40 ModelPrimitiveType float float float Single )
            value.Speed                                     = GetSingle(new IntPtr(p + 0x014)); // 0270D4F73000 0x14 Speed                       ( 000186666F40 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
