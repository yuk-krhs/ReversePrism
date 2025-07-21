using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsValid                                  ModelPrimitiveType bool bool bool Bool
    // 014 PageAndID                                ModelEnumType Color32 Color32 Color32 Int32
    public partial class ColorPage : DataModel
    {
        public bool                                     IsValid                                 { get; set; }
        public Color32                                  PageAndID                               { get; set; }

        public static ColorPage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColorPage() { Pointer= p0 };

            value.IsValid                                   = GetBool(new IntPtr(p + 0x010)); // 0x10 IsValid                     ( ModelPrimitiveType bool bool bool Bool )
            value.PageAndID                                 = (Color32)GetInt32(new IntPtr(p + 0x014)); // 0x14 PageAndID                   ( ModelEnumType Color32 Color32 Color32 Int32 )

            return value;
        }
    }
}
