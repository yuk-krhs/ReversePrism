using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Title                                    ModelPrimitiveType string string string String
    // 018 Url                                      ModelPrimitiveType string string string String
    // 020 UsePopup                                 ModelPrimitiveType bool bool bool Bool
    // 021 CanTouchOutOfRange                       ModelPrimitiveType bool bool bool Bool
    // 028 UrlSchemeCallback                        ModelClassType OverrideUrlDelegate OverrideUrlDelegate OverrideUrlDelegate Pointer
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

            value.Title                                     = GetString(new IntPtr(p + 0x010)); // 0x10 Title                       ( ModelPrimitiveType string string string String )
            value.Url                                       = GetString(new IntPtr(p + 0x018)); // 0x18 Url                         ( ModelPrimitiveType string string string String )
            value.UsePopup                                  = GetBool(new IntPtr(p + 0x020)); // 0x20 UsePopup                    ( ModelPrimitiveType bool bool bool Bool )
            value.CanTouchOutOfRange                        = GetBool(new IntPtr(p + 0x021)); // 0x21 CanTouchOutOfRange          ( ModelPrimitiveType bool bool bool Bool )
            value.UrlSchemeCallback                         = GetObject<OverrideUrlDelegate>(new IntPtr(p + 0x028), ReversePrism.DataModels.OverrideUrlDelegate.FromPointer); // 0x28 UrlSchemeCallback           ( ModelClassType OverrideUrlDelegate OverrideUrlDelegate OverrideUrlDelegate Pointer )

            return value;
        }
    }
}
