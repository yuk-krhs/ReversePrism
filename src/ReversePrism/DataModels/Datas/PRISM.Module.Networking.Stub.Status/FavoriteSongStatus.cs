using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FavoriteSongStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SlotFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Slot                                     ModelEnumType FavoriteSongSlot FavoriteSongSlot FavoriteSongSlot Int32
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Name                                     ModelPrimitiveType string string string String
    // 000 MstSongIdListFieldNumber                 int IL2CPP_TYPE_I4
    // 008 _repeated_mstSongIdList_codec            FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 028 MstSongIdList                            ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    public partial class FavoriteSongStatus : DataModel
    {
        public FavoriteSongSlot                         Slot                                    { get; set; }
        public string                                   Name                                    { get; set; }
        public List<int>?                               MstSongIdList                           { get; set; }

        public static FavoriteSongStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FavoriteSongStatus() { Pointer= p0 };

            value.Slot                                      = (FavoriteSongSlot)GetInt32(new IntPtr(p + 0x018)); // 0x18 Slot                        ( ModelEnumType FavoriteSongSlot FavoriteSongSlot FavoriteSongSlot Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 0x20 Name                        ( ModelPrimitiveType string string string String )
            value.MstSongIdList                             = GetInt32List(new IntPtr(p + 0x028)); // 0x28 MstSongIdList               ( ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )

            return value;
        }
    }
}
