using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Condition                                ModelEnumType Condition Condition Condition Int32
    // 018 Value                                    ModelPrimitiveType string string string String
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

            value.Condition                                 = (Condition)GetInt32(new IntPtr(p + 0x010)); // 0x10 Condition                   ( ModelEnumType Condition Condition Condition Int32 )
            value.Value                                     = GetString(new IntPtr(p + 0x018)); // 0x18 Value                       ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
