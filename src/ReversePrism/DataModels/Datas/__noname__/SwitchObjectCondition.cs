using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Condition                                0001866F99B0 ModelEnumType Condition Condition Condition Int32
    // 018 Value                                    0001866722E0 ModelPrimitiveType string string string String
    public partial class SwitchObjectCondition : DataModel
    {
        public Condition                                Condition                               { get; set; }
        public string                                   Value                                   { get; set; }

        public static SwitchObjectCondition? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SwitchObjectCondition() { Pointer= p0 };

            value.Condition                                 = (Condition)GetInt32(new IntPtr(p + 0x010)); // 0245A5D466E8 0x10 Condition                   ( 0001866F99B0 ModelEnumType Condition Condition Condition Int32 )
            value.Value                                     = GetString(new IntPtr(p + 0x018)); // 0245A5D46708 0x18 Value                       ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
