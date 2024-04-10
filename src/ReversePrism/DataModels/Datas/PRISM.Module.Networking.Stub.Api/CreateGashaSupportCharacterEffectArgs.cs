using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<CreateGashaSupportCharacterEffectArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 TimeOfDayFieldNumber                     int IL2CPP_TYPE_I4
    // 018 TimeOfDay                                000186667A00 ModelEnumType TimeOfDay TimeOfDay TimeOfDay Int32
    // 000 DocumentFlagFieldNumber                  int IL2CPP_TYPE_I4
    // 01C DocumentFlag                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 CoffeeFlagFieldNumber                    int IL2CPP_TYPE_I4
    // 01D CoffeeFlag                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 VibrationFlagFieldNumber                 int IL2CPP_TYPE_I4
    // 01E VibrationFlag                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 MstCharacterInfoIdFieldNumber            int IL2CPP_TYPE_I4
    // 020 MstCharacterInfoId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 NoticeTypeFieldNumber                    int IL2CPP_TYPE_I4
    // 024 NoticeType                               00018660A180 ModelEnumType GashaNoticeType GashaNoticeType GashaNoticeType Int32
    // 000 MonthFieldNumber                         int IL2CPP_TYPE_I4
    // 028 Month                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 TvTypeFieldNumber                        int IL2CPP_TYPE_I4
    // 02C TvType                                   0001865FBE80 ModelEnumType GashaEffectTVType GashaEffectTVType GashaEffectTVType Int32
    // 000 FlavorTextIdFieldNumber                  int IL2CPP_TYPE_I4
    // 030 FlavorTextId                             000186671910 ModelPrimitiveType string string string String
    // 000 CharacterListFieldNumber                 int IL2CPP_TYPE_I4
    // 008 _repeated_characterList_codec            FieldCodec`1<SupportCharacterEffectCharacterStatus> IL2CPP_TYPE_GENERICINST
    // 038 CharacterList                            000185CF3B98 ModelClassListType RepeatedField`1<SupportCharacterEffectCharacterStatus> RepeatedField`1<SupportCharacterEffectCharacterStatus> List<SupportCharacterEffectCharacterStatus> Pointer
    public partial class CreateGashaSupportCharacterEffectArgs : DataModel
    {
        public TimeOfDay                                TimeOfDay                               { get; set; }
        public bool                                     DocumentFlag                            { get; set; }
        public bool                                     CoffeeFlag                              { get; set; }
        public bool                                     VibrationFlag                           { get; set; }
        public int                                      MstCharacterInfoId                      { get; set; }
        public GashaNoticeType                          NoticeType                              { get; set; }
        public int                                      Month                                   { get; set; }
        public GashaEffectTVType                        TvType                                  { get; set; }
        public string                                   FlavorTextId                            { get; set; }
        public List<SupportCharacterEffectCharacterStatus>? CharacterList                           { get; set; }

        public static CreateGashaSupportCharacterEffectArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CreateGashaSupportCharacterEffectArgs() { Pointer= p0 };

            value.TimeOfDay                                 = (TimeOfDay)GetInt32(new IntPtr(p + 0x018)); // 024661994AF0 0x18 TimeOfDay                   ( 000186667A00 ModelEnumType TimeOfDay TimeOfDay TimeOfDay Int32 )
            value.DocumentFlag                              = GetBool(new IntPtr(p + 0x01C)); // 024661994B30 0x1C DocumentFlag                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CoffeeFlag                                = GetBool(new IntPtr(p + 0x01D)); // 024661994B70 0x1D CoffeeFlag                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.VibrationFlag                             = GetBool(new IntPtr(p + 0x01E)); // 024661994BB0 0x1E VibrationFlag               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x020)); // 024661994BF0 0x20 MstCharacterInfoId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.NoticeType                                = (GashaNoticeType)GetInt32(new IntPtr(p + 0x024)); // 024661994C30 0x24 NoticeType                  ( 00018660A180 ModelEnumType GashaNoticeType GashaNoticeType GashaNoticeType Int32 )
            value.Month                                     = GetInt32(new IntPtr(p + 0x028)); // 024661994C70 0x28 Month                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TvType                                    = (GashaEffectTVType)GetInt32(new IntPtr(p + 0x02C)); // 024661994CB0 0x2C TvType                      ( 0001865FBE80 ModelEnumType GashaEffectTVType GashaEffectTVType GashaEffectTVType Int32 )
            value.FlavorTextId                              = GetString(new IntPtr(p + 0x030)); // 024661994CF0 0x30 FlavorTextId                ( 000186671910 ModelPrimitiveType string string string String )
            value.CharacterList                             = GetObjectList<SupportCharacterEffectCharacterStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.SupportCharacterEffectCharacterStatus.FromPointer); // 024661994D50 0x38 CharacterList               ( 000185CF3B98 ModelClassListType RepeatedField`1<SupportCharacterEffectCharacterStatus> RepeatedField`1<SupportCharacterEffectCharacterStatus> List<SupportCharacterEffectCharacterStatus> Pointer )

            return value;
        }
    }
}
