using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ProduceIdolUnitStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstUnitIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 MstUnitId                                ModelPrimitiveType int int int Int32
    // 000 UnitNumberFieldNumber                    int IL2CPP_TYPE_I4
    // 01C UnitNumber                               ModelPrimitiveType int int int Int32
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Name                                     ModelPrimitiveType string string string String
    // 000 ProduceUnitIdolListFieldNumber           int IL2CPP_TYPE_I4
    // 008 _repeated_produceUnitIdolList_codec      FieldCodec`1<ProduceUnitIdolStatus> IL2CPP_TYPE_GENERICINST
    // 028 ProduceUnitIdolList                      ModelClassListType RepeatedField`1<ProduceUnitIdolStatus> RepeatedField`1<ProduceUnitIdolStatus> List<ProduceUnitIdolStatus> Pointer
    // 000 SupportCharacterListFieldNumber          int IL2CPP_TYPE_I4
    // 010 _repeated_supportCharacterList_codec     FieldCodec`1<SupportCharacterStatus> IL2CPP_TYPE_GENERICINST
    // 030 SupportCharacterList                     ModelClassListType RepeatedField`1<SupportCharacterStatus> RepeatedField`1<SupportCharacterStatus> List<SupportCharacterStatus> Pointer
    // 000 UnitParameterFieldNumber                 int IL2CPP_TYPE_I4
    // 038 UnitParameter                            ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer
    public partial class ProduceIdolUnitStatus : DataModel
    {
        public int                                      MstUnitId                               { get; set; }
        public int                                      UnitNumber                              { get; set; }
        public string                                   Name                                    { get; set; }
        public List<ProduceUnitIdolStatus>?             ProduceUnitIdolList                     { get; set; }
        public List<SupportCharacterStatus>?            SupportCharacterList                    { get; set; }
        public ProduceParameterStatus?                  UnitParameter                           { get; set; }

        public static ProduceIdolUnitStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIdolUnitStatus() { Pointer= p0 };

            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstUnitId                   ( ModelPrimitiveType int int int Int32 )
            value.UnitNumber                                = GetInt32(new IntPtr(p + 0x01C)); // 0x1C UnitNumber                  ( ModelPrimitiveType int int int Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 0x20 Name                        ( ModelPrimitiveType string string string String )
            value.ProduceUnitIdolList                       = GetObjectList<ProduceUnitIdolStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceUnitIdolStatus.FromPointer); // 0x28 ProduceUnitIdolList         ( ModelClassListType RepeatedField`1<ProduceUnitIdolStatus> RepeatedField`1<ProduceUnitIdolStatus> List<ProduceUnitIdolStatus> Pointer )
            value.SupportCharacterList                      = GetObjectList<SupportCharacterStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.SupportCharacterStatus.FromPointer); // 0x30 SupportCharacterList        ( ModelClassListType RepeatedField`1<SupportCharacterStatus> RepeatedField`1<SupportCharacterStatus> List<SupportCharacterStatus> Pointer )
            value.UnitParameter                             = GetObject<ProduceParameterStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProduceParameterStatus.FromPointer); // 0x38 UnitParameter               ( ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer )

            return value;
        }
    }
}
