using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GalleryMovieStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstGalleryMovieIdFieldNumber             int IL2CPP_TYPE_I4
    // 018 MstGalleryMovieId                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MovieTypeFieldNumber                     int IL2CPP_TYPE_I4
    // 01C MovieType                                0001865E3AD0 ModelEnumType GalleryMovieType GalleryMovieType GalleryMovieType Int32
    // 000 MstProduceIdolIdFieldNumber              int IL2CPP_TYPE_I4
    // 020 MstProduceIdolId                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstSupportCharacterIdFieldNumber         int IL2CPP_TYPE_I4
    // 024 MstSupportCharacterId                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 GashaEffectFieldNumber                   int IL2CPP_TYPE_I4
    // 028 GashaEffect                              0001865FB780 ModelClassType GashaEffectStatus GashaEffectStatus GashaEffectStatus Pointer
    // 000 EnableFieldNumber                        int IL2CPP_TYPE_I4
    // 030 Enable                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class GalleryMovieStatus
    {
        public int                                      MstGalleryMovieId                       { get; set; }
        public GalleryMovieType                         MovieType                               { get; set; }
        public int                                      MstProduceIdolId                        { get; set; }
        public int                                      MstSupportCharacterId                   { get; set; }
        public GashaEffectStatus?                       GashaEffect                             { get; set; }
        public bool                                     Enable                                  { get; set; }

        public static GalleryMovieStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GalleryMovieStatus();

            value.MstGalleryMovieId                         = GetInt32(new IntPtr(p + 0x018)); // 0270D157CC18 0x18 MstGalleryMovieId           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MovieType                                 = (GalleryMovieType)GetInt32(new IntPtr(p + 0x01C)); // 0270D157CC58 0x1C MovieType                   ( 0001865E3AD0 ModelEnumType GalleryMovieType GalleryMovieType GalleryMovieType Int32 )
            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x020)); // 0270D157CC98 0x20 MstProduceIdolId            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstSupportCharacterId                     = GetInt32(new IntPtr(p + 0x024)); // 0270D157CCD8 0x24 MstSupportCharacterId       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GashaEffect                               = GetObject<GashaEffectStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.GashaEffectStatus.FromPointer); // 0270D157CD18 0x28 GashaEffect                 ( 0001865FB780 ModelClassType GashaEffectStatus GashaEffectStatus GashaEffectStatus Pointer )
            value.Enable                                    = GetBool(new IntPtr(p + 0x030)); // 0270D157CD58 0x30 Enable                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
