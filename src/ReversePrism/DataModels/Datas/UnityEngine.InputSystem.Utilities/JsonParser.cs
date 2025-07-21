using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Text                                   ModelPrimitiveType string string string String
    // 018 M_Length                                 ModelPrimitiveType int int int Int32
    // 01C M_Position                               ModelPrimitiveType int int int Int32
    // 020 M_MatchAnyElementInArray                 ModelPrimitiveType bool bool bool Bool
    // 021 M_DryRun                                 ModelPrimitiveType bool bool bool Bool
    public partial class JsonParser : DataModel
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
            var value   = new JsonParser() { Pointer= p0 };

            value.M_Text                                    = GetString(new IntPtr(p + 0x010)); // 0x10 M_Text                      ( ModelPrimitiveType string string string String )
            value.M_Length                                  = GetInt32(new IntPtr(p + 0x018)); // 0x18 M_Length                    ( ModelPrimitiveType int int int Int32 )
            value.M_Position                                = GetInt32(new IntPtr(p + 0x01C)); // 0x1C M_Position                  ( ModelPrimitiveType int int int Int32 )
            value.M_MatchAnyElementInArray                  = GetBool(new IntPtr(p + 0x020)); // 0x20 M_MatchAnyElementInArray    ( ModelPrimitiveType bool bool bool Bool )
            value.M_DryRun                                  = GetBool(new IntPtr(p + 0x021)); // 0x21 M_DryRun                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
