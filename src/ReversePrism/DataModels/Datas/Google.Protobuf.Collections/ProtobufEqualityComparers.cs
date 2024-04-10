using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 <BitwiseDoubleEqualityComparer>k__BackingField EqualityComparer`1<double> IL2CPP_TYPE_GENERICINST
    // 008 <BitwiseSingleEqualityComparer>k__BackingField EqualityComparer`1<float> IL2CPP_TYPE_GENERICINST
    // 010 <BitwiseNullableDoubleEqualityComparer>k__BackingField EqualityComparer`1<Nullable`1<double>> IL2CPP_TYPE_GENERICINST
    // 018 <BitwiseNullableSingleEqualityComparer>k__BackingField EqualityComparer`1<Nullable`1<float>> IL2CPP_TYPE_GENERICINST
    public partial class ProtobufEqualityComparers : DataModel
    {

        public static ProtobufEqualityComparers? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProtobufEqualityComparers() { Pointer= p0 };


            return value;
        }
    }
}
