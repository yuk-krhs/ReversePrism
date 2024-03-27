using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsValid                                  000186595960 ModelPrimitiveType bool bool bool Bool
    // 014 PageAndID                                0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32
    public partial class ColorPage
    {
        public bool                                     IsValid                                 { get; set; }
        public Color32                                  PageAndID                               { get; set; }

        public static ColorPage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColorPage();

            value.IsValid                                   = GetBool(new IntPtr(p + 0x010)); // 0270067E6B48 0x10 IsValid                     ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.PageAndID                                 = (Color32)GetInt32(new IntPtr(p + 0x014)); // 0270067E6B68 0x14 PageAndID                   ( 0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32 )

            return value;
        }
    }
}
