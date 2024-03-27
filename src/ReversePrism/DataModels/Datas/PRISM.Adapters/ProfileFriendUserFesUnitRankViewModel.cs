using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FesUnitRank                              00018668E5C0 ModelClassType IUserProfileFesUnitRankStatus IUserProfileFesUnitRankStatus IUserProfileFesUnitRankStatus Pointer
    // 018 UnitName                                 000186672F10 ModelPrimitiveType string string string String
    public partial class ProfileFriendUserFesUnitRankViewModel
    {
        public IUserProfileFesUnitRankStatus?           FesUnitRank                             { get; set; }
        public string                                   UnitName                                { get; set; }

        public static ProfileFriendUserFesUnitRankViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileFriendUserFesUnitRankViewModel();

            value.FesUnitRank                               = GetObject<IUserProfileFesUnitRankStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IUserProfileFesUnitRankStatus.FromPointer); // 0270D66B8998 0x10 FesUnitRank                 ( 00018668E5C0 ModelClassType IUserProfileFesUnitRankStatus IUserProfileFesUnitRankStatus IUserProfileFesUnitRankStatus Pointer )
            value.UnitName                                  = GetString(new IntPtr(p + 0x018)); // 0270D66B89B8 0x18 UnitName                    ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
