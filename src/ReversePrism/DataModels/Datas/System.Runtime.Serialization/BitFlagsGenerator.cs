using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BitCount                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 Locals                                   000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class BitFlagsGenerator
    {
        public int                                      BitCount                                { get; set; }
        public List<sbyte>?                             Locals                                  { get; set; }

        public static BitFlagsGenerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BitFlagsGenerator();

            value.BitCount                                  = GetInt32(new IntPtr(p + 0x010)); // 027004D4F800 0x10 BitCount                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Locals                                    = GetSByteList(new IntPtr(p + 0x018)); // 027004D4F820 0x18 Locals                      ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
