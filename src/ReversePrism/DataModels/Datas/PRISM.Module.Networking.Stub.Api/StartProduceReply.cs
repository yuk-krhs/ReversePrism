using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<StartProduceReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceBaseInfoFieldNumber               int IL2CPP_TYPE_I4
    // 018 ProduceBaseInfo                          ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer
    // 000 StaminaFieldNumber                       int IL2CPP_TYPE_I4
    // 020 Stamina                                  ModelClassType StaminaStatus StaminaStatus StaminaStatus Pointer
    public partial class StartProduceReply : DataModel
    {
        public ProduceBaseInfoStatus?                   ProduceBaseInfo                         { get; set; }
        public StaminaStatus?                           Stamina                                 { get; set; }

        public static StartProduceReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StartProduceReply() { Pointer= p0 };

            value.ProduceBaseInfo                           = GetObject<ProduceBaseInfoStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceBaseInfoStatus.FromPointer); // 0x18 ProduceBaseInfo             ( ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer )
            value.Stamina                                   = GetObject<StaminaStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.StaminaStatus.FromPointer); // 0x20 Stamina                     ( ModelClassType StaminaStatus StaminaStatus StaminaStatus Pointer )

            return value;
        }
    }
}
