using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ObjectName                               ModelPrimitiveType string string string String
    public partial class SetTargetByChildNameSequence : DataModel
    {
        public string                                   ObjectName                              { get; set; }

        public static SetTargetByChildNameSequence? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetTargetByChildNameSequence() { Pointer= p0 };

            value.ObjectName                                = GetString(new IntPtr(p + 0x010)); // 0x10 ObjectName                  ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
