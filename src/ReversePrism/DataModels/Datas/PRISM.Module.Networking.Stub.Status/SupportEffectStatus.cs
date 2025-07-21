using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SupportEffectStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSupportEffectIdFieldNumber            int IL2CPP_TYPE_I4
    // 018 MstSupportEffectId                       ModelPrimitiveType int int int Int32
    // 000 UnlockPremiseLevelFieldNumber            int IL2CPP_TYPE_I4
    // 01C UnlockPremiseLevel                       ModelPrimitiveType int int int Int32
    // 000 ProduceEntrustFieldNumber                int IL2CPP_TYPE_I4
    // 020 ProduceEntrust                           ModelClassType ProduceEntrustStatus ProduceEntrustStatus ProduceEntrustStatus Pointer
    public partial class SupportEffectStatus : DataModel
    {
        public int                                      MstSupportEffectId                      { get; set; }
        public int                                      UnlockPremiseLevel                      { get; set; }
        public ProduceEntrustStatus?                    ProduceEntrust                          { get; set; }

        public static SupportEffectStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportEffectStatus() { Pointer= p0 };

            value.MstSupportEffectId                        = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstSupportEffectId          ( ModelPrimitiveType int int int Int32 )
            value.UnlockPremiseLevel                        = GetInt32(new IntPtr(p + 0x01C)); // 0x1C UnlockPremiseLevel          ( ModelPrimitiveType int int int Int32 )
            value.ProduceEntrust                            = GetObject<ProduceEntrustStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceEntrustStatus.FromPointer); // 0x20 ProduceEntrust              ( ModelClassType ProduceEntrustStatus ProduceEntrustStatus ProduceEntrustStatus Pointer )

            return value;
        }
    }
}
