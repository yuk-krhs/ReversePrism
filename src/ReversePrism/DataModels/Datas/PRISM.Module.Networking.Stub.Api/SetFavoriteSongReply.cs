using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SetFavoriteSongReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 FavoriteSongListFieldNumber              int IL2CPP_TYPE_I4
    // 008 _repeated_favoriteSongList_codec         FieldCodec`1<FavoriteSongStatus> IL2CPP_TYPE_GENERICINST
    // 018 FavoriteSongList                         000185CD73C8 ModelClassListType RepeatedField`1<FavoriteSongStatus> RepeatedField`1<FavoriteSongStatus> List<FavoriteSongStatus> Pointer
    public partial class SetFavoriteSongReply
    {
        public List<FavoriteSongStatus>?                FavoriteSongList                        { get; set; }

        public static SetFavoriteSongReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetFavoriteSongReply();

            value.FavoriteSongList                          = GetObjectList<FavoriteSongStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.FavoriteSongStatus.FromPointer); // 0270D21E3DD8 0x18 FavoriteSongList            ( 000185CD73C8 ModelClassListType RepeatedField`1<FavoriteSongStatus> RepeatedField`1<FavoriteSongStatus> List<FavoriteSongStatus> Pointer )

            return value;
        }
    }
}
