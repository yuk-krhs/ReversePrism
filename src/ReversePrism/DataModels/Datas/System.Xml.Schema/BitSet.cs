using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Count                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 Bits                                     000185B83830 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    public partial class BitSet : DataModel
    {
        public int                                      Count                                   { get; set; }
        public List<uint>?                              Bits                                    { get; set; }

        public static BitSet? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BitSet() { Pointer= p0 };

            value.Count                                     = GetInt32(new IntPtr(p + 0x010)); // 0246675588B0 0x10 Count                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Bits                                      = GetUInt32List(new IntPtr(p + 0x018)); // 0246675588D0 0x18 Bits                        ( 000185B83830 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )

            return value;
        }
    }
}
