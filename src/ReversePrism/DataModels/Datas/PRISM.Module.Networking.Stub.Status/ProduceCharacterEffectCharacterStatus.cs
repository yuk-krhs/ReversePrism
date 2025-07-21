using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ProduceCharacterEffectCharacterStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstProduceIdolIdFieldNumber              int IL2CPP_TYPE_I4
    // 018 MstProduceIdolId                         ModelPrimitiveType int int int Int32
    // 000 SpotlightTypeBeforeFieldNumber           int IL2CPP_TYPE_I4
    // 01C SpotlightTypeBefore                      ModelEnumType GashaSpotlightType GashaSpotlightType GashaSpotlightType Int32
    // 000 SpotlightTypeAfterFieldNumber            int IL2CPP_TYPE_I4
    // 020 SpotlightTypeAfter                       ModelEnumType GashaSpotlightType GashaSpotlightType GashaSpotlightType Int32
    // 000 IsNewFieldNumber                         int IL2CPP_TYPE_I4
    // 024 IsNew                                    ModelPrimitiveType bool bool bool Bool
    // 000 Phase5Step1FieldNumber                   int IL2CPP_TYPE_I4
    // 028 Phase5Step1                              ModelPrimitiveType string string string String
    // 000 Phase5Step2FieldNumber                   int IL2CPP_TYPE_I4
    // 030 Phase5Step2                              ModelPrimitiveType string string string String
    // 000 Phase5Step2MotionFieldNumber             int IL2CPP_TYPE_I4
    // 038 Phase5Step2Motion                        ModelPrimitiveType string string string String
    // 000 Phase6Step1FieldNumber                   int IL2CPP_TYPE_I4
    // 040 Phase6Step1                              ModelPrimitiveType string string string String
    // 000 Phase6Step2FieldNumber                   int IL2CPP_TYPE_I4
    // 048 Phase6Step2                              ModelPrimitiveType string string string String
    // 000 Phase6Step2MotionFieldNumber             int IL2CPP_TYPE_I4
    // 050 Phase6Step2Motion                        ModelPrimitiveType string string string String
    // 000 Phase6Step3FieldNumber                   int IL2CPP_TYPE_I4
    // 058 Phase6Step3                              ModelPrimitiveType string string string String
    public partial class ProduceCharacterEffectCharacterStatus : DataModel
    {
        public int                                      MstProduceIdolId                        { get; set; }
        public GashaSpotlightType                       SpotlightTypeBefore                     { get; set; }
        public GashaSpotlightType                       SpotlightTypeAfter                      { get; set; }
        public bool                                     IsNew                                   { get; set; }
        public string                                   Phase5Step1                             { get; set; }
        public string                                   Phase5Step2                             { get; set; }
        public string                                   Phase5Step2Motion                       { get; set; }
        public string                                   Phase6Step1                             { get; set; }
        public string                                   Phase6Step2                             { get; set; }
        public string                                   Phase6Step2Motion                       { get; set; }
        public string                                   Phase6Step3                             { get; set; }

        public static ProduceCharacterEffectCharacterStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceCharacterEffectCharacterStatus() { Pointer= p0 };

            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstProduceIdolId            ( ModelPrimitiveType int int int Int32 )
            value.SpotlightTypeBefore                       = (GashaSpotlightType)GetInt32(new IntPtr(p + 0x01C)); // 0x1C SpotlightTypeBefore         ( ModelEnumType GashaSpotlightType GashaSpotlightType GashaSpotlightType Int32 )
            value.SpotlightTypeAfter                        = (GashaSpotlightType)GetInt32(new IntPtr(p + 0x020)); // 0x20 SpotlightTypeAfter          ( ModelEnumType GashaSpotlightType GashaSpotlightType GashaSpotlightType Int32 )
            value.IsNew                                     = GetBool(new IntPtr(p + 0x024)); // 0x24 IsNew                       ( ModelPrimitiveType bool bool bool Bool )
            value.Phase5Step1                               = GetString(new IntPtr(p + 0x028)); // 0x28 Phase5Step1                 ( ModelPrimitiveType string string string String )
            value.Phase5Step2                               = GetString(new IntPtr(p + 0x030)); // 0x30 Phase5Step2                 ( ModelPrimitiveType string string string String )
            value.Phase5Step2Motion                         = GetString(new IntPtr(p + 0x038)); // 0x38 Phase5Step2Motion           ( ModelPrimitiveType string string string String )
            value.Phase6Step1                               = GetString(new IntPtr(p + 0x040)); // 0x40 Phase6Step1                 ( ModelPrimitiveType string string string String )
            value.Phase6Step2                               = GetString(new IntPtr(p + 0x048)); // 0x48 Phase6Step2                 ( ModelPrimitiveType string string string String )
            value.Phase6Step2Motion                         = GetString(new IntPtr(p + 0x050)); // 0x50 Phase6Step2Motion           ( ModelPrimitiveType string string string String )
            value.Phase6Step3                               = GetString(new IntPtr(p + 0x058)); // 0x58 Phase6Step3                 ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
