using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 MstTwestaArticleId                       ModelPrimitiveType int int int Int32
    // 018 MstTwestaUserId                          ModelPrimitiveType int int int Int32
    // 01C Delay                                    ModelPrimitiveType int int int Int32
    public partial class MstTwestaComment : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstTwestaArticleId                      { get; set; }
        public int                                      MstTwestaUserId                         { get; set; }
        public int                                      Delay                                   { get; set; }

        public static MstTwestaComment? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstTwestaComment() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.MstTwestaArticleId                        = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstTwestaArticleId          ( ModelPrimitiveType int int int Int32 )
            value.MstTwestaUserId                           = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstTwestaUserId             ( ModelPrimitiveType int int int Int32 )
            value.Delay                                     = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Delay                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
