using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TransformData                            ModelClassType UniqueSerializationData UniqueSerializationData UniqueSerializationData Pointer
    public partial class UniqueSerializationData : DataModel
    {
        public UniqueSerializationData?                 TransformData                           { get; set; }

        public static UniqueSerializationData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UniqueSerializationData() { Pointer= p0 };

            value.TransformData                             = GetObject<UniqueSerializationData>(new IntPtr(p + 0x010), ReversePrism.DataModels.UniqueSerializationData.FromPointer); // 0x10 TransformData               ( ModelClassType UniqueSerializationData UniqueSerializationData UniqueSerializationData Pointer )

            return value;
        }
    }
}
