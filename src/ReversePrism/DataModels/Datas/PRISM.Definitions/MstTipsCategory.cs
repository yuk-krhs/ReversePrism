using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 018 Color                                    000186672F10 ModelPrimitiveType string string string String
    public partial class MstTipsCategory
    {
        public int                                      Id                                      { get; set; }
        public string                                   Color                                   { get; set; }

        public static MstTipsCategory? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstTipsCategory();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 027004652678 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Color                                     = GetString(new IntPtr(p + 0x018)); // 027004652698 0x18 Color                       ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
