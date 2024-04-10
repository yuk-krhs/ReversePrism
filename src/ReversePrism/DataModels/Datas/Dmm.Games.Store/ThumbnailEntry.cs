using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001866722E0 ModelPrimitiveType string string string String
    // 018 Url                                      0001866722E0 ModelPrimitiveType string string string String
    public partial class ThumbnailEntry : DataModel
    {
        public string                                   Id                                      { get; set; }
        public string                                   Url                                     { get; set; }

        public static ThumbnailEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ThumbnailEntry() { Pointer= p0 };

            value.Id                                        = GetString(new IntPtr(p + 0x010)); // 02466B556978 0x10 Id                          ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Url                                       = GetString(new IntPtr(p + 0x018)); // 02466B556998 0x18 Url                         ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
