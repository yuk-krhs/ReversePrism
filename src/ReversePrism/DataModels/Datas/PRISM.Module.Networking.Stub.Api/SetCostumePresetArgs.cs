using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SetCostumePresetArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 CostumePresetIdFieldNumber               int IL2CPP_TYPE_I4
    // 018 CostumePresetId                          000186671910 ModelPrimitiveType string string string String
    // 000 MstCostumeIdFieldNumber                  int IL2CPP_TYPE_I4
    // 020 MstCostumeId                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstHairstyleIdFieldNumber                int IL2CPP_TYPE_I4
    // 024 MstHairstyleId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstAccessoryIdListFieldNumber            int IL2CPP_TYPE_I4
    // 008 _repeated_mstAccessoryIdList_codec       FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 028 MstAccessoryIdList                       000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 PresetTypeFieldNumber                    int IL2CPP_TYPE_I4
    // 030 PresetType                               000186630A70 ModelEnumType CostumePresetType CostumePresetType CostumePresetType Int32
    public partial class SetCostumePresetArgs
    {
        public string                                   CostumePresetId                         { get; set; }
        public int                                      MstCostumeId                            { get; set; }
        public int                                      MstHairstyleId                          { get; set; }
        public List<int>?                               MstAccessoryIdList                      { get; set; }
        public CostumePresetType                        PresetType                              { get; set; }

        public static SetCostumePresetArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetCostumePresetArgs();

            value.CostumePresetId                           = GetString(new IntPtr(p + 0x018)); // 0270D0D7A260 0x18 CostumePresetId             ( 000186671910 ModelPrimitiveType string string string String )
            value.MstCostumeId                              = GetInt32(new IntPtr(p + 0x020)); // 0270D0D7A2A0 0x20 MstCostumeId                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstHairstyleId                            = GetInt32(new IntPtr(p + 0x024)); // 0270D0D7A2E0 0x24 MstHairstyleId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstAccessoryIdList                        = GetInt32List(new IntPtr(p + 0x028)); // 0270D0D7A340 0x28 MstAccessoryIdList          ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.PresetType                                = (CostumePresetType)GetInt32(new IntPtr(p + 0x030)); // 0270D0D7A380 0x30 PresetType                  ( 000186630A70 ModelEnumType CostumePresetType CostumePresetType CostumePresetType Int32 )

            return value;
        }
    }
}
