using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_array                                  000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 018 M_length                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C Version                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 _syncRoot                                <object> IL2CPP_TYPE_OBJECT
    public partial class BitArray
    {
        public List<int>?                               M_array                                 { get; set; }
        public int                                      M_length                                { get; set; }
        public int                                      Version                                 { get; set; }

        public static BitArray? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BitArray();

            value.M_array                                   = GetInt32List(new IntPtr(p + 0x010)); // 027004461970 0x10 M_array                     ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.M_length                                  = GetInt32(new IntPtr(p + 0x018)); // 027004461990 0x18 M_length                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Version                                   = GetInt32(new IntPtr(p + 0x01C)); // 0270044619B0 0x1C Version                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
