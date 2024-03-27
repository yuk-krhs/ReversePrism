using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<IdolBaseRewardStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstIdolIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 MstIdolId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 BeforeParameterFieldNumber               int IL2CPP_TYPE_I4
    // 020 BeforeParameter                          0001866AC460 ModelClassType IdolBaseResultStatus IdolBaseResultStatus IdolBaseResultStatus Pointer
    // 000 AfterParameterFieldNumber                int IL2CPP_TYPE_I4
    // 028 AfterParameter                           0001866AC460 ModelClassType IdolBaseResultStatus IdolBaseResultStatus IdolBaseResultStatus Pointer
    // 000 IdolLevelExpFieldNumber                  int IL2CPP_TYPE_I4
    // 030 IdolLevelExp                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 DearnessLevelExpFieldNumber              int IL2CPP_TYPE_I4
    // 034 DearnessLevelExp                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 FanFieldNumber                           int IL2CPP_TYPE_I4
    // 038 Fan                                      0001865F7700 ModelPrimitiveType long long long Int64
    // 000 IdolLevelRewardListFieldNumber           int IL2CPP_TYPE_I4
    // 008 _repeated_idolLevelRewardList_codec      FieldCodec`1<IdolBaseLevelRewardStatus> IL2CPP_TYPE_GENERICINST
    // 040 IdolLevelRewardList                      000185CDF1F8 ModelClassListType RepeatedField`1<IdolBaseLevelRewardStatus> RepeatedField`1<IdolBaseLevelRewardStatus> List<IdolBaseLevelRewardStatus> Pointer
    // 000 DearnessLevelRewardListFieldNumber       int IL2CPP_TYPE_I4
    // 010 _repeated_dearnessLevelRewardList_codec  FieldCodec`1<IdolBaseLevelRewardStatus> IL2CPP_TYPE_GENERICINST
    // 048 DearnessLevelRewardList                  000185CDF1F8 ModelClassListType RepeatedField`1<IdolBaseLevelRewardStatus> RepeatedField`1<IdolBaseLevelRewardStatus> List<IdolBaseLevelRewardStatus> Pointer
    public partial class IdolBaseRewardStatus
    {
        public int                                      MstIdolId                               { get; set; }
        public IdolBaseResultStatus?                    BeforeParameter                         { get; set; }
        public IdolBaseResultStatus?                    AfterParameter                          { get; set; }
        public int                                      IdolLevelExp                            { get; set; }
        public int                                      DearnessLevelExp                        { get; set; }
        public long                                     Fan                                     { get; set; }
        public List<IdolBaseLevelRewardStatus>?         IdolLevelRewardList                     { get; set; }
        public List<IdolBaseLevelRewardStatus>?         DearnessLevelRewardList                 { get; set; }

        public static IdolBaseRewardStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolBaseRewardStatus();

            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x018)); // 0270D1CEAD88 0x18 MstIdolId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BeforeParameter                           = GetObject<IdolBaseResultStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IdolBaseResultStatus.FromPointer); // 0270D1CEADC8 0x20 BeforeParameter             ( 0001866AC460 ModelClassType IdolBaseResultStatus IdolBaseResultStatus IdolBaseResultStatus Pointer )
            value.AfterParameter                            = GetObject<IdolBaseResultStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IdolBaseResultStatus.FromPointer); // 0270D1CEAE08 0x28 AfterParameter              ( 0001866AC460 ModelClassType IdolBaseResultStatus IdolBaseResultStatus IdolBaseResultStatus Pointer )
            value.IdolLevelExp                              = GetInt32(new IntPtr(p + 0x030)); // 0270D1CEAE48 0x30 IdolLevelExp                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DearnessLevelExp                          = GetInt32(new IntPtr(p + 0x034)); // 0270D1CEAE88 0x34 DearnessLevelExp            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Fan                                       = GetInt64(new IntPtr(p + 0x038)); // 0270D1CEAEC8 0x38 Fan                         ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.IdolLevelRewardList                       = GetObjectList<IdolBaseLevelRewardStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IdolBaseLevelRewardStatus.FromPointer); // 0270D1CEAF28 0x40 IdolLevelRewardList         ( 000185CDF1F8 ModelClassListType RepeatedField`1<IdolBaseLevelRewardStatus> RepeatedField`1<IdolBaseLevelRewardStatus> List<IdolBaseLevelRewardStatus> Pointer )
            value.DearnessLevelRewardList                   = GetObjectList<IdolBaseLevelRewardStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.IdolBaseLevelRewardStatus.FromPointer); // 0270D1CEAF88 0x48 DearnessLevelRewardList     ( 000185CDF1F8 ModelClassListType RepeatedField`1<IdolBaseLevelRewardStatus> RepeatedField`1<IdolBaseLevelRewardStatus> List<IdolBaseLevelRewardStatus> Pointer )

            return value;
        }
    }
}
