using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MBIG                                     int IL2CPP_TYPE_I4
    // 000 MSEED                                    int IL2CPP_TYPE_I4
    // 000 MZ                                       int IL2CPP_TYPE_I4
    // 010 Inext                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 Inextp                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 SeedArray                                000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // FFFFFFFF t_threadRandom                           Random IL2CPP_TYPE_CLASS
    // 000 s_globalRandom                           Random IL2CPP_TYPE_CLASS
    public partial class Random
    {
        public int                                      Inext                                   { get; set; }
        public int                                      Inextp                                  { get; set; }
        public List<int>?                               SeedArray                               { get; set; }

        public static Random? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Random();

            value.Inext                                     = GetInt32(new IntPtr(p + 0x010)); // 027003D372F8 0x10 Inext                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Inextp                                    = GetInt32(new IntPtr(p + 0x014)); // 027003D37318 0x14 Inextp                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SeedArray                                 = GetInt32List(new IntPtr(p + 0x018)); // 027003D37338 0x18 SeedArray                   ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
