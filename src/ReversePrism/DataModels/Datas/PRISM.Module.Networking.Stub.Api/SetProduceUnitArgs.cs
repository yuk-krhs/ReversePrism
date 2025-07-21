using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SetProduceUnitArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstUnitIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 MstUnitId                                ModelPrimitiveType int int int Int32
    // 000 UnitNumberFieldNumber                    int IL2CPP_TYPE_I4
    // 01C UnitNumber                               ModelPrimitiveType int int int Int32
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Name                                     ModelPrimitiveType string string string String
    // 000 SetProduceUnitIdolListFieldNumber        int IL2CPP_TYPE_I4
    // 008 _repeated_setProduceUnitIdolList_codec   FieldCodec`1<SetProduceUnitIdolStatus> IL2CPP_TYPE_GENERICINST
    // 028 SetProduceUnitIdolList                   ModelClassListType RepeatedField`1<SetProduceUnitIdolStatus> RepeatedField`1<SetProduceUnitIdolStatus> List<SetProduceUnitIdolStatus> Pointer
    // 000 MstSupportCharacterIdListFieldNumber     int IL2CPP_TYPE_I4
    // 010 _repeated_mstSupportCharacterIdList_codec FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 030 MstSupportCharacterIdList                ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    public partial class SetProduceUnitArgs : DataModel
    {
        public int                                      MstUnitId                               { get; set; }
        public int                                      UnitNumber                              { get; set; }
        public string                                   Name                                    { get; set; }
        public List<SetProduceUnitIdolStatus>?          SetProduceUnitIdolList                  { get; set; }
        public List<int>?                               MstSupportCharacterIdList               { get; set; }

        public static SetProduceUnitArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetProduceUnitArgs() { Pointer= p0 };

            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstUnitId                   ( ModelPrimitiveType int int int Int32 )
            value.UnitNumber                                = GetInt32(new IntPtr(p + 0x01C)); // 0x1C UnitNumber                  ( ModelPrimitiveType int int int Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 0x20 Name                        ( ModelPrimitiveType string string string String )
            value.SetProduceUnitIdolList                    = GetObjectList<SetProduceUnitIdolStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.SetProduceUnitIdolStatus.FromPointer); // 0x28 SetProduceUnitIdolList      ( ModelClassListType RepeatedField`1<SetProduceUnitIdolStatus> RepeatedField`1<SetProduceUnitIdolStatus> List<SetProduceUnitIdolStatus> Pointer )
            value.MstSupportCharacterIdList                 = GetInt32List(new IntPtr(p + 0x030)); // 0x30 MstSupportCharacterIdList   ( ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )

            return value;
        }
    }
}
