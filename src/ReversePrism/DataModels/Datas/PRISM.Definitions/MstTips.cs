using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 MstTipsCategoryId                        0001865F4260 ModelPrimitiveType int int int Int32
    // 018 Weight                                   0001865F4260 ModelPrimitiveType int int int Int32
    public partial class MstTips
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstTipsCategoryId                       { get; set; }
        public int                                      Weight                                  { get; set; }

        public static MstTips? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstTips();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 027003AF9180 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstTipsCategoryId                         = GetInt32(new IntPtr(p + 0x014)); // 027003AF91A0 0x14 MstTipsCategoryId           ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Weight                                    = GetInt32(new IntPtr(p + 0x018)); // 027003AF91C0 0x18 Weight                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
