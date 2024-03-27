using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_array                                  000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 018 M_length                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C Version                                  0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class BitArrayView
    {
        public List<int>?                               M_array                                 { get; set; }
        public int                                      M_length                                { get; set; }
        public int                                      Version                                 { get; set; }

        public static BitArrayView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BitArrayView();

            value.M_array                                   = GetInt32List(new IntPtr(p + 0x010)); // 0270DAF769E0 0x10 M_array                     ( 000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.M_length                                  = GetInt32(new IntPtr(p + 0x018)); // 0270DAF76A00 0x18 M_length                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Version                                   = GetInt32(new IntPtr(p + 0x01C)); // 0270DAF76A20 0x1C Version                     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
