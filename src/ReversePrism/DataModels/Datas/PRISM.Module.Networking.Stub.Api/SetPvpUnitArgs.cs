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
    // 018 MstEventId                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 UnitTypeFieldNumber                      int IL2CPP_TYPE_I4
    // 01C UnitType                                 0001865F87B0 ModelEnumType PvpUnitType PvpUnitType PvpUnitType Int32
    // 000 UnitMemberTypeFieldNumber                int IL2CPP_TYPE_I4
    // 020 UnitMemberType                           0001865F79D0 ModelEnumType PvpUnitMemberType PvpUnitMemberType PvpUnitMemberType Int32
    // 000 MstUnitIdFieldNumber                     int IL2CPP_TYPE_I4
    // 024 MstUnitId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 FesUnitIdFieldNumber                     int IL2CPP_TYPE_I4
    // 028 FesUnitId                                000186671910 ModelPrimitiveType string string string String
    // 000 MstProduceIdolIdListFieldNumber          int IL2CPP_TYPE_I4
    // 008 _repeated_mstProduceIdolIdList_codec     FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 030 MstProduceIdolIdList                     000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    public partial class SetPvpUnitArgs
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
            var value   = new SetPvpUnitArgs();

            value.MstEventId                                = GetInt32(new IntPtr(p + 0x018)); // 0270D274BA80 0x18 MstEventId                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UnitType                                  = (PvpUnitType)GetInt32(new IntPtr(p + 0x01C)); // 0270D274BAC0 0x1C UnitType                    ( 0001865F87B0 ModelEnumType PvpUnitType PvpUnitType PvpUnitType Int32 )
            value.UnitMemberType                            = (PvpUnitMemberType)GetInt32(new IntPtr(p + 0x020)); // 0270D274BB00 0x20 UnitMemberType              ( 0001865F79D0 ModelEnumType PvpUnitMemberType PvpUnitMemberType PvpUnitMemberType Int32 )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x024)); // 0270D274BB40 0x24 MstUnitId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.FesUnitId                                 = GetString(new IntPtr(p + 0x028)); // 0270D274BB80 0x28 FesUnitId                   ( 000186671910 ModelPrimitiveType string string string String )
            value.MstProduceIdolIdList                      = GetInt32List(new IntPtr(p + 0x030)); // 0270D274BBE0 0x30 MstProduceIdolIdList        ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )

            return value;
        }
    }
}
