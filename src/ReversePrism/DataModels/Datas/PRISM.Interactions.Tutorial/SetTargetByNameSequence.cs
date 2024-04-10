using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ObjectName                               000186671910 ModelPrimitiveType string string string String
    public partial class SetTargetByNameSequence : DataModel
    {
        public string                                   ObjectName                              { get; set; }

        public static SetTargetByNameSequence? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetTargetByNameSequence() { Pointer= p0 };

            value.ObjectName                                = GetString(new IntPtr(p + 0x010)); // 02466BC97EE0 0x10 ObjectName                  ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
