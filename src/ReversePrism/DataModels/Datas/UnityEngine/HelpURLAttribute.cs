using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Url                                    0001866731A0 ModelPrimitiveType string string string String
    // 018 M_Dispatcher                             000186596860 ModelPrimitiveType bool bool bool Bool
    // 020 M_DispatchingFieldName                   0001866731A0 ModelPrimitiveType string string string String
    public partial class HelpURLAttribute
    {
        public string                                   M_Url                                   { get; set; }
        public bool                                     M_Dispatcher                            { get; set; }
        public string                                   M_DispatchingFieldName                  { get; set; }

        public static HelpURLAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HelpURLAttribute();

            value.M_Url                                     = GetString(new IntPtr(p + 0x010)); // 0270023B95D0 0x10 M_Url                       ( 0001866731A0 ModelPrimitiveType string string string String )
            value.M_Dispatcher                              = GetBool(new IntPtr(p + 0x018)); // 0270023B95F0 0x18 M_Dispatcher                ( 000186596860 ModelPrimitiveType bool bool bool Bool )
            value.M_DispatchingFieldName                    = GetString(new IntPtr(p + 0x020)); // 0270023B9610 0x20 M_DispatchingFieldName      ( 0001866731A0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
