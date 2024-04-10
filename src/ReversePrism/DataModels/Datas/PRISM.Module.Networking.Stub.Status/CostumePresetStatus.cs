using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<CostumePresetStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 CostumePresetIdFieldNumber               int IL2CPP_TYPE_I4
    // 018 CostumePresetId                          000186671910 ModelPrimitiveType string string string String
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Name                                     000186671910 ModelPrimitiveType string string string String
    // 000 MstIdolIdFieldNumber                     int IL2CPP_TYPE_I4
    // 028 MstIdolId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 PresetNumberFieldNumber                  int IL2CPP_TYPE_I4
    // 02C PresetNumber                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstCostumeIdFieldNumber                  int IL2CPP_TYPE_I4
    // 030 MstCostumeId                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstHairstyleIdFieldNumber                int IL2CPP_TYPE_I4
    // 034 MstHairstyleId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstAccessoryIdListFieldNumber            int IL2CPP_TYPE_I4
    // 008 _repeated_mstAccessoryIdList_codec       FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 038 MstAccessoryIdList                       000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 PresetTypeFieldNumber                    int IL2CPP_TYPE_I4
    // 040 PresetType                               000186630A70 ModelEnumType CostumePresetType CostumePresetType CostumePresetType Int32
    public partial class CostumePresetStatus : DataModel
    {
        public string                                   CostumePresetId                         { get; set; }
        public string                                   Name                                    { get; set; }
        public int                                      MstIdolId                               { get; set; }
        public int                                      PresetNumber                            { get; set; }
        public int                                      MstCostumeId                            { get; set; }
        public int                                      MstHairstyleId                          { get; set; }
        public List<int>?                               MstAccessoryIdList                      { get; set; }
        public CostumePresetType                        PresetType                              { get; set; }

        public static CostumePresetStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumePresetStatus() { Pointer= p0 };

            value.CostumePresetId                           = GetString(new IntPtr(p + 0x018)); // 024660EF9698 0x18 CostumePresetId             ( 000186671910 ModelPrimitiveType string string string String )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 024660EF96D8 0x20 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x028)); // 024660EF9718 0x28 MstIdolId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PresetNumber                              = GetInt32(new IntPtr(p + 0x02C)); // 024660EF9758 0x2C PresetNumber                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstCostumeId                              = GetInt32(new IntPtr(p + 0x030)); // 024660EF9798 0x30 MstCostumeId                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstHairstyleId                            = GetInt32(new IntPtr(p + 0x034)); // 024660EF97D8 0x34 MstHairstyleId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstAccessoryIdList                        = GetInt32List(new IntPtr(p + 0x038)); // 024660EF9838 0x38 MstAccessoryIdList          ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.PresetType                                = (CostumePresetType)GetInt32(new IntPtr(p + 0x040)); // 024660EF9878 0x40 PresetType                  ( 000186630A70 ModelEnumType CostumePresetType CostumePresetType CostumePresetType Int32 )

            return value;
        }
    }
}
