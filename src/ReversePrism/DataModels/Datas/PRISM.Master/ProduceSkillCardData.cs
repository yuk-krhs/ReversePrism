using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CardDatas                                ModelClassListType CardDataByRank[] CardDataByRank[] List<CardDataByRank> Pointer
    // 018 Rank                                     ModelPrimitiveType int int int Int32
    // 01C IsCostChange                             ModelPrimitiveType bool bool bool Bool
    // 020 ChangedCost                              ModelPrimitiveType int int int Int32
    public partial class ProduceSkillCardData : DataModel
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
            var value   = new ProduceSkillCardData() { Pointer= p0 };

            value.CardDatas                                 = GetObjectList<CardDataByRank>(new IntPtr(p + 0x010), ReversePrism.DataModels.CardDataByRank.FromPointer); // 0x10 CardDatas                   ( ModelClassListType CardDataByRank[] CardDataByRank[] List<CardDataByRank> Pointer )
            value.Rank                                      = GetInt32(new IntPtr(p + 0x018)); // 0x18 Rank                        ( ModelPrimitiveType int int int Int32 )
            value.IsCostChange                              = GetBool(new IntPtr(p + 0x01C)); // 0x1C IsCostChange                ( ModelPrimitiveType bool bool bool Bool )
            value.ChangedCost                               = GetInt32(new IntPtr(p + 0x020)); // 0x20 ChangedCost                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
