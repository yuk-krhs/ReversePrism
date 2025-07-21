using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetGalleryMovieListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstCharacterInfoIdFieldNumber            int IL2CPP_TYPE_I4
    // 018 MstCharacterInfoId                       ModelPrimitiveType int int int Int32
    // 000 MovieListFieldNumber                     int IL2CPP_TYPE_I4
    // 008 _repeated_movieList_codec                FieldCodec`1<GalleryMovieStatus> IL2CPP_TYPE_GENERICINST
    // 020 MovieList                                ModelClassListType RepeatedField`1<GalleryMovieStatus> RepeatedField`1<GalleryMovieStatus> List<GalleryMovieStatus> Pointer
    public partial class GetGalleryMovieListReply : DataModel
    {
        public int                                      MstCharacterInfoId                      { get; set; }
        public List<GalleryMovieStatus>?                MovieList                               { get; set; }

        public static GetGalleryMovieListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetGalleryMovieListReply() { Pointer= p0 };

            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstCharacterInfoId          ( ModelPrimitiveType int int int Int32 )
            value.MovieList                                 = GetObjectList<GalleryMovieStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.GalleryMovieStatus.FromPointer); // 0x20 MovieList                   ( ModelClassListType RepeatedField`1<GalleryMovieStatus> RepeatedField`1<GalleryMovieStatus> List<GalleryMovieStatus> Pointer )

            return value;
        }
    }
}
