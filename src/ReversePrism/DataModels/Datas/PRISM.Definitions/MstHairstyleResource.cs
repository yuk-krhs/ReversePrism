using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstCharacterInfoId                       ModelPrimitiveType int int int Int32
    // 014 StyleType                                ModelPrimitiveType int int int Int32
    // 018 HairId                                   ModelPrimitiveType int int int Int32
    // 01C HeadWearId                               ModelPrimitiveType int int int Int32
    public partial class MstHairstyleResource : DataModel
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
            var value   = new MstHairstyleResource() { Pointer= p0 };

            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 MstCharacterInfoId          ( ModelPrimitiveType int int int Int32 )
            value.StyleType                                 = GetInt32(new IntPtr(p + 0x014)); // 0x14 StyleType                   ( ModelPrimitiveType int int int Int32 )
            value.HairId                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 HairId                      ( ModelPrimitiveType int int int Int32 )
            value.HeadWearId                                = GetInt32(new IntPtr(p + 0x01C)); // 0x1C HeadWearId                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
