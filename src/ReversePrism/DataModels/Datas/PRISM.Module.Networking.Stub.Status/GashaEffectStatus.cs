using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GashaEffectStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceIdolEffectFieldNumber             int IL2CPP_TYPE_I4
    // 018 ProduceIdolEffect                        00018661CBC0 ModelClassType GashaStageEffectStatus GashaStageEffectStatus GashaStageEffectStatus Pointer
    // 000 SupportCharacterEffectFieldNumber        int IL2CPP_TYPE_I4
    // 020 SupportCharacterEffect                   0001865F6C90 ModelClassType GashaDeskEffectStatus GashaDeskEffectStatus GashaDeskEffectStatus Pointer
    public partial class GashaEffectStatus : DataModel
    {
        public GashaStageEffectStatus?                  ProduceIdolEffect                       { get; set; }
        public GashaDeskEffectStatus?                   SupportCharacterEffect                  { get; set; }

        public static GashaEffectStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaEffectStatus() { Pointer= p0 };

            value.ProduceIdolEffect                         = GetObject<GashaStageEffectStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.GashaStageEffectStatus.FromPointer); // 024661528038 0x18 ProduceIdolEffect           ( 00018661CBC0 ModelClassType GashaStageEffectStatus GashaStageEffectStatus GashaStageEffectStatus Pointer )
            value.SupportCharacterEffect                    = GetObject<GashaDeskEffectStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.GashaDeskEffectStatus.FromPointer); // 024661528078 0x20 SupportCharacterEffect      ( 0001865F6C90 ModelClassType GashaDeskEffectStatus GashaDeskEffectStatus GashaDeskEffectStatus Pointer )

            return value;
        }
    }
}
