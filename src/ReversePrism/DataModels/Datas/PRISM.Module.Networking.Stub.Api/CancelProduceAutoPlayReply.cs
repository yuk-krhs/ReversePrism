using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<CancelProduceAutoPlayReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 BaseInfoFieldNumber                      int IL2CPP_TYPE_I4
    // 018 BaseInfo                                 0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer
    public partial class CancelProduceAutoPlayReply
    {
        public ProduceBaseInfoStatus?                   BaseInfo                                { get; set; }

        public static CancelProduceAutoPlayReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CancelProduceAutoPlayReply();

            value.BaseInfo                                  = GetObject<ProduceBaseInfoStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceBaseInfoStatus.FromPointer); // 0270D2528F70 0x18 BaseInfo                    ( 0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer )

            return value;
        }
    }
}
