using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetGalleryVoiceListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstCharacterInfoIdFieldNumber            int IL2CPP_TYPE_I4
    // 018 MstCharacterInfoId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 VoiceListFieldNumber                     int IL2CPP_TYPE_I4
    // 008 _repeated_voiceList_codec                FieldCodec`1<GalleryVoiceStatus> IL2CPP_TYPE_GENERICINST
    // 020 VoiceList                                000185CDA198 ModelClassListType RepeatedField`1<GalleryVoiceStatus> RepeatedField`1<GalleryVoiceStatus> List<GalleryVoiceStatus> Pointer
    public partial class GetGalleryVoiceListReply
    {
        public int                                      MstCharacterInfoId                      { get; set; }
        public List<GalleryVoiceStatus>?                VoiceList                               { get; set; }

        public static GetGalleryVoiceListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetGalleryVoiceListReply();

            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x018)); // 027004207E00 0x18 MstCharacterInfoId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.VoiceList                                 = GetObjectList<GalleryVoiceStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.GalleryVoiceStatus.FromPointer); // 027004207E60 0x20 VoiceList                   ( 000185CDA198 ModelClassListType RepeatedField`1<GalleryVoiceStatus> RepeatedField`1<GalleryVoiceStatus> List<GalleryVoiceStatus> Pointer )

            return value;
        }
    }
}
