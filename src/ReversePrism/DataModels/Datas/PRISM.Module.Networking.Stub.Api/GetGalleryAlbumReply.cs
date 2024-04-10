using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetGalleryAlbumReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstCharacterInfoIdFieldNumber            int IL2CPP_TYPE_I4
    // 018 MstCharacterInfoId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstUnitIdFieldNumber                     int IL2CPP_TYPE_I4
    // 01C MstUnitId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ProduceIdolListFieldNumber               int IL2CPP_TYPE_I4
    // 008 _repeated_produceIdolList_codec          FieldCodec`1<GalleryAlbumProduceIdolStatus> IL2CPP_TYPE_GENERICINST
    // 020 ProduceIdolList                          000185CD9688 ModelClassListType RepeatedField`1<GalleryAlbumProduceIdolStatus> RepeatedField`1<GalleryAlbumProduceIdolStatus> List<GalleryAlbumProduceIdolStatus> Pointer
    // 000 SupportCharacterListFieldNumber          int IL2CPP_TYPE_I4
    // 010 _repeated_supportCharacterList_codec     FieldCodec`1<GalleryAlbumSupportCharacterStatus> IL2CPP_TYPE_GENERICINST
    // 028 SupportCharacterList                     000185CD9898 ModelClassListType RepeatedField`1<GalleryAlbumSupportCharacterStatus> RepeatedField`1<GalleryAlbumSupportCharacterStatus> List<GalleryAlbumSupportCharacterStatus> Pointer
    public partial class GetGalleryAlbumReply : DataModel
    {
        public int                                      MstCharacterInfoId                      { get; set; }
        public int                                      MstUnitId                               { get; set; }
        public List<GalleryAlbumProduceIdolStatus>?     ProduceIdolList                         { get; set; }
        public List<GalleryAlbumSupportCharacterStatus>? SupportCharacterList                    { get; set; }

        public static GetGalleryAlbumReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetGalleryAlbumReply() { Pointer= p0 };

            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x018)); // 024661513F98 0x18 MstCharacterInfoId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x01C)); // 024661513FD8 0x1C MstUnitId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ProduceIdolList                           = GetObjectList<GalleryAlbumProduceIdolStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.GalleryAlbumProduceIdolStatus.FromPointer); // 024661514038 0x20 ProduceIdolList             ( 000185CD9688 ModelClassListType RepeatedField`1<GalleryAlbumProduceIdolStatus> RepeatedField`1<GalleryAlbumProduceIdolStatus> List<GalleryAlbumProduceIdolStatus> Pointer )
            value.SupportCharacterList                      = GetObjectList<GalleryAlbumSupportCharacterStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.GalleryAlbumSupportCharacterStatus.FromPointer); // 024661514098 0x28 SupportCharacterList        ( 000185CD9898 ModelClassListType RepeatedField`1<GalleryAlbumSupportCharacterStatus> RepeatedField`1<GalleryAlbumSupportCharacterStatus> List<GalleryAlbumSupportCharacterStatus> Pointer )

            return value;
        }
    }
}
