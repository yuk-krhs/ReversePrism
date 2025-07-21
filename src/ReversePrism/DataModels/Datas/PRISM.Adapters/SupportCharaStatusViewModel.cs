using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FavoriteMarkRP                           ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer
    // 018 diamondLvChangeRP                        ReactiveProperty`1<ValueTuple`2<int, int>> IL2CPP_TYPE_GENERICINST
    // 020 lvChangeRP                               ReactiveProperty`1<ValueTuple`2<int, bool>> IL2CPP_TYPE_GENERICINST
    // 028 animateExpGaugeSubject                   Subject`1<ValueTuple`3<float, float, float>> IL2CPP_TYPE_GENERICINST
    // 030 TrainingTicketsTotalExpChangeRP          ModelClassType LongReactiveProperty LongReactiveProperty LongReactiveProperty Pointer
    // 038 CurrentExpProgressChangeRP               ModelClassType FloatReactiveProperty FloatReactiveProperty FloatReactiveProperty Pointer
    // 040 earnedExpProgressChangeRP                ReactiveProperty`1<ValueTuple`2<float, bool>> IL2CPP_TYPE_GENERICINST
    // 048 ToNextLvExpChange                        ModelClassType LongReactiveProperty LongReactiveProperty LongReactiveProperty Pointer
    // 050 isMaxExp                                 Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 058 MstSupportCharaId                        ModelPrimitiveType int int int Int32
    // 05C MstCharaInfoId                           ModelPrimitiveType int int int Int32
    // 060 Rarity                                   ModelEnumType SupportCharacterRarity SupportCharacterRarity SupportCharacterRarity Int32
    // 064 NextLv                                   ModelPrimitiveType int int int Int32
    public partial class SupportCharaStatusViewModel : DataModel
    {
        public IntReactiveProperty?                     FavoriteMarkRP                          { get; set; }
        public LongReactiveProperty?                    TrainingTicketsTotalExpChangeRP         { get; set; }
        public FloatReactiveProperty?                   CurrentExpProgressChangeRP              { get; set; }
        public LongReactiveProperty?                    ToNextLvExpChange                       { get; set; }
        public int                                      MstSupportCharaId                       { get; set; }
        public int                                      MstCharaInfoId                          { get; set; }
        public SupportCharacterRarity                   Rarity                                  { get; set; }
        public int                                      NextLv                                  { get; set; }

        public static SupportCharaStatusViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharaStatusViewModel() { Pointer= p0 };

            value.FavoriteMarkRP                            = GetObject<IntReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 0x10 FavoriteMarkRP              ( ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )
            value.TrainingTicketsTotalExpChangeRP           = GetObject<LongReactiveProperty>(new IntPtr(p + 0x030), ReversePrism.DataModels.LongReactiveProperty.FromPointer); // 0x30 TrainingTicketsTotalExpChangeRP ( ModelClassType LongReactiveProperty LongReactiveProperty LongReactiveProperty Pointer )
            value.CurrentExpProgressChangeRP                = GetObject<FloatReactiveProperty>(new IntPtr(p + 0x038), ReversePrism.DataModels.FloatReactiveProperty.FromPointer); // 0x38 CurrentExpProgressChangeRP  ( ModelClassType FloatReactiveProperty FloatReactiveProperty FloatReactiveProperty Pointer )
            value.ToNextLvExpChange                         = GetObject<LongReactiveProperty>(new IntPtr(p + 0x048), ReversePrism.DataModels.LongReactiveProperty.FromPointer); // 0x48 ToNextLvExpChange           ( ModelClassType LongReactiveProperty LongReactiveProperty LongReactiveProperty Pointer )
            value.MstSupportCharaId                         = GetInt32(new IntPtr(p + 0x058)); // 0x58 MstSupportCharaId           ( ModelPrimitiveType int int int Int32 )
            value.MstCharaInfoId                            = GetInt32(new IntPtr(p + 0x05C)); // 0x5C MstCharaInfoId              ( ModelPrimitiveType int int int Int32 )
            value.Rarity                                    = (SupportCharacterRarity)GetInt32(new IntPtr(p + 0x060)); // 0x60 Rarity                      ( ModelEnumType SupportCharacterRarity SupportCharacterRarity SupportCharacterRarity Int32 )
            value.NextLv                                    = GetInt32(new IntPtr(p + 0x064)); // 0x64 NextLv                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
