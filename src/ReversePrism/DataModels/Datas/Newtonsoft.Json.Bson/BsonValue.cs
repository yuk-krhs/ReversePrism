using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 _value                                   <object> IL2CPP_TYPE_OBJECT
    // 028 Type                                     ModelEnumType BsonType BsonType BsonType Int32
    public partial class BsonValue : DataModel
    {
        public BsonType                                 Type                                    { get; set; }

        public static BsonValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BsonValue() { Pointer= p0 };

            value.Type                                      = (BsonType)GetInt32(new IntPtr(p + 0x028)); // 0x28 Type                        ( ModelEnumType BsonType BsonType BsonType Int32 )

            return value;
        }
    }
}
