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
    // 018 MstSupportCharacterId                    ModelPrimitiveType int int int Int32
    // 000 NoticeTypeFieldNumber                    int IL2CPP_TYPE_I4
    // 01C NoticeType                               ModelPrimitiveType int int int Int32
    // 000 Phase3Step0FieldNumber                   int IL2CPP_TYPE_I4
    // 020 Phase3Step0                              ModelPrimitiveType string string string String
    // 000 Phase3Step1FieldNumber                   int IL2CPP_TYPE_I4
    // 028 Phase3Step1                              ModelPrimitiveType string string string String
    // 000 Phase3Step2FieldNumber                   int IL2CPP_TYPE_I4
    // 030 Phase3Step2                              ModelPrimitiveType string string string String
    // 000 IsNewFieldNumber                         int IL2CPP_TYPE_I4
    // 038 IsNew                                    ModelPrimitiveType bool bool bool Bool
    public partial class SupportCharacterEffectCharacterStatus : DataModel
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
            var value   = new SupportCharacterEffectCharacterStatus() { Pointer= p0 };

            value.MstSupportCharacterId                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstSupportCharacterId       ( ModelPrimitiveType int int int Int32 )
            value.NoticeType                                = GetInt32(new IntPtr(p + 0x01C)); // 0x1C NoticeType                  ( ModelPrimitiveType int int int Int32 )
            value.Phase3Step0                               = GetString(new IntPtr(p + 0x020)); // 0x20 Phase3Step0                 ( ModelPrimitiveType string string string String )
            value.Phase3Step1                               = GetString(new IntPtr(p + 0x028)); // 0x28 Phase3Step1                 ( ModelPrimitiveType string string string String )
            value.Phase3Step2                               = GetString(new IntPtr(p + 0x030)); // 0x30 Phase3Step2                 ( ModelPrimitiveType string string string String )
            value.IsNew                                     = GetBool(new IntPtr(p + 0x038)); // 0x38 IsNew                       ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
