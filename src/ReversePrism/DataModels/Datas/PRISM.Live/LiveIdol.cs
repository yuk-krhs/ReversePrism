using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     000186603140 ModelEnumType LiveUnitIdolType LiveUnitIdolType LiveUnitIdolType Int32
    // 014 CharacterId                              0001865F4260 ModelPrimitiveType int int int Int32
    // 018 MstProduceIdolId                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 FesIdolId                                000186672F10 ModelPrimitiveType string string string String
    // 028 FesIdolRank                              00018660DDC0 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32
    // 02C UnitId                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 030 Parameter                                000186558560 ModelEnumType LiveIdolParameter LiveIdolParameter LiveIdolParameter Int32
    // 04C UnitBonusRate                            0001866656B0 ModelPrimitiveType float float float Single
    // 050 InitialStarLevel                         0001865F4260 ModelPrimitiveType int int int Int32
    // 054 StarLevel                                0001865F4260 ModelPrimitiveType int int int Int32
    // 058 CardId                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 05C FavoriteMarkId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 060 Skill                                    00018657BD60 ModelClassType LiveSkill LiveSkill LiveSkill Pointer
    // 068 CreateDate                               000185D00B98 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 078 Costume                                  00018659D660 ModelClassType CharacterCostume CharacterCostume CharacterCostume Pointer
    // 080 DefaultCostumeIdArray                    000185B8A810 ModelEnumListType IdolCostumeId[] IdolCostumeId[] List<IdolCostumeId> Pointer
    // 088 ShowUnitBonus                            000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class LiveIdol
    {
        public LiveUnitIdolType                         Type                                    { get; set; }
        public int                                      CharacterId                             { get; set; }
        public int                                      MstProduceIdolId                        { get; set; }
        public string                                   FesIdolId                               { get; set; }
        public ProduceParameterRank                     FesIdolRank                             { get; set; }
        public int                                      UnitId                                  { get; set; }
        public LiveIdolParameter                        Parameter                               { get; set; }
        public float                                    UnitBonusRate                           { get; set; }
        public int                                      InitialStarLevel                        { get; set; }
        public int                                      StarLevel                               { get; set; }
        public int                                      CardId                                  { get; set; }
        public int                                      FavoriteMarkId                          { get; set; }
        public LiveSkill?                               Skill                                   { get; set; }
        public DateTime                                 CreateDate                              { get; set; }
        public CharacterCostume?                        Costume                                 { get; set; }
        public List<IdolCostumeId>?                     DefaultCostumeIdArray                   { get; set; }
        public bool                                     ShowUnitBonus                           { get; set; }

        public static LiveIdol? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveIdol();

            value.Type                                      = (LiveUnitIdolType)GetInt32(new IntPtr(p + 0x010)); // 0270D4CB4CB0 0x10 Type                        ( 000186603140 ModelEnumType LiveUnitIdolType LiveUnitIdolType LiveUnitIdolType Int32 )
            value.CharacterId                               = GetInt32(new IntPtr(p + 0x014)); // 0270D4CB4CD0 0x14 CharacterId                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x018)); // 0270D4CB4CF0 0x18 MstProduceIdolId            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.FesIdolId                                 = GetString(new IntPtr(p + 0x020)); // 0270D4CB4D10 0x20 FesIdolId                   ( 000186672F10 ModelPrimitiveType string string string String )
            value.FesIdolRank                               = (ProduceParameterRank)GetInt32(new IntPtr(p + 0x028)); // 0270D4CB4D30 0x28 FesIdolRank                 ( 00018660DDC0 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32 )
            value.UnitId                                    = GetInt32(new IntPtr(p + 0x02C)); // 0270D4CB4D50 0x2C UnitId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Parameter                                 = (LiveIdolParameter)GetInt32(new IntPtr(p + 0x030)); // 0270D4CB4D70 0x30 Parameter                   ( 000186558560 ModelEnumType LiveIdolParameter LiveIdolParameter LiveIdolParameter Int32 )
            value.UnitBonusRate                             = GetSingle(new IntPtr(p + 0x04C)); // 0270D4CB4D90 0x4C UnitBonusRate               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.InitialStarLevel                          = GetInt32(new IntPtr(p + 0x050)); // 0270D4CB4DB0 0x50 InitialStarLevel            ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.StarLevel                                 = GetInt32(new IntPtr(p + 0x054)); // 0270D4CB4DD0 0x54 StarLevel                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.CardId                                    = GetInt32(new IntPtr(p + 0x058)); // 0270D4CB4DF0 0x58 CardId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.FavoriteMarkId                            = GetInt32(new IntPtr(p + 0x05C)); // 0270D4CB4E10 0x5C FavoriteMarkId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Skill                                     = GetObject<LiveSkill>(new IntPtr(p + 0x060), ReversePrism.DataModels.LiveSkill.FromPointer); // 0270D4CB4E30 0x60 Skill                       ( 00018657BD60 ModelClassType LiveSkill LiveSkill LiveSkill Pointer )
            value.CreateDate                                = GetDateTime(new IntPtr(p + 0x068)); // 0270D4CB4E50 0x68 CreateDate                  ( 000185D00B98 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.Costume                                   = GetObject<CharacterCostume>(new IntPtr(p + 0x078), ReversePrism.DataModels.CharacterCostume.FromPointer); // 0270D4CB4E70 0x78 Costume                     ( 00018659D660 ModelClassType CharacterCostume CharacterCostume CharacterCostume Pointer )
            value.DefaultCostumeIdArray                     = GetEnumList<IdolCostumeId>(new IntPtr(p + 0x080)); // 0270D4CB4E90 0x80 DefaultCostumeIdArray       ( 000185B8A810 ModelEnumListType IdolCostumeId[] IdolCostumeId[] List<IdolCostumeId> Pointer )
            value.ShowUnitBonus                             = GetBool(new IntPtr(p + 0x088)); // 0270D4CB4EB0 0x88 ShowUnitBonus               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
