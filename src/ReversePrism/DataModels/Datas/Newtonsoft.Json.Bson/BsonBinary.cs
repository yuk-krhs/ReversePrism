using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 BinaryType                               00018659B100 ModelEnumType BsonBinaryType BsonBinaryType BsonBinaryType Int32
    public partial class BsonBinary : DataModel
    {
        public BsonBinaryType                           BinaryType                              { get; set; }

        public static BsonBinary? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BsonBinary() { Pointer= p0 };

            value.BinaryType                                = (BsonBinaryType)GetInt32(new IntPtr(p + 0x030)); // 0246688F7208 0x30 BinaryType                  ( 00018659B100 ModelEnumType BsonBinaryType BsonBinaryType BsonBinaryType Int32 )

            return value;
        }
    }
}
