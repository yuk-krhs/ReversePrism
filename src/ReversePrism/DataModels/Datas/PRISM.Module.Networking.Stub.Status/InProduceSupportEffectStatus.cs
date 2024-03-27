using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<InProduceSupportEffectStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSupportEffectIdFieldNumber            int IL2CPP_TYPE_I4
    // 018 MstSupportEffectId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 UnlockPremiseLevelFieldNumber            int IL2CPP_TYPE_I4
    // 01C UnlockPremiseLevel                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ProduceEntrustFieldNumber                int IL2CPP_TYPE_I4
    // 020 ProduceEntrust                           00018653E020 ModelClassType ProduceEntrustStatus ProduceEntrustStatus ProduceEntrustStatus Pointer
    // 000 IsExertedFieldNumber                     int IL2CPP_TYPE_I4
    // 028 IsExerted                                000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class InProduceSupportEffectStatus
    {
        public int                                      MstSupportEffectId                      { get; set; }
        public int                                      UnlockPremiseLevel                      { get; set; }
        public ProduceEntrustStatus?                    ProduceEntrust                          { get; set; }
        public bool                                     IsExerted                               { get; set; }

        public static InProduceSupportEffectStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InProduceSupportEffectStatus();

            value.MstSupportEffectId                        = GetInt32(new IntPtr(p + 0x018)); // 0270D10DF960 0x18 MstSupportEffectId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UnlockPremiseLevel                        = GetInt32(new IntPtr(p + 0x01C)); // 0270D10DF9A0 0x1C UnlockPremiseLevel          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ProduceEntrust                            = GetObject<ProduceEntrustStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceEntrustStatus.FromPointer); // 0270D10DF9E0 0x20 ProduceEntrust              ( 00018653E020 ModelClassType ProduceEntrustStatus ProduceEntrustStatus ProduceEntrustStatus Pointer )
            value.IsExerted                                 = GetBool(new IntPtr(p + 0x028)); // 0270D10DFA20 0x28 IsExerted                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
