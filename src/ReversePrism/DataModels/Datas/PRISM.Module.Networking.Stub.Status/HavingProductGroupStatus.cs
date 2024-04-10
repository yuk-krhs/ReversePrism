using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<HavingProductGroupStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 HavingProductListFieldNumber             int IL2CPP_TYPE_I4
    // 008 _repeated_havingProductList_codec        FieldCodec`1<HavingProductStatus> IL2CPP_TYPE_GENERICINST
    // 018 HavingProductList                        000185CDDF68 ModelClassListType RepeatedField`1<HavingProductStatus> RepeatedField`1<HavingProductStatus> List<HavingProductStatus> Pointer
    // 000 ProduceIdolListFieldNumber               int IL2CPP_TYPE_I4
    // 010 _repeated_produceIdolList_codec          FieldCodec`1<ProduceIdolStatus> IL2CPP_TYPE_GENERICINST
    // 020 ProduceIdolList                          000185CEBD88 ModelClassListType RepeatedField`1<ProduceIdolStatus> RepeatedField`1<ProduceIdolStatus> List<ProduceIdolStatus> Pointer
    // 000 SupportCharacterFieldNumber              int IL2CPP_TYPE_I4
    // 018 _repeated_supportCharacter_codec         FieldCodec`1<SupportCharacterStatus> IL2CPP_TYPE_GENERICINST
    // 028 SupportCharacter                         000185CF42A8 ModelClassListType RepeatedField`1<SupportCharacterStatus> RepeatedField`1<SupportCharacterStatus> List<SupportCharacterStatus> Pointer
    // 000 CostumeSetListFieldNumber                int IL2CPP_TYPE_I4
    // 020 _repeated_costumeSetList_codec           FieldCodec`1<CostumeSetStatus> IL2CPP_TYPE_GENERICINST
    // 030 CostumeSetList                           000185CD2998 ModelClassListType RepeatedField`1<CostumeSetStatus> RepeatedField`1<CostumeSetStatus> List<CostumeSetStatus> Pointer
    // 000 CostumeListFieldNumber                   int IL2CPP_TYPE_I4
    // 028 _repeated_costumeList_codec              FieldCodec`1<CostumeStatus> IL2CPP_TYPE_GENERICINST
    // 038 CostumeList                              000185CD2DF8 ModelClassListType RepeatedField`1<CostumeStatus> RepeatedField`1<CostumeStatus> List<CostumeStatus> Pointer
    // 000 HairstyleListFieldNumber                 int IL2CPP_TYPE_I4
    // 030 _repeated_hairstyleList_codec            FieldCodec`1<HairstyleStatus> IL2CPP_TYPE_GENERICINST
    // 040 HairstyleList                            000185CDDCF8 ModelClassListType RepeatedField`1<HairstyleStatus> RepeatedField`1<HairstyleStatus> List<HairstyleStatus> Pointer
    // 000 AccessoryListFieldNumber                 int IL2CPP_TYPE_I4
    // 038 _repeated_accessoryList_codec            FieldCodec`1<AccessoryStatus> IL2CPP_TYPE_GENERICINST
    // 048 AccessoryList                            000185CCD648 ModelClassListType RepeatedField`1<AccessoryStatus> RepeatedField`1<AccessoryStatus> List<AccessoryStatus> Pointer
    // 000 SongListFieldNumber                      int IL2CPP_TYPE_I4
    // 040 _repeated_songList_codec                 FieldCodec`1<SongStatus> IL2CPP_TYPE_GENERICINST
    // 050 SongList                                 000185CF1AB8 ModelClassListType RepeatedField`1<SongStatus> RepeatedField`1<SongStatus> List<SongStatus> Pointer
    public partial class HavingProductGroupStatus : DataModel
    {
        public List<HavingProductStatus>?               HavingProductList                       { get; set; }
        public List<ProduceIdolStatus>?                 ProduceIdolList                         { get; set; }
        public List<SupportCharacterStatus>?            SupportCharacter                        { get; set; }
        public List<CostumeSetStatus>?                  CostumeSetList                          { get; set; }
        public List<CostumeStatus>?                     CostumeList                             { get; set; }
        public List<HairstyleStatus>?                   HairstyleList                           { get; set; }
        public List<AccessoryStatus>?                   AccessoryList                           { get; set; }
        public List<SongStatus>?                        SongList                                { get; set; }

        public static HavingProductGroupStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HavingProductGroupStatus() { Pointer= p0 };

            value.HavingProductList                         = GetObjectList<HavingProductStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.HavingProductStatus.FromPointer); // 0246611A3458 0x18 HavingProductList           ( 000185CDDF68 ModelClassListType RepeatedField`1<HavingProductStatus> RepeatedField`1<HavingProductStatus> List<HavingProductStatus> Pointer )
            value.ProduceIdolList                           = GetObjectList<ProduceIdolStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceIdolStatus.FromPointer); // 0246611A34B8 0x20 ProduceIdolList             ( 000185CEBD88 ModelClassListType RepeatedField`1<ProduceIdolStatus> RepeatedField`1<ProduceIdolStatus> List<ProduceIdolStatus> Pointer )
            value.SupportCharacter                          = GetObjectList<SupportCharacterStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.SupportCharacterStatus.FromPointer); // 0246611A3518 0x28 SupportCharacter            ( 000185CF42A8 ModelClassListType RepeatedField`1<SupportCharacterStatus> RepeatedField`1<SupportCharacterStatus> List<SupportCharacterStatus> Pointer )
            value.CostumeSetList                            = GetObjectList<CostumeSetStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.CostumeSetStatus.FromPointer); // 0246611A3578 0x30 CostumeSetList              ( 000185CD2998 ModelClassListType RepeatedField`1<CostumeSetStatus> RepeatedField`1<CostumeSetStatus> List<CostumeSetStatus> Pointer )
            value.CostumeList                               = GetObjectList<CostumeStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.CostumeStatus.FromPointer); // 0246611A35D8 0x38 CostumeList                 ( 000185CD2DF8 ModelClassListType RepeatedField`1<CostumeStatus> RepeatedField`1<CostumeStatus> List<CostumeStatus> Pointer )
            value.HairstyleList                             = GetObjectList<HairstyleStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.HairstyleStatus.FromPointer); // 0246611A3638 0x40 HairstyleList               ( 000185CDDCF8 ModelClassListType RepeatedField`1<HairstyleStatus> RepeatedField`1<HairstyleStatus> List<HairstyleStatus> Pointer )
            value.AccessoryList                             = GetObjectList<AccessoryStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.AccessoryStatus.FromPointer); // 0246611A3698 0x48 AccessoryList               ( 000185CCD648 ModelClassListType RepeatedField`1<AccessoryStatus> RepeatedField`1<AccessoryStatus> List<AccessoryStatus> Pointer )
            value.SongList                                  = GetObjectList<SongStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.SongStatus.FromPointer); // 0246611A36F8 0x50 SongList                    ( 000185CF1AB8 ModelClassListType RepeatedField`1<SongStatus> RepeatedField`1<SongStatus> List<SongStatus> Pointer )

            return value;
        }
    }
}
