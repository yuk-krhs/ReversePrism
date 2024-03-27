using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Multiline                                000186595210 ModelPrimitiveType bool bool bool Bool
    // 014 Status                                   0001865F2F90 ModelPrimitiveType int int int Int32
    // 018 StatusDescription                        000186671BA0 ModelPrimitiveType string string string String
    // 020 StatusBuffer                             000186676B00 ModelClassType StringBuilder StringBuilder StringBuilder Pointer
    // 028 StatusCodeString                         000186671BA0 ModelPrimitiveType string string string String
    public partial class ResponseDescription
    {
        public bool                                     Multiline                               { get; set; }
        public int                                      Status                                  { get; set; }
        public string                                   StatusDescription                       { get; set; }
        public StringBuilder?                           StatusBuffer                            { get; set; }
        public string                                   StatusCodeString                        { get; set; }

        public static ResponseDescription? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResponseDescription();

            value.Multiline                                 = GetBool(new IntPtr(p + 0x010)); // 0270D7A0E3C0 0x10 Multiline                   ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.Status                                    = GetInt32(new IntPtr(p + 0x014)); // 0270D7A0E3E0 0x14 Status                      ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.StatusDescription                         = GetString(new IntPtr(p + 0x018)); // 0270D7A0E400 0x18 StatusDescription           ( 000186671BA0 ModelPrimitiveType string string string String )
            value.StatusBuffer                              = GetObject<StringBuilder>(new IntPtr(p + 0x020), ReversePrism.DataModels.StringBuilder.FromPointer); // 0270D7A0E420 0x20 StatusBuffer                ( 000186676B00 ModelClassType StringBuilder StringBuilder StringBuilder Pointer )
            value.StatusCodeString                          = GetString(new IntPtr(p + 0x028)); // 0270D7A0E440 0x28 StatusCodeString            ( 000186671BA0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
