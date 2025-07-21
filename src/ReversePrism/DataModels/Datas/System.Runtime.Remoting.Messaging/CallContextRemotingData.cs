using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LogicalCallID                            ModelPrimitiveType string string string String
    public partial class CallContextRemotingData : DataModel
    {
        public string                                   LogicalCallID                           { get; set; }

        public static CallContextRemotingData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CallContextRemotingData() { Pointer= p0 };

            value.LogicalCallID                             = GetString(new IntPtr(p + 0x010)); // 0x10 LogicalCallID               ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
