using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Text                                   000186672F10 ModelPrimitiveType string string string String
    // 018 M_Length                                 0001865F4260 ModelPrimitiveType int int int Int32
    // 01C M_Position                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 M_MatchAnyElementInArray                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 021 M_DryRun                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class JsonParser
    {
        public string                                   M_Text                                  { get; set; }
        public int                                      M_Length                                { get; set; }
        public int                                      M_Position                              { get; set; }
        public bool                                     M_MatchAnyElementInArray                { get; set; }
        public bool                                     M_DryRun                                { get; set; }

        public static JsonParser? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonParser();

            value.M_Text                                    = GetString(new IntPtr(p + 0x010)); // 0270D78B23F0 0x10 M_Text                      ( 000186672F10 ModelPrimitiveType string string string String )
            value.M_Length                                  = GetInt32(new IntPtr(p + 0x018)); // 0270D78B2410 0x18 M_Length                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.M_Position                                = GetInt32(new IntPtr(p + 0x01C)); // 0270D78B2430 0x1C M_Position                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_MatchAnyElementInArray                  = GetBool(new IntPtr(p + 0x020)); // 0270D78B2450 0x20 M_MatchAnyElementInArray    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_DryRun                                  = GetBool(new IntPtr(p + 0x021)); // 0270D78B2470 0x21 M_DryRun                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
