using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 GoodScheduleTypeList                     000185D19068 ModelEnumListType IReadOnlyList`1<ScheduleType> IReadOnlyList`1<ScheduleType> List<ScheduleType> Pointer
    // 000 _parser                                  MessageParser`1<InheritanceFesUnitSupportCharacterStatus> IL2CPP_TYPE_GENERICINST
    // 018 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSupportCharacterIdFieldNumber         int IL2CPP_TYPE_I4
    // 020 MstSupportCharacterId                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 RarityFieldNumber                        int IL2CPP_TYPE_I4
    // 024 Rarity                                   0001865EB1C0 ModelEnumType SupportCharacterRarity SupportCharacterRarity SupportCharacterRarity Int32
    // 000 LevelFieldNumber                         int IL2CPP_TYPE_I4
    // 028 Level                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 DiamondFieldNumber                       int IL2CPP_TYPE_I4
    // 02C Diamond                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 CardIdFieldNumber                        int IL2CPP_TYPE_I4
    // 030 CardId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstCharacterInfoIdFieldNumber            int IL2CPP_TYPE_I4
    // 034 MstCharacterInfoId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 SupportSkillSlotAmountFieldNumber        int IL2CPP_TYPE_I4
    // 038 SupportSkillSlotAmount                   00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 GoodScheduleTypeListFieldNumber          int IL2CPP_TYPE_I4
    // 008 _repeated_goodScheduleTypeList_codec     FieldCodec`1<ScheduleType> IL2CPP_TYPE_GENERICINST
    // 040 GoodScheduleTypeList                     000185CEFA68 ModelEnumListType RepeatedField`1<ScheduleType> RepeatedField`1<ScheduleType> List<ScheduleType> Pointer
    // 000 IsFriendSupportFieldNumber               int IL2CPP_TYPE_I4
    // 048 IsFriendSupport                          000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class InheritanceFesUnitSupportCharacterStatus : DataModel
    {
        public List<ScheduleType>?                      GoodScheduleTypeList                    { get; set; }
        public int                                      MstSupportCharacterId                   { get; set; }
        public SupportCharacterRarity                   Rarity                                  { get; set; }
        public int                                      Level                                   { get; set; }
        public int                                      Diamond                                 { get; set; }
        public int                                      CardId                                  { get; set; }
        public int                                      MstCharacterInfoId                      { get; set; }
        public LimitedValueStatus?                      SupportSkillSlotAmount                  { get; set; }
        public bool                                     IsFriendSupport                         { get; set; }

        public static InheritanceFesUnitSupportCharacterStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InheritanceFesUnitSupportCharacterStatus() { Pointer= p0 };

            value.GoodScheduleTypeList                      = GetEnumList<ScheduleType>(new IntPtr(p + 0x040)); // 0246610790D8 0x40 GoodScheduleTypeList        ( 000185CEFA68 ModelEnumListType RepeatedField`1<ScheduleType> RepeatedField`1<ScheduleType> List<ScheduleType> Pointer )
            value.MstSupportCharacterId                     = GetInt32(new IntPtr(p + 0x020)); // 024661078EF8 0x20 MstSupportCharacterId       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Rarity                                    = (SupportCharacterRarity)GetInt32(new IntPtr(p + 0x024)); // 024661078F38 0x24 Rarity                      ( 0001865EB1C0 ModelEnumType SupportCharacterRarity SupportCharacterRarity SupportCharacterRarity Int32 )
            value.Level                                     = GetInt32(new IntPtr(p + 0x028)); // 024661078F78 0x28 Level                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Diamond                                   = GetInt32(new IntPtr(p + 0x02C)); // 024661078FB8 0x2C Diamond                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CardId                                    = GetInt32(new IntPtr(p + 0x030)); // 024661078FF8 0x30 CardId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x034)); // 024661079038 0x34 MstCharacterInfoId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SupportSkillSlotAmount                    = GetObject<LimitedValueStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 024661079078 0x38 SupportSkillSlotAmount      ( 00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.IsFriendSupport                           = GetBool(new IntPtr(p + 0x048)); // 024661079118 0x48 IsFriendSupport             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
