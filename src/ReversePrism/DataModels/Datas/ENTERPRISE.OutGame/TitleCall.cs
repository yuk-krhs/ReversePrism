using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CueSheetName                             ModelPrimitiveType string string string String
    // 018 IsFirstPlay                              ModelPrimitiveType bool bool bool Bool
    public partial class TitleCall : DataModel
    {
        public string                                   CueSheetName                            { get; set; }
        public bool                                     IsFirstPlay                             { get; set; }

        public static TitleCall? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TitleCall() { Pointer= p0 };

            value.CueSheetName                              = GetString(new IntPtr(p + 0x010)); // 0x10 CueSheetName                ( ModelPrimitiveType string string string String )
            value.IsFirstPlay                               = GetBool(new IntPtr(p + 0x018)); // 0x18 IsFirstPlay                 ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
