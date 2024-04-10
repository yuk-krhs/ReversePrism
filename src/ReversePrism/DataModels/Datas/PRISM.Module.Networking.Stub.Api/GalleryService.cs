using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetGalleryAlbumArgs     Marshaller`1<GetGalleryAlbumArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetGalleryAlbumReply    Marshaller`1<GetGalleryAlbumReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_GetGalleryCostumeListArgs Marshaller`1<GetGalleryCostumeListArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_GetGalleryCostumeListReply Marshaller`1<GetGalleryCostumeListReply> IL2CPP_TYPE_GENERICINST
    // 028 __Marshaller_api_GetGalleryVoiceListArgs Marshaller`1<GetGalleryVoiceListArgs> IL2CPP_TYPE_GENERICINST
    // 030 __Marshaller_api_GetGalleryVoiceListReply Marshaller`1<GetGalleryVoiceListReply> IL2CPP_TYPE_GENERICINST
    // 038 __Marshaller_api_GetGalleryMovieListArgs Marshaller`1<GetGalleryMovieListArgs> IL2CPP_TYPE_GENERICINST
    // 040 __Marshaller_api_GetGalleryMovieListReply Marshaller`1<GetGalleryMovieListReply> IL2CPP_TYPE_GENERICINST
    // 048 __Method_GetGalleryAlbum                 Method`2<GetGalleryAlbumArgs, GetGalleryAlbumReply> IL2CPP_TYPE_GENERICINST
    // 050 __Method_GetGalleryCostumeList           Method`2<GetGalleryCostumeListArgs, GetGalleryCostumeListReply> IL2CPP_TYPE_GENERICINST
    // 058 __Method_GetGalleryVoiceList             Method`2<GetGalleryVoiceListArgs, GetGalleryVoiceListReply> IL2CPP_TYPE_GENERICINST
    // 060 __Method_GetGalleryMovieList             Method`2<GetGalleryMovieListArgs, GetGalleryMovieListReply> IL2CPP_TYPE_GENERICINST
    public partial class GalleryService : DataModel
    {

        public static GalleryService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GalleryService() { Pointer= p0 };


            return value;
        }
    }
}
