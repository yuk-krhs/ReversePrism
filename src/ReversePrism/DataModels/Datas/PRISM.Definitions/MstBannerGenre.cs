using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 018 ResourceId                               000186672F10 ModelPrimitiveType string string string String
    public partial class MstBannerGenre
    {
        public int                                      Id                                      { get; set; }
        public string                                   ResourceId                              { get; set; }

        public static MstBannerGenre? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstBannerGenre();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 02700464D8F0 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ResourceId                                = GetString(new IntPtr(p + 0x018)); // 02700464D910 0x18 ResourceId                  ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
