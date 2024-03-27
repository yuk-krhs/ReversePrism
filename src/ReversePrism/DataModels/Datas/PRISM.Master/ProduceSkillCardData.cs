using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CardDatas                                000185CC08E8 ModelClassListType CardDataByRank[] CardDataByRank[] List<CardDataByRank> Pointer
    // 018 Rank                                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C IsCostChange                             000186595960 ModelPrimitiveType bool bool bool Bool
    // 020 ChangedCost                              0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class ProduceSkillCardData
    {
        public List<CardDataByRank>?                    CardDatas                               { get; set; }
        public int                                      Rank                                    { get; set; }
        public bool                                     IsCostChange                            { get; set; }
        public int                                      ChangedCost                             { get; set; }

        public static ProduceSkillCardData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceSkillCardData();

            value.CardDatas                                 = GetObjectList<CardDataByRank>(new IntPtr(p + 0x010), ReversePrism.DataModels.CardDataByRank.FromPointer); // 0270D50D0118 0x10 CardDatas                   ( 000185CC08E8 ModelClassListType CardDataByRank[] CardDataByRank[] List<CardDataByRank> Pointer )
            value.Rank                                      = GetInt32(new IntPtr(p + 0x018)); // 0270D50D0138 0x18 Rank                        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.IsCostChange                              = GetBool(new IntPtr(p + 0x01C)); // 0270D50D0158 0x1C IsCostChange                ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ChangedCost                               = GetInt32(new IntPtr(p + 0x020)); // 0270D50D0178 0x20 ChangedCost                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
