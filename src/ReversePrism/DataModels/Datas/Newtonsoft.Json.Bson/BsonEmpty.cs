using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Null                                     BsonToken IL2CPP_TYPE_CLASS
    // 008 Undefined                                BsonToken IL2CPP_TYPE_CLASS
    // 020 Type                                     0001867785E0 ModelEnumType BsonType BsonType BsonType Int32
    public partial class BsonEmpty : DataModel
    {
        public BsonType                                 Type                                    { get; set; }

        public static BsonEmpty? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BsonEmpty() { Pointer= p0 };

            value.Type                                      = (BsonType)GetInt32(new IntPtr(p + 0x020)); // 0246688F6B58 0x20 Type                        ( 0001867785E0 ModelEnumType BsonType BsonType BsonType Int32 )

            return value;
        }
    }
}
