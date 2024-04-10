using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 keyCodec                                 FieldCodec`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 valueCodec                               FieldCodec`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 mapTag                                   uint IL2CPP_TYPE_U4
    public partial class Codec : DataModel
    {

        public static Codec? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Codec() { Pointer= p0 };


            return value;
        }
    }
}
