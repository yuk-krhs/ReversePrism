using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Value                                    000185B79F90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class BsonObjectId : DataModel
    {
        public List<sbyte>?                             Value                                   { get; set; }

        public static BsonObjectId? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BsonObjectId() { Pointer= p0 };

            value.Value                                     = GetSByteList(new IntPtr(p + 0x010)); // 0246688C6AA0 0x10 Value                       ( 000185B79F90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
