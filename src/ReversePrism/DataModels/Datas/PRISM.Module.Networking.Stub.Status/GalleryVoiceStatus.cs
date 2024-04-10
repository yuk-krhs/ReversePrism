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
    // 018 MstGalleryVoiceId                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 VoiceResourceFieldNumber                 int IL2CPP_TYPE_I4
    // 020 VoiceResource                            000186539B30 ModelClassType VoiceResourceStatus VoiceResourceStatus VoiceResourceStatus Pointer
    // 000 VoiceTypeFieldNumber                     int IL2CPP_TYPE_I4
    // 028 VoiceType                                0001865E56A0 ModelEnumType GalleryVoiceType GalleryVoiceType GalleryVoiceType Int32
    // 000 MstProduceIdolIdFieldNumber              int IL2CPP_TYPE_I4
    // 02C MstProduceIdolId                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstSupportCharacterIdFieldNumber         int IL2CPP_TYPE_I4
    // 030 MstSupportCharacterId                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstCostumeSetIdFieldNumber               int IL2CPP_TYPE_I4
    // 034 MstCostumeSetId                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 EnableFieldNumber                        int IL2CPP_TYPE_I4
    // 038 Enable                                   000186594D10 ModelPrimitiveType bool bool bool Bool
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

            value.MstGalleryVoiceId                         = GetInt32(new IntPtr(p + 0x018)); // 02466151F3B0 0x18 MstGalleryVoiceId           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.VoiceResource                             = GetObject<VoiceResourceStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.VoiceResourceStatus.FromPointer); // 02466151F3F0 0x20 VoiceResource               ( 000186539B30 ModelClassType VoiceResourceStatus VoiceResourceStatus VoiceResourceStatus Pointer )
            value.VoiceType                                 = (GalleryVoiceType)GetInt32(new IntPtr(p + 0x028)); // 02466151F430 0x28 VoiceType                   ( 0001865E56A0 ModelEnumType GalleryVoiceType GalleryVoiceType GalleryVoiceType Int32 )
            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x02C)); // 02466151F470 0x2C MstProduceIdolId            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstSupportCharacterId                     = GetInt32(new IntPtr(p + 0x030)); // 02466151F4B0 0x30 MstSupportCharacterId       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstCostumeSetId                           = GetInt32(new IntPtr(p + 0x034)); // 02466151F4F0 0x34 MstCostumeSetId             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Enable                                    = GetBool(new IntPtr(p + 0x038)); // 02466151F530 0x38 Enable                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
