using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<MarkFavoriteProduceIdolReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceIdolFieldNumber                   int IL2CPP_TYPE_I4
    // 018 ProduceIdol                              000186550070 ModelClassType ProduceIdolStatus ProduceIdolStatus ProduceIdolStatus Pointer
    public partial class MarkFavoriteProduceIdolReply
    {
        public ProduceIdolStatus?                       ProduceIdol                             { get; set; }

        public static MarkFavoriteProduceIdolReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MarkFavoriteProduceIdolReply();

            value.ProduceIdol                               = GetObject<ProduceIdolStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceIdolStatus.FromPointer); // 0270D25FE380 0x18 ProduceIdol                 ( 000186550070 ModelClassType ProduceIdolStatus ProduceIdolStatus ProduceIdolStatus Pointer )

            return value;
        }
    }
}
