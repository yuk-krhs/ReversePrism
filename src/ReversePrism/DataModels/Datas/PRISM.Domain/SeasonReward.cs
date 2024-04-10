using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rank                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 State                                    000186618DC0 ModelEnumType SeasonRewardState SeasonRewardState SeasonRewardState Int32
    // 018 ProductList                              000185D075A8 ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer
    // 020 RewardType                               0001866194D0 ModelEnumType SeasonRewardType SeasonRewardType SeasonRewardType Int32
    // 028 BeginDate                                000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    public partial class SeasonReward : DataModel
    {
        public int                                      Rank                                    { get; set; }
        public SeasonRewardState                        State                                   { get; set; }
        public List<IProductWithAmountStatus>?          ProductList                             { get; set; }
        public SeasonRewardType                         RewardType                              { get; set; }
        public DateTime                                 BeginDate                               { get; set; }

        public static SeasonReward? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SeasonReward() { Pointer= p0 };

            value.Rank                                      = GetInt32(new IntPtr(p + 0x010)); // 02466568EE78 0x10 Rank                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.State                                     = (SeasonRewardState)GetInt32(new IntPtr(p + 0x014)); // 02466568EE98 0x14 State                       ( 000186618DC0 ModelEnumType SeasonRewardState SeasonRewardState SeasonRewardState Int32 )
            value.ProductList                               = GetObjectList<IProductWithAmountStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 02466568EEB8 0x18 ProductList                 ( 000185D075A8 ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer )
            value.RewardType                                = (SeasonRewardType)GetInt32(new IntPtr(p + 0x020)); // 02466568EED8 0x20 RewardType                  ( 0001866194D0 ModelEnumType SeasonRewardType SeasonRewardType SeasonRewardType Int32 )
            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x028)); // 02466568EEF8 0x28 BeginDate                   ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )

            return value;
        }
    }
}
