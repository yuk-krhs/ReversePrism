using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsRequestRestricted                      000186596860 ModelPrimitiveType bool bool bool Bool
    // 011 IsResponseRestricted                     000186596860 ModelPrimitiveType bool bool bool Bool
    // 018 Parser                                   0001866AF1D0 ModelClassType HeaderParser HeaderParser HeaderParser Pointer
    // 020 HeaderName                               0001866731A0 ModelPrimitiveType string string string String
    // 028 AllowMultiValues                         000186596860 ModelPrimitiveType bool bool bool Bool
    public partial class HeaderInfo
    {
        public bool                                     IsRequestRestricted                     { get; set; }
        public bool                                     IsResponseRestricted                    { get; set; }
        public HeaderParser?                            Parser                                  { get; set; }
        public string                                   HeaderName                              { get; set; }
        public bool                                     AllowMultiValues                        { get; set; }

        public static HeaderInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HeaderInfo();

            value.IsRequestRestricted                       = GetBool(new IntPtr(p + 0x010)); // 0270D7A312F0 0x10 IsRequestRestricted         ( 000186596860 ModelPrimitiveType bool bool bool Bool )
            value.IsResponseRestricted                      = GetBool(new IntPtr(p + 0x011)); // 0270D7A31310 0x11 IsResponseRestricted        ( 000186596860 ModelPrimitiveType bool bool bool Bool )
            value.Parser                                    = GetObject<HeaderParser>(new IntPtr(p + 0x018), ReversePrism.DataModels.HeaderParser.FromPointer); // 0270D7A31330 0x18 Parser                      ( 0001866AF1D0 ModelClassType HeaderParser HeaderParser HeaderParser Pointer )
            value.HeaderName                                = GetString(new IntPtr(p + 0x020)); // 0270D7A31350 0x20 HeaderName                  ( 0001866731A0 ModelPrimitiveType string string string String )
            value.AllowMultiValues                          = GetBool(new IntPtr(p + 0x028)); // 0270D7A31370 0x28 AllowMultiValues            ( 000186596860 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
