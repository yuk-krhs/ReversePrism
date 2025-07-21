using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FesUnitRank                              ModelClassType IUserProfileFesUnitRankStatus IUserProfileFesUnitRankStatus IUserProfileFesUnitRankStatus Pointer
    // 018 UnitName                                 ModelPrimitiveType string string string String
    public partial class ProfileFriendUserFesUnitRankViewModel : DataModel
    {
        public IUserProfileFesUnitRankStatus?           FesUnitRank                             { get; set; }
        public string                                   UnitName                                { get; set; }

        public static ProfileFriendUserFesUnitRankViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileFriendUserFesUnitRankViewModel() { Pointer= p0 };

            value.FesUnitRank                               = GetObject<IUserProfileFesUnitRankStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IUserProfileFesUnitRankStatus.FromPointer); // 0x10 FesUnitRank                 ( ModelClassType IUserProfileFesUnitRankStatus IUserProfileFesUnitRankStatus IUserProfileFesUnitRankStatus Pointer )
            value.UnitName                                  = GetString(new IntPtr(p + 0x018)); // 0x18 UnitName                    ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
