using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<HomeSettingFavoriteIdolStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 FavoriteIdolDrawTypeFieldNumber          int IL2CPP_TYPE_I4
    // 018 FavoriteIdolDrawType                     0001866CBBC0 ModelEnumType HomeSettingFavoriteIdolDrawType HomeSettingFavoriteIdolDrawType HomeSettingFavoriteIdolDrawType Int32
    // 000 FavoriteMstIdolIdListFieldNumber         int IL2CPP_TYPE_I4
    // 008 _repeated_favoriteMstIdolIdList_codec    FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 020 FavoriteMstIdolIdList                    000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    public partial class HomeSettingFavoriteIdolStatus : DataModel
    {
        public HomeSettingFavoriteIdolDrawType          FavoriteIdolDrawType                    { get; set; }
        public List<int>?                               FavoriteMstIdolIdList                   { get; set; }

        public static HomeSettingFavoriteIdolStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeSettingFavoriteIdolStatus() { Pointer= p0 };

            value.FavoriteIdolDrawType                      = (HomeSettingFavoriteIdolDrawType)GetInt32(new IntPtr(p + 0x018)); // 024662029038 0x18 FavoriteIdolDrawType        ( 0001866CBBC0 ModelEnumType HomeSettingFavoriteIdolDrawType HomeSettingFavoriteIdolDrawType HomeSettingFavoriteIdolDrawType Int32 )
            value.FavoriteMstIdolIdList                     = GetInt32List(new IntPtr(p + 0x020)); // 024662029098 0x20 FavoriteMstIdolIdList       ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )

            return value;
        }
    }
}
