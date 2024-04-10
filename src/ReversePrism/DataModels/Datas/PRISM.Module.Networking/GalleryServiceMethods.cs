using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetGalleryAlbum                          Method`2<IGetGalleryAlbumArgs, IGetGalleryAlbumReply> IL2CPP_TYPE_GENERICINST
    // 018 GetGalleryCostumeList                    Method`2<IGetGalleryCostumeListArgs, IGetGalleryCostumeListReply> IL2CPP_TYPE_GENERICINST
    // 030 GetGalleryVoiceList                      Method`2<IGetGalleryVoiceListArgs, IGetGalleryVoiceListReply> IL2CPP_TYPE_GENERICINST
    // 048 GetGalleryMovieList                      Method`2<IGetGalleryMovieListArgs, IGetGalleryMovieListReply> IL2CPP_TYPE_GENERICINST
    public partial class GalleryServiceMethods : DataModel
    {

        public static GalleryServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GalleryServiceMethods() { Pointer= p0 };


            return value;
        }
    }
}
