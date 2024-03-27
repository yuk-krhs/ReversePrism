using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Category                                 0001865EA690 ModelEnumType AnnounceCategory AnnounceCategory AnnounceCategory Int32
    // 018 Texture                                  0001866722E0 ModelPrimitiveType string string string String
    public partial class BannerPair
    {
        public AnnounceCategory                         Category                                { get; set; }
        public string                                   Texture                                 { get; set; }

        public static BannerPair? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BannerPair();

            value.Category                                  = (AnnounceCategory)GetInt32(new IntPtr(p + 0x010)); // 0270DBDDAE08 0x10 Category                    ( 0001865EA690 ModelEnumType AnnounceCategory AnnounceCategory AnnounceCategory Int32 )
            value.Texture                                   = GetString(new IntPtr(p + 0x018)); // 0270DBDDAE28 0x18 Texture                     ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
