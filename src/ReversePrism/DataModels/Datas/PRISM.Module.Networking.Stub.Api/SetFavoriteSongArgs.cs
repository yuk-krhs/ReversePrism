using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SetFavoriteSongArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 UpdateListFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_updateList_codec               FieldCodec`1<FavoriteSongUpdateStatus> IL2CPP_TYPE_GENERICINST
    // 018 UpdateList                               ModelClassListType RepeatedField`1<FavoriteSongUpdateStatus> RepeatedField`1<FavoriteSongUpdateStatus> List<FavoriteSongUpdateStatus> Pointer
    // 000 MstSongIdFieldNumber                     int IL2CPP_TYPE_I4
    // 020 MstSongId                                ModelPrimitiveType int int int Int32
    public partial class SetFavoriteSongArgs : DataModel
    {
        public List<FavoriteSongUpdateStatus>?          UpdateList                              { get; set; }
        public int                                      MstSongId                               { get; set; }

        public static SetFavoriteSongArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetFavoriteSongArgs() { Pointer= p0 };

            value.UpdateList                                = GetObjectList<FavoriteSongUpdateStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.FavoriteSongUpdateStatus.FromPointer); // 0x18 UpdateList                  ( ModelClassListType RepeatedField`1<FavoriteSongUpdateStatus> RepeatedField`1<FavoriteSongUpdateStatus> List<FavoriteSongUpdateStatus> Pointer )
            value.MstSongId                                 = GetInt32(new IntPtr(p + 0x020)); // 0x20 MstSongId                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
