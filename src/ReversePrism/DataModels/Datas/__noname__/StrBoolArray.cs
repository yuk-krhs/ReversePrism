using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Bits                                     0001865B3730 ModelEnumType <Bits>e__FixedBuffer <Bits>e__FixedBuffer <Bits>e__FixedBuffer Int32
    public partial class StrBoolArray
    {
        public <Bits>e__FixedBuffer                     Bits                                    { get; set; }

        public static StrBoolArray? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StrBoolArray();

            value.Bits                                      = (<Bits>e__FixedBuffer)GetInt32(new IntPtr(p + 0x010)); // 0270DAA219B8 0x10 Bits                        ( 0001865B3730 ModelEnumType <Bits>e__FixedBuffer <Bits>e__FixedBuffer <Bits>e__FixedBuffer Int32 )

            return value;
        }
    }
}
