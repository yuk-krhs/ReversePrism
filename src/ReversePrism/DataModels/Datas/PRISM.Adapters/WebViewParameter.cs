using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Title                                    000186672F10 ModelPrimitiveType string string string String
    // 018 Url                                      000186672F10 ModelPrimitiveType string string string String
    // 020 UsePopup                                 0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 021 CanTouchOutOfRange                       0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 028 UrlSchemeCallback                        0001867100F0 ModelClassType OverrideUrlDelegate OverrideUrlDelegate OverrideUrlDelegate Pointer
    public partial class WebViewParameter : DataModel
    {
        public string                                   Title                                   { get; set; }
        public string                                   Url                                     { get; set; }
        public bool                                     UsePopup                                { get; set; }
        public bool                                     CanTouchOutOfRange                      { get; set; }
        public OverrideUrlDelegate?                     UrlSchemeCallback                       { get; set; }

        public static WebViewParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WebViewParameter() { Pointer= p0 };

            value.Title                                     = GetString(new IntPtr(p + 0x010)); // 02466649C5B0 0x10 Title                       ( 000186672F10 ModelPrimitiveType string string string String )
            value.Url                                       = GetString(new IntPtr(p + 0x018)); // 02466649C5D0 0x18 Url                         ( 000186672F10 ModelPrimitiveType string string string String )
            value.UsePopup                                  = GetBool(new IntPtr(p + 0x020)); // 02466649C5F0 0x20 UsePopup                    ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.CanTouchOutOfRange                        = GetBool(new IntPtr(p + 0x021)); // 02466649C610 0x21 CanTouchOutOfRange          ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.UrlSchemeCallback                         = GetObject<OverrideUrlDelegate>(new IntPtr(p + 0x028), ReversePrism.DataModels.OverrideUrlDelegate.FromPointer); // 02466649C630 0x28 UrlSchemeCallback           ( 0001867100F0 ModelClassType OverrideUrlDelegate OverrideUrlDelegate OverrideUrlDelegate Pointer )

            return value;
        }
    }
}
