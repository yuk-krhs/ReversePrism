using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProducerType                             0001866936B0 ModelClassType Type Type Type Pointer
    public partial class JobProducerTypeAttribute
    {
        public Type?                                    ProducerType                            { get; set; }

        public static JobProducerTypeAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JobProducerTypeAttribute();

            value.ProducerType                              = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0270068A30D8 0x10 ProducerType                ( 0001866936B0 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
