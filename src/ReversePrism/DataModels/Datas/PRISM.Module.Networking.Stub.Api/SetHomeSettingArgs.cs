using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SetHomeSettingArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 FavoriteIdolSettingFieldNumber           int IL2CPP_TYPE_I4
    // 018 FavoriteIdolSetting                      0001866CC290 ModelClassType HomeSettingFavoriteIdolStatus HomeSettingFavoriteIdolStatus HomeSettingFavoriteIdolStatus Pointer
    public partial class SetHomeSettingArgs : DataModel
    {
        public HomeSettingFavoriteIdolStatus?           FavoriteIdolSetting                     { get; set; }

        public static SetHomeSettingArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetHomeSettingArgs() { Pointer= p0 };

            value.FavoriteIdolSetting                       = GetObject<HomeSettingFavoriteIdolStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.HomeSettingFavoriteIdolStatus.FromPointer); // 024662017880 0x18 FavoriteIdolSetting         ( 0001866CC290 ModelClassType HomeSettingFavoriteIdolStatus HomeSettingFavoriteIdolStatus HomeSettingFavoriteIdolStatus Pointer )

            return value;
        }
    }
}
