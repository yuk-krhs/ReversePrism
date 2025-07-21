using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 MstTwestaUserId                          ModelPrimitiveType int int int Int32
    // 018 Thumbnail                                ModelPrimitiveType int int int Int32
    // 01C IsDefault                                ModelPrimitiveType bool bool bool Bool
    // 01D HasExtraThumbnail                        ModelPrimitiveType bool bool bool Bool
    public partial class MstTwestaArticle : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstTwestaUserId                         { get; set; }
        public int                                      Thumbnail                               { get; set; }
        public bool                                     IsDefault                               { get; set; }
        public bool                                     HasExtraThumbnail                       { get; set; }

        public static MstTwestaArticle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstTwestaArticle() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.MstTwestaUserId                           = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstTwestaUserId             ( ModelPrimitiveType int int int Int32 )
            value.Thumbnail                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 Thumbnail                   ( ModelPrimitiveType int int int Int32 )
            value.IsDefault                                 = GetBool(new IntPtr(p + 0x01C)); // 0x1C IsDefault                   ( ModelPrimitiveType bool bool bool Bool )
            value.HasExtraThumbnail                         = GetBool(new IntPtr(p + 0x01D)); // 0x1D HasExtraThumbnail           ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
