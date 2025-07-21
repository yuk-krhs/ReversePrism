using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Category                                 ModelEnumType AnnounceCategory AnnounceCategory AnnounceCategory Int32
    // 018 Sprite                                   ModelPrimitiveType string string string String
    public partial class PictgramPair : DataModel
    {
        public AnnounceCategory                         Category                                { get; set; }
        public string                                   Sprite                                  { get; set; }

        public static PictgramPair? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PictgramPair() { Pointer= p0 };

            value.Category                                  = (AnnounceCategory)GetInt32(new IntPtr(p + 0x010)); // 0x10 Category                    ( ModelEnumType AnnounceCategory AnnounceCategory AnnounceCategory Int32 )
            value.Sprite                                    = GetString(new IntPtr(p + 0x018)); // 0x18 Sprite                      ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
