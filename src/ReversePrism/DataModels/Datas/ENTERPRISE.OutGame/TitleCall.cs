using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CueSheetName                             000186672F10 ModelPrimitiveType string string string String
    // 018 IsFirstPlay                              000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class TitleCall
    {
        public string                                   CueSheetName                            { get; set; }
        public bool                                     IsFirstPlay                             { get; set; }

        public static TitleCall? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TitleCall();

            value.CueSheetName                              = GetString(new IntPtr(p + 0x010)); // 027004372288 0x10 CueSheetName                ( 000186672F10 ModelPrimitiveType string string string String )
            value.IsFirstPlay                               = GetBool(new IntPtr(p + 0x018)); // 0270043722A8 0x18 IsFirstPlay                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
