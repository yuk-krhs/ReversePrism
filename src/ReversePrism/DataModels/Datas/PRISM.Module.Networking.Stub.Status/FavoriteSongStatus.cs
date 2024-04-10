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
    // 018 Slot                                     00018655C790 ModelEnumType FavoriteSongSlot FavoriteSongSlot FavoriteSongSlot Int32
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Name                                     000186671910 ModelPrimitiveType string string string String
    // 000 MstSongIdListFieldNumber                 int IL2CPP_TYPE_I4
    // 008 _repeated_mstSongIdList_codec            FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 028 MstSongIdList                            000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
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

            value.Slot                                      = (FavoriteSongSlot)GetInt32(new IntPtr(p + 0x018)); // 0246612C31E0 0x18 Slot                        ( 00018655C790 ModelEnumType FavoriteSongSlot FavoriteSongSlot FavoriteSongSlot Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 0246612C3220 0x20 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.MstSongIdList                             = GetInt32List(new IntPtr(p + 0x028)); // 0246612C3280 0x28 MstSongIdList               ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )

            return value;
        }
    }
}
