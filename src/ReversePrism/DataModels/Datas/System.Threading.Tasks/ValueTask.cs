using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_canceledTask                           Task IL2CPP_TYPE_CLASS
    // 010 _obj                                     <object> IL2CPP_TYPE_OBJECT
    // 018 Token                                    0001865F19E0 ModelPrimitiveType short short short Int16
    // 01A ContinueOnCapturedContext                000186596860 ModelPrimitiveType bool bool bool Bool
    public partial class ValueTask
    {
        public short                                    Token                                   { get; set; }
        public bool                                     ContinueOnCapturedContext               { get; set; }

        public static ValueTask? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ValueTask();

            value.Token                                     = GetInt16(new IntPtr(p + 0x018)); // 0270D199AFA8 0x18 Token                       ( 0001865F19E0 ModelPrimitiveType short short short Int16 )
            value.ContinueOnCapturedContext                 = GetBool(new IntPtr(p + 0x01A)); // 0270D199AFC8 0x1A ContinueOnCapturedContext   ( 000186596860 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
