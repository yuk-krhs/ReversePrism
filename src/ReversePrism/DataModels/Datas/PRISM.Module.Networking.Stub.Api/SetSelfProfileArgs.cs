using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SetSelfProfileArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Name                                     000186671910 ModelPrimitiveType string string string String
    // 000 DisplayNameFieldNumber                   int IL2CPP_TYPE_I4
    // 020 DisplayName                              000186671910 ModelPrimitiveType string string string String
    // 000 CommentFieldNumber                       int IL2CPP_TYPE_I4
    // 028 Comment                                  000186671910 ModelPrimitiveType string string string String
    // 000 BirthdayFieldNumber                      int IL2CPP_TYPE_I4
    // 030 Birthday                                 000186671910 ModelPrimitiveType string string string String
    // 000 IsBirthdayPublicFieldNumber              int IL2CPP_TYPE_I4
    // 038 IsBirthdayPublic                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 MstProduceIdolIdFieldNumber              int IL2CPP_TYPE_I4
    // 03C MstProduceIdolId                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstSupportCharacterIdFieldNumber         int IL2CPP_TYPE_I4
    // 040 MstSupportCharacterId                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstAchievementIdListFieldNumber          int IL2CPP_TYPE_I4
    // 008 _repeated_mstAchievementIdList_codec     FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 048 MstAchievementIdList                     000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    public partial class SetSelfProfileArgs
    {
        public string                                   Name                                    { get; set; }
        public string                                   DisplayName                             { get; set; }
        public string                                   Comment                                 { get; set; }
        public string                                   Birthday                                { get; set; }
        public bool                                     IsBirthdayPublic                        { get; set; }
        public int                                      MstProduceIdolId                        { get; set; }
        public int                                      MstSupportCharacterId                   { get; set; }
        public List<int>?                               MstAchievementIdList                    { get; set; }

        public static SetSelfProfileArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetSelfProfileArgs();

            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0270D270CA00 0x18 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.DisplayName                               = GetString(new IntPtr(p + 0x020)); // 0270D270CA40 0x20 DisplayName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.Comment                                   = GetString(new IntPtr(p + 0x028)); // 0270D270CA80 0x28 Comment                     ( 000186671910 ModelPrimitiveType string string string String )
            value.Birthday                                  = GetString(new IntPtr(p + 0x030)); // 0270D270CAC0 0x30 Birthday                    ( 000186671910 ModelPrimitiveType string string string String )
            value.IsBirthdayPublic                          = GetBool(new IntPtr(p + 0x038)); // 0270D270CB00 0x38 IsBirthdayPublic            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x03C)); // 0270D270CB40 0x3C MstProduceIdolId            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstSupportCharacterId                     = GetInt32(new IntPtr(p + 0x040)); // 0270D270CB80 0x40 MstSupportCharacterId       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstAchievementIdList                      = GetInt32List(new IntPtr(p + 0x048)); // 0270D270CBE0 0x48 MstAchievementIdList        ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )

            return value;
        }
    }
}
