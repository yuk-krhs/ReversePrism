using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Bounds                                   <int> IL2CPP_TYPE_I
    // 018 Count                                    <int> IL2CPP_TYPE_I
    // 020 Data                                     00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class RawData
    {
        public sbyte                                    Data                                    { get; set; }

        public static RawData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RawData();

            value.Data                                      = GetSByte(new IntPtr(p + 0x020)); // 0270D6A36C48 0x20 Data                        ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
