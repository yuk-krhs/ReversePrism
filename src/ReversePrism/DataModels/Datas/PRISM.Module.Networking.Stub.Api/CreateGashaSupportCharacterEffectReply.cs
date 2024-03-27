using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<CreateGashaSupportCharacterEffectReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 DrawProductListFieldNumber               int IL2CPP_TYPE_I4
    // 008 _repeated_drawProductList_codec          FieldCodec`1<GashaRewardProductStatus> IL2CPP_TYPE_GENERICINST
    // 018 DrawProductList                          000185CDD198 ModelClassListType RepeatedField`1<GashaRewardProductStatus> RepeatedField`1<GashaRewardProductStatus> List<GashaRewardProductStatus> Pointer
    // 000 SupportCharacterEffectFieldNumber        int IL2CPP_TYPE_I4
    // 020 SupportCharacterEffect                   0001865F6C90 ModelClassType GashaDeskEffectStatus GashaDeskEffectStatus GashaDeskEffectStatus Pointer
    public partial class CreateGashaSupportCharacterEffectReply
    {
        public List<GashaRewardProductStatus>?          DrawProductList                         { get; set; }
        public GashaDeskEffectStatus?                   SupportCharacterEffect                  { get; set; }

        public static CreateGashaSupportCharacterEffectReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CreateGashaSupportCharacterEffectReply();

            value.DrawProductList                           = GetObjectList<GashaRewardProductStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.GashaRewardProductStatus.FromPointer); // 0270D1A0B538 0x18 DrawProductList             ( 000185CDD198 ModelClassListType RepeatedField`1<GashaRewardProductStatus> RepeatedField`1<GashaRewardProductStatus> List<GashaRewardProductStatus> Pointer )
            value.SupportCharacterEffect                    = GetObject<GashaDeskEffectStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.GashaDeskEffectStatus.FromPointer); // 0270D1A0B578 0x20 SupportCharacterEffect      ( 0001865F6C90 ModelClassType GashaDeskEffectStatus GashaDeskEffectStatus GashaDeskEffectStatus Pointer )

            return value;
        }
    }
}
