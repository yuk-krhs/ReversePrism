using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 ValueType                                0001867485D0 ModelEnumType JTokenType JTokenType JTokenType Int32
    // 038 _value                                   <object> IL2CPP_TYPE_OBJECT
    public partial class JValue
    {
        public JTokenType                               ValueType                               { get; set; }

        public static JValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JValue();

            value.ValueType                                 = (JTokenType)GetInt32(new IntPtr(p + 0x030)); // 0270060C4410 0x30 ValueType                   ( 0001867485D0 ModelEnumType JTokenType JTokenType JTokenType Int32 )

            return value;
        }
    }
}
