using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<PvpUnitStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 UnitTypeFieldNumber                      int IL2CPP_TYPE_I4
    // 018 UnitType                                 0001865F87B0 ModelEnumType PvpUnitType PvpUnitType PvpUnitType Int32
    // 000 UnitMemberTypeFieldNumber                int IL2CPP_TYPE_I4
    // 01C UnitMemberType                           0001865F79D0 ModelEnumType PvpUnitMemberType PvpUnitMemberType PvpUnitMemberType Int32
    // 000 SelectedProduceIdolUnitIdFieldNumber     int IL2CPP_TYPE_I4
    // 020 SelectedProduceIdolUnitId                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 FesUnitFieldNumber                       int IL2CPP_TYPE_I4
    // 028 FesUnit                                  0001865E42D0 ModelClassType PvpFesUnitStatus PvpFesUnitStatus PvpFesUnitStatus Pointer
    // 000 ProduceIdolUnitListFieldNumber           int IL2CPP_TYPE_I4
    // 008 _repeated_produceIdolUnitList_codec      FieldCodec`1<PvpProduceIdolUnitStatus> IL2CPP_TYPE_GENERICINST
    // 030 ProduceIdolUnitList                      000185CEDEA8 ModelClassListType RepeatedField`1<PvpProduceIdolUnitStatus> RepeatedField`1<PvpProduceIdolUnitStatus> List<PvpProduceIdolUnitStatus> Pointer
    public partial class PvpUnitStatus : DataModel
    {
        public PvpUnitType                              UnitType                                { get; set; }
        public PvpUnitMemberType                        UnitMemberType                          { get; set; }
        public int                                      SelectedProduceIdolUnitId               { get; set; }
        public PvpFesUnitStatus?                        FesUnit                                 { get; set; }
        public List<PvpProduceIdolUnitStatus>?          ProduceIdolUnitList                     { get; set; }

        public static PvpUnitStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpUnitStatus() { Pointer= p0 };

            value.UnitType                                  = (PvpUnitType)GetInt32(new IntPtr(p + 0x018)); // 0246613AB220 0x18 UnitType                    ( 0001865F87B0 ModelEnumType PvpUnitType PvpUnitType PvpUnitType Int32 )
            value.UnitMemberType                            = (PvpUnitMemberType)GetInt32(new IntPtr(p + 0x01C)); // 0246613AB260 0x1C UnitMemberType              ( 0001865F79D0 ModelEnumType PvpUnitMemberType PvpUnitMemberType PvpUnitMemberType Int32 )
            value.SelectedProduceIdolUnitId                 = GetInt32(new IntPtr(p + 0x020)); // 0246613AB2A0 0x20 SelectedProduceIdolUnitId   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.FesUnit                                   = GetObject<PvpFesUnitStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.PvpFesUnitStatus.FromPointer); // 0246613AB2E0 0x28 FesUnit                     ( 0001865E42D0 ModelClassType PvpFesUnitStatus PvpFesUnitStatus PvpFesUnitStatus Pointer )
            value.ProduceIdolUnitList                       = GetObjectList<PvpProduceIdolUnitStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.PvpProduceIdolUnitStatus.FromPointer); // 0246613AB340 0x30 ProduceIdolUnitList         ( 000185CEDEA8 ModelClassListType RepeatedField`1<PvpProduceIdolUnitStatus> RepeatedField`1<PvpProduceIdolUnitStatus> List<PvpProduceIdolUnitStatus> Pointer )

            return value;
        }
    }
}
