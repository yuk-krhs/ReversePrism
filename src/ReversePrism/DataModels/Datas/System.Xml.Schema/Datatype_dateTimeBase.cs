using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 atomicValueType                          Type IL2CPP_TYPE_CLASS
    // 008 listValueType                            Type IL2CPP_TYPE_CLASS
    // 038 DateTimeFlags                            0001865D9140 ModelEnumType XsdDateTimeFlags XsdDateTimeFlags XsdDateTimeFlags Int32
    public partial class Datatype_dateTimeBase
    {
        public XsdDateTimeFlags                         DateTimeFlags                           { get; set; }

        public static Datatype_dateTimeBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Datatype_dateTimeBase();

            value.DateTimeFlags                             = (XsdDateTimeFlags)GetInt32(new IntPtr(p + 0x038)); // 0270D7506CA0 0x38 DateTimeFlags               ( 0001865D9140 ModelEnumType XsdDateTimeFlags XsdDateTimeFlags XsdDateTimeFlags Int32 )

            return value;
        }
    }
}
