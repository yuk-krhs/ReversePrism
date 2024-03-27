using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NameSpace                                0001866722E0 ModelPrimitiveType string string string String
    // 018 ClassName                                0001866722E0 ModelPrimitiveType string string string String
    // 020 IsPartial                                000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class MonoScriptInfo
    {
        public string                                   NameSpace                               { get; set; }
        public string                                   ClassName                               { get; set; }
        public bool                                     IsPartial                               { get; set; }

        public static MonoScriptInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonoScriptInfo();

            value.NameSpace                                 = GetString(new IntPtr(p + 0x010)); // 0270DBF69AC8 0x10 NameSpace                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ClassName                                 = GetString(new IntPtr(p + 0x018)); // 0270DBF69AE8 0x18 ClassName                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.IsPartial                                 = GetBool(new IntPtr(p + 0x020)); // 0270DBF69B08 0x20 IsPartial                   ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
