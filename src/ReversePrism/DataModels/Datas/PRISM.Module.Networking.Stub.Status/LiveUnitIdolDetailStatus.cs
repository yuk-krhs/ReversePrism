using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<LiveUnitIdolDetailStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 UnitIdolTypeFieldNumber                  int IL2CPP_TYPE_I4
    // 018 UnitIdolType                             ModelEnumType LiveUnitIdolType LiveUnitIdolType LiveUnitIdolType Int32
    // 000 FesIdolIdFieldNumber                     int IL2CPP_TYPE_I4
    // 020 FesIdolId                                ModelPrimitiveType string string string String
    // 000 MstProduceIdolIdFieldNumber              int IL2CPP_TYPE_I4
    // 028 MstProduceIdolId                         ModelPrimitiveType int int int Int32
    // 000 MstCostumeIdFieldNumber                  int IL2CPP_TYPE_I4
    // 02C MstCostumeId                             ModelPrimitiveType int int int Int32
    // 000 MstHairstyleIdFieldNumber                int IL2CPP_TYPE_I4
    // 030 MstHairstyleId                           ModelPrimitiveType int int int Int32
    // 000 MstAccessoryIdListFieldNumber            int IL2CPP_TYPE_I4
    // 008 _repeated_mstAccessoryIdList_codec       FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 038 MstAccessoryIdList                       ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    public partial class LiveUnitIdolDetailStatus : DataModel
    {
        public LiveUnitIdolType                         UnitIdolType                            { get; set; }
        public string                                   FesIdolId                               { get; set; }
        public int                                      MstProduceIdolId                        { get; set; }
        public int                                      MstCostumeId                            { get; set; }
        public int                                      MstHairstyleId                          { get; set; }
        public List<int>?                               MstAccessoryIdList                      { get; set; }

        public static LiveUnitIdolDetailStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitIdolDetailStatus() { Pointer= p0 };

            value.UnitIdolType                              = (LiveUnitIdolType)GetInt32(new IntPtr(p + 0x018)); // 0x18 UnitIdolType                ( ModelEnumType LiveUnitIdolType LiveUnitIdolType LiveUnitIdolType Int32 )
            value.FesIdolId                                 = GetString(new IntPtr(p + 0x020)); // 0x20 FesIdolId                   ( ModelPrimitiveType string string string String )
            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x028)); // 0x28 MstProduceIdolId            ( ModelPrimitiveType int int int Int32 )
            value.MstCostumeId                              = GetInt32(new IntPtr(p + 0x02C)); // 0x2C MstCostumeId                ( ModelPrimitiveType int int int Int32 )
            value.MstHairstyleId                            = GetInt32(new IntPtr(p + 0x030)); // 0x30 MstHairstyleId              ( ModelPrimitiveType int int int Int32 )
            value.MstAccessoryIdList                        = GetInt32List(new IntPtr(p + 0x038)); // 0x38 MstAccessoryIdList          ( ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )

            return value;
        }
    }
}
