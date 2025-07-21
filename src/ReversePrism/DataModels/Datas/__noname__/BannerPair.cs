using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Category                                 ModelEnumType AnnounceCategory AnnounceCategory AnnounceCategory Int32
    // 018 Texture                                  ModelPrimitiveType string string string String
    public partial class BannerPair : DataModel
    {
        public AnnounceCategory                         Category                                { get; set; }
        public string                                   Texture                                 { get; set; }

        public static BannerPair? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BannerPair() { Pointer= p0 };

            value.Category                                  = (AnnounceCategory)GetInt32(new IntPtr(p + 0x010)); // 0x10 Category                    ( ModelEnumType AnnounceCategory AnnounceCategory AnnounceCategory Int32 )
            value.Texture                                   = GetString(new IntPtr(p + 0x018)); // 0x18 Texture                     ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
