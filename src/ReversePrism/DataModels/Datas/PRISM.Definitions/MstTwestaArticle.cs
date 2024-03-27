using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 MstTwestaUserId                          0001865F4260 ModelPrimitiveType int int int Int32
    // 018 Thumbnail                                0001865F4260 ModelPrimitiveType int int int Int32
    // 01C IsDefault                                0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class MstTwestaArticle
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstTwestaUserId                         { get; set; }
        public int                                      Thumbnail                               { get; set; }
        public bool                                     IsDefault                               { get; set; }

        public static MstTwestaArticle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstTwestaArticle();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0270046080C0 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstTwestaUserId                           = GetInt32(new IntPtr(p + 0x014)); // 0270046080E0 0x14 MstTwestaUserId             ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Thumbnail                                 = GetInt32(new IntPtr(p + 0x018)); // 027004608100 0x18 Thumbnail                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IsDefault                                 = GetBool(new IntPtr(p + 0x01C)); // 027004608120 0x1C IsDefault                   ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
