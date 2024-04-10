using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BeginDate                                000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<SeasonRewardStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 RankFieldNumber                          int IL2CPP_TYPE_I4
    // 028 Rank                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 StateFieldNumber                         int IL2CPP_TYPE_I4
    // 02C State                                    00018670C4A0 ModelEnumType SeasonRewardState SeasonRewardState SeasonRewardState Int32
    // 000 ProductListFieldNumber                   int IL2CPP_TYPE_I4
    // 008 _repeated_productList_codec              FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 030 ProductList                              000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    // 000 RewardTypeFieldNumber                    int IL2CPP_TYPE_I4
    // 038 RewardType                               00018670D110 ModelEnumType SeasonRewardType SeasonRewardType SeasonRewardType Int32
    // 000 BeginDateFieldNumber                     int IL2CPP_TYPE_I4
    // 040 _BeginDate                               000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    public partial class SeasonRewardStatus : DataModel
    {
        public DateTime                                 BeginDate                               { get; set; }
        public int                                      Rank                                    { get; set; }
        public SeasonRewardState                        State                                   { get; set; }
        public List<ProductWithAmountStatus>?           ProductList                             { get; set; }
        public SeasonRewardType                         RewardType                              { get; set; }
        public Timestamp?                               _BeginDate                              { get; set; }

        public static SeasonRewardStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SeasonRewardStatus() { Pointer= p0 };

            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x010)); // 0246626FE0D0 0x10 BeginDate                   ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.Rank                                      = GetInt32(new IntPtr(p + 0x028)); // 0246626FE150 0x28 Rank                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.State                                     = (SeasonRewardState)GetInt32(new IntPtr(p + 0x02C)); // 0246626FE190 0x2C State                       ( 00018670C4A0 ModelEnumType SeasonRewardState SeasonRewardState SeasonRewardState Int32 )
            value.ProductList                               = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0246626FE1F0 0x30 ProductList                 ( 000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )
            value.RewardType                                = (SeasonRewardType)GetInt32(new IntPtr(p + 0x038)); // 0246626FE230 0x38 RewardType                  ( 00018670D110 ModelEnumType SeasonRewardType SeasonRewardType SeasonRewardType Int32 )
            value._BeginDate                                = GetObject<Timestamp>(new IntPtr(p + 0x040), ReversePrism.DataModels.Timestamp.FromPointer); // 0246626FE270 0x40 _BeginDate                  ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.BeginDate                     = ToDateTime(value._BeginDate);

            return value;
        }
    }
}
