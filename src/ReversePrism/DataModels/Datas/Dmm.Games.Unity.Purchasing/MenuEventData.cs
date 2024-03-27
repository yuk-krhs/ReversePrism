using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsSuccess                                000186595960 ModelPrimitiveType bool bool bool Bool
    // 018 Error                                    0001866722E0 ModelPrimitiveType string string string String
    public partial class MenuEventData
    {
        public bool                                     IsSuccess                               { get; set; }
        public string                                   Error                                   { get; set; }

        public static MenuEventData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MenuEventData();

            value.IsSuccess                                 = GetBool(new IntPtr(p + 0x010)); // 0270DB482A70 0x10 IsSuccess                   ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Error                                     = GetString(new IntPtr(p + 0x018)); // 0270DB482A90 0x18 Error                       ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
