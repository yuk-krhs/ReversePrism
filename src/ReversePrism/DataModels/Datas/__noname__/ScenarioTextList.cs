using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Key                                      000186671910 ModelPrimitiveType string string string String
    // 018 Text                                     000186671910 ModelPrimitiveType string string string String
    public partial class ScenarioTextList
    {
        public string                                   Key                                     { get; set; }
        public string                                   Text                                    { get; set; }

        public static ScenarioTextList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScenarioTextList();

            value.Key                                       = GetString(new IntPtr(p + 0x010)); // 0270069D9930 0x10 Key                         ( 000186671910 ModelPrimitiveType string string string String )
            value.Text                                      = GetString(new IntPtr(p + 0x018)); // 0270069D9950 0x18 Text                        ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
