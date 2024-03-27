using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstCharacterInfoId                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 StyleType                                0001865F4260 ModelPrimitiveType int int int Int32
    // 018 HairId                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 01C HeadWearId                               0001865F4260 ModelPrimitiveType int int int Int32
    public partial class MstHairstyleResource
    {
        public int                                      MstCharacterInfoId                      { get; set; }
        public int                                      StyleType                               { get; set; }
        public int                                      HairId                                  { get; set; }
        public int                                      HeadWearId                              { get; set; }

        public static MstHairstyleResource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstHairstyleResource();

            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x010)); // 0270045D2920 0x10 MstCharacterInfoId          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.StyleType                                 = GetInt32(new IntPtr(p + 0x014)); // 0270045D2940 0x14 StyleType                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.HairId                                    = GetInt32(new IntPtr(p + 0x018)); // 0270045D2960 0x18 HairId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.HeadWearId                                = GetInt32(new IntPtr(p + 0x01C)); // 0270045D2980 0x1C HeadWearId                  ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
