using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 boolTrigger                              Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 018 BoolValue                                ModelPrimitiveType bool bool bool Bool
    public partial class BooleanNotifier : DataModel
    {
        public bool                                     BoolValue                               { get; set; }

        public static BooleanNotifier? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BooleanNotifier() { Pointer= p0 };

            value.BoolValue                                 = GetBool(new IntPtr(p + 0x018)); // 0x18 BoolValue                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
