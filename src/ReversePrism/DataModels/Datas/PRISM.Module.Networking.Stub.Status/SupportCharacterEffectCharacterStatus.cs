using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SupportCharacterEffectCharacterStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSupportCharacterIdFieldNumber         int IL2CPP_TYPE_I4
    // 018 MstSupportCharacterId                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 NoticeTypeFieldNumber                    int IL2CPP_TYPE_I4
    // 01C NoticeType                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 Phase3Step0FieldNumber                   int IL2CPP_TYPE_I4
    // 020 Phase3Step0                              000186671910 ModelPrimitiveType string string string String
    // 000 Phase3Step1FieldNumber                   int IL2CPP_TYPE_I4
    // 028 Phase3Step1                              000186671910 ModelPrimitiveType string string string String
    // 000 Phase3Step2FieldNumber                   int IL2CPP_TYPE_I4
    // 030 Phase3Step2                              000186671910 ModelPrimitiveType string string string String
    // 000 IsNewFieldNumber                         int IL2CPP_TYPE_I4
    // 038 IsNew                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class SupportCharacterEffectCharacterStatus
    {
        public int                                      MstSupportCharacterId                   { get; set; }
        public int                                      NoticeType                              { get; set; }
        public string                                   Phase3Step0                             { get; set; }
        public string                                   Phase3Step1                             { get; set; }
        public string                                   Phase3Step2                             { get; set; }
        public bool                                     IsNew                                   { get; set; }

        public static SupportCharacterEffectCharacterStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharacterEffectCharacterStatus();

            value.MstSupportCharacterId                     = GetInt32(new IntPtr(p + 0x018)); // 0270D15A9230 0x18 MstSupportCharacterId       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.NoticeType                                = GetInt32(new IntPtr(p + 0x01C)); // 0270D15A9270 0x1C NoticeType                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Phase3Step0                               = GetString(new IntPtr(p + 0x020)); // 0270D15A92B0 0x20 Phase3Step0                 ( 000186671910 ModelPrimitiveType string string string String )
            value.Phase3Step1                               = GetString(new IntPtr(p + 0x028)); // 0270D15A92F0 0x28 Phase3Step1                 ( 000186671910 ModelPrimitiveType string string string String )
            value.Phase3Step2                               = GetString(new IntPtr(p + 0x030)); // 0270D15A9330 0x30 Phase3Step2                 ( 000186671910 ModelPrimitiveType string string string String )
            value.IsNew                                     = GetBool(new IntPtr(p + 0x038)); // 0270D15A9370 0x38 IsNew                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
