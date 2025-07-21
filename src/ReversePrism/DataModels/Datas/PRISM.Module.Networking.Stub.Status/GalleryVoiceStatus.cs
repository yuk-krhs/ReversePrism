using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GalleryVoiceStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstGalleryVoiceIdFieldNumber             int IL2CPP_TYPE_I4
    // 018 MstGalleryVoiceId                        ModelPrimitiveType int int int Int32
    // 000 VoiceResourceFieldNumber                 int IL2CPP_TYPE_I4
    // 020 VoiceResource                            ModelClassType VoiceResourceStatus VoiceResourceStatus VoiceResourceStatus Pointer
    // 000 VoiceTypeFieldNumber                     int IL2CPP_TYPE_I4
    // 028 VoiceType                                ModelEnumType GalleryVoiceType GalleryVoiceType GalleryVoiceType Int32
    // 000 MstProduceIdolIdFieldNumber              int IL2CPP_TYPE_I4
    // 02C MstProduceIdolId                         ModelPrimitiveType int int int Int32
    // 000 MstSupportCharacterIdFieldNumber         int IL2CPP_TYPE_I4
    // 030 MstSupportCharacterId                    ModelPrimitiveType int int int Int32
    // 000 MstCostumeSetIdFieldNumber               int IL2CPP_TYPE_I4
    // 034 MstCostumeSetId                          ModelPrimitiveType int int int Int32
    // 000 EnableFieldNumber                        int IL2CPP_TYPE_I4
    // 038 Enable                                   ModelPrimitiveType bool bool bool Bool
    public partial class GalleryVoiceStatus : DataModel
    {
        public int                                      MstGalleryVoiceId                       { get; set; }
        public VoiceResourceStatus?                     VoiceResource                           { get; set; }
        public GalleryVoiceType                         VoiceType                               { get; set; }
        public int                                      MstProduceIdolId                        { get; set; }
        public int                                      MstSupportCharacterId                   { get; set; }
        public int                                      MstCostumeSetId                         { get; set; }
        public bool                                     Enable                                  { get; set; }

        public static GalleryVoiceStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GalleryVoiceStatus() { Pointer= p0 };

            value.MstGalleryVoiceId                         = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstGalleryVoiceId           ( ModelPrimitiveType int int int Int32 )
            value.VoiceResource                             = GetObject<VoiceResourceStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.VoiceResourceStatus.FromPointer); // 0x20 VoiceResource               ( ModelClassType VoiceResourceStatus VoiceResourceStatus VoiceResourceStatus Pointer )
            value.VoiceType                                 = (GalleryVoiceType)GetInt32(new IntPtr(p + 0x028)); // 0x28 VoiceType                   ( ModelEnumType GalleryVoiceType GalleryVoiceType GalleryVoiceType Int32 )
            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x02C)); // 0x2C MstProduceIdolId            ( ModelPrimitiveType int int int Int32 )
            value.MstSupportCharacterId                     = GetInt32(new IntPtr(p + 0x030)); // 0x30 MstSupportCharacterId       ( ModelPrimitiveType int int int Int32 )
            value.MstCostumeSetId                           = GetInt32(new IntPtr(p + 0x034)); // 0x34 MstCostumeSetId             ( ModelPrimitiveType int int int Int32 )
            value.Enable                                    = GetBool(new IntPtr(p + 0x038)); // 0x38 Enable                      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
