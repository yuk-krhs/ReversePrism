using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsRequestRestricted                      ModelPrimitiveType bool bool bool Bool
    // 011 IsResponseRestricted                     ModelPrimitiveType bool bool bool Bool
    // 018 Parser                                   ModelClassType HeaderParser HeaderParser HeaderParser Pointer
    // 020 HeaderName                               ModelPrimitiveType string string string String
    // 028 AllowMultiValues                         ModelPrimitiveType bool bool bool Bool
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

            value.IsRequestRestricted                       = GetBool(new IntPtr(p + 0x010)); // 0x10 IsRequestRestricted         ( ModelPrimitiveType bool bool bool Bool )
            value.IsResponseRestricted                      = GetBool(new IntPtr(p + 0x011)); // 0x11 IsResponseRestricted        ( ModelPrimitiveType bool bool bool Bool )
            value.Parser                                    = GetObject<HeaderParser>(new IntPtr(p + 0x018), ReversePrism.DataModels.HeaderParser.FromPointer); // 0x18 Parser                      ( ModelClassType HeaderParser HeaderParser HeaderParser Pointer )
            value.HeaderName                                = GetString(new IntPtr(p + 0x020)); // 0x20 HeaderName                  ( ModelPrimitiveType string string string String )
            value.AllowMultiValues                          = GetBool(new IntPtr(p + 0x028)); // 0x28 AllowMultiValues            ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
