using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SetPvpUnitArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstEventIdFieldNumber                    int IL2CPP_TYPE_I4
    // 018 MstEventId                               ModelPrimitiveType int int int Int32
    // 000 UnitTypeFieldNumber                      int IL2CPP_TYPE_I4
    // 01C UnitType                                 ModelEnumType PvpUnitType PvpUnitType PvpUnitType Int32
    // 000 UnitMemberTypeFieldNumber                int IL2CPP_TYPE_I4
    // 020 UnitMemberType                           ModelEnumType PvpUnitMemberType PvpUnitMemberType PvpUnitMemberType Int32
    // 000 MstUnitIdFieldNumber                     int IL2CPP_TYPE_I4
    // 024 MstUnitId                                ModelPrimitiveType int int int Int32
    // 000 FesUnitIdFieldNumber                     int IL2CPP_TYPE_I4
    // 028 FesUnitId                                ModelPrimitiveType string string string String
    // 000 MstProduceIdolIdListFieldNumber          int IL2CPP_TYPE_I4
    // 008 _repeated_mstProduceIdolIdList_codec     FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 030 MstProduceIdolIdList                     ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    public partial class SetPvpUnitArgs : DataModel
    {
        public int                                      MstEventId                              { get; set; }
        public PvpUnitType                              UnitType                                { get; set; }
        public PvpUnitMemberType                        UnitMemberType                          { get; set; }
        public int                                      MstUnitId                               { get; set; }
        public string                                   FesUnitId                               { get; set; }
        public List<int>?                               MstProduceIdolIdList                    { get; set; }

        public static SetPvpUnitArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetPvpUnitArgs() { Pointer= p0 };

            value.MstEventId                                = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstEventId                  ( ModelPrimitiveType int int int Int32 )
            value.UnitType                                  = (PvpUnitType)GetInt32(new IntPtr(p + 0x01C)); // 0x1C UnitType                    ( ModelEnumType PvpUnitType PvpUnitType PvpUnitType Int32 )
            value.UnitMemberType                            = (PvpUnitMemberType)GetInt32(new IntPtr(p + 0x020)); // 0x20 UnitMemberType              ( ModelEnumType PvpUnitMemberType PvpUnitMemberType PvpUnitMemberType Int32 )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x024)); // 0x24 MstUnitId                   ( ModelPrimitiveType int int int Int32 )
            value.FesUnitId                                 = GetString(new IntPtr(p + 0x028)); // 0x28 FesUnitId                   ( ModelPrimitiveType string string string String )
            value.MstProduceIdolIdList                      = GetInt32List(new IntPtr(p + 0x030)); // 0x30 MstProduceIdolIdList        ( ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )

            return value;
        }
    }
}
