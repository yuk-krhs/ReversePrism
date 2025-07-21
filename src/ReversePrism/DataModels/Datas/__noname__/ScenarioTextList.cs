using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Key                                      ModelPrimitiveType string string string String
    // 018 Text                                     ModelPrimitiveType string string string String
    public partial class ScenarioTextList : DataModel
    {
        public string                                   Key                                     { get; set; }
        public string                                   Text                                    { get; set; }

        public static ScenarioTextList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScenarioTextList() { Pointer= p0 };

            value.Key                                       = GetString(new IntPtr(p + 0x010)); // 0x10 Key                         ( ModelPrimitiveType string string string String )
            value.Text                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Text                        ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
