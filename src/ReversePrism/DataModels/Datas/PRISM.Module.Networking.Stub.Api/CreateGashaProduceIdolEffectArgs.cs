using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<CreateGashaProduceIdolEffectArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 Phase1FieldNumber                        int IL2CPP_TYPE_I4
    // 018 Phase1                                   000186671910 ModelPrimitiveType string string string String
    // 000 Phase2FieldNumber                        int IL2CPP_TYPE_I4
    // 020 Phase2                                   000186671910 ModelPrimitiveType string string string String
    // 000 Phase3FieldNumber                        int IL2CPP_TYPE_I4
    // 028 Phase3                                   000186671910 ModelPrimitiveType string string string String
    // 000 Phase4Step1FieldNumber                   int IL2CPP_TYPE_I4
    // 030 Phase4Step1                              000186671910 ModelPrimitiveType string string string String
    // 000 Phase4Step2FieldNumber                   int IL2CPP_TYPE_I4
    // 038 Phase4Step2                              000186671910 ModelPrimitiveType string string string String
    // 000 CharacterListFieldNumber                 int IL2CPP_TYPE_I4
    // 008 _repeated_characterList_codec            FieldCodec`1<ProduceCharacterEffectCharacterStatus> IL2CPP_TYPE_GENERICINST
    // 040 CharacterList                            000185CEB438 ModelClassListType RepeatedField`1<ProduceCharacterEffectCharacterStatus> RepeatedField`1<ProduceCharacterEffectCharacterStatus> List<ProduceCharacterEffectCharacterStatus> Pointer
    public partial class CreateGashaProduceIdolEffectArgs
    {
        public string                                   Phase1                                  { get; set; }
        public string                                   Phase2                                  { get; set; }
        public string                                   Phase3                                  { get; set; }
        public string                                   Phase4Step1                             { get; set; }
        public string                                   Phase4Step2                             { get; set; }
        public List<ProduceCharacterEffectCharacterStatus>? CharacterList                           { get; set; }

        public static CreateGashaProduceIdolEffectArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CreateGashaProduceIdolEffectArgs();

            value.Phase1                                    = GetString(new IntPtr(p + 0x018)); // 0270D19F5A20 0x18 Phase1                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Phase2                                    = GetString(new IntPtr(p + 0x020)); // 0270D19F5A60 0x20 Phase2                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Phase3                                    = GetString(new IntPtr(p + 0x028)); // 0270D19F5AA0 0x28 Phase3                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Phase4Step1                               = GetString(new IntPtr(p + 0x030)); // 0270D19F5AE0 0x30 Phase4Step1                 ( 000186671910 ModelPrimitiveType string string string String )
            value.Phase4Step2                               = GetString(new IntPtr(p + 0x038)); // 0270D19F5B20 0x38 Phase4Step2                 ( 000186671910 ModelPrimitiveType string string string String )
            value.CharacterList                             = GetObjectList<ProduceCharacterEffectCharacterStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProduceCharacterEffectCharacterStatus.FromPointer); // 0270D19F5B80 0x40 CharacterList               ( 000185CEB438 ModelClassListType RepeatedField`1<ProduceCharacterEffectCharacterStatus> RepeatedField`1<ProduceCharacterEffectCharacterStatus> List<ProduceCharacterEffectCharacterStatus> Pointer )

            return value;
        }
    }
}
