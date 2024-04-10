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
    public partial class HeaderInfo : DataModel
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
            var value   = new HeaderInfo() { Pointer= p0 };

            value.IsRequestRestricted                       = GetBool(new IntPtr(p + 0x010)); // 024667A912F0 0x10 IsRequestRestricted         ( 000186596860 ModelPrimitiveType bool bool bool Bool )
            value.IsResponseRestricted                      = GetBool(new IntPtr(p + 0x011)); // 024667A91310 0x11 IsResponseRestricted        ( 000186596860 ModelPrimitiveType bool bool bool Bool )
            value.Parser                                    = GetObject<HeaderParser>(new IntPtr(p + 0x018), ReversePrism.DataModels.HeaderParser.FromPointer); // 024667A91330 0x18 Parser                      ( 0001866AF1D0 ModelClassType HeaderParser HeaderParser HeaderParser Pointer )
            value.HeaderName                                = GetString(new IntPtr(p + 0x020)); // 024667A91350 0x20 HeaderName                  ( 0001866731A0 ModelPrimitiveType string string string String )
            value.AllowMultiValues                          = GetBool(new IntPtr(p + 0x028)); // 024667A91370 0x28 AllowMultiValues            ( 000186596860 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
