using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CollectionAccessType                     0001865C2BB0 ModelEnumType CollectionAccessType CollectionAccessType CollectionAccessType Int32
    public partial class CollectionAccessAttribute
    {
        public CollectionAccessType                     CollectionAccessType                    { get; set; }

        public static CollectionAccessAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CollectionAccessAttribute();

            value.CollectionAccessType                      = (CollectionAccessType)GetInt32(new IntPtr(p + 0x010)); // 0270068A6640 0x10 CollectionAccessType        ( 0001865C2BB0 ModelEnumType CollectionAccessType CollectionAccessType CollectionAccessType Int32 )

            return value;
        }
    }
}
