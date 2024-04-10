using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 components                               Dictionary`2<Type, VolumeComponent> IL2CPP_TYPE_GENERICINST
    // 018 defaultParameters                        ValueTuple`2<VolumeParameter, VolumeParameter>[] IL2CPP_TYPE_SZARRAY
    // 020 RequiresReset                            000186595210 ModelPrimitiveType bool bool bool Bool
    public partial class VolumeStack : DataModel
    {
        public bool                                     RequiresReset                           { get; set; }

        public static VolumeStack? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VolumeStack() { Pointer= p0 };

            value.RequiresReset                             = GetBool(new IntPtr(p + 0x020)); // 0246691F2C88 0x20 RequiresReset               ( 000186595210 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
