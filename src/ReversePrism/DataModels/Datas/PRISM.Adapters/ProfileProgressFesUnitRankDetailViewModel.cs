using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Status                                   00018668E5C0 ModelClassType IUserProfileFesUnitRankStatus IUserProfileFesUnitRankStatus IUserProfileFesUnitRankStatus Pointer
    // 018 Rank                                     00018660DDC0 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32
    // 020 Title                                    000186672F10 ModelPrimitiveType string string string String
    public partial class ProfileProgressFesUnitRankDetailViewModel
    {
        public IUserProfileFesUnitRankStatus?           Status                                  { get; set; }
        public ProduceParameterRank                     Rank                                    { get; set; }
        public string                                   Title                                   { get; set; }

        public static ProfileProgressFesUnitRankDetailViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileProgressFesUnitRankDetailViewModel();

            value.Status                                    = GetObject<IUserProfileFesUnitRankStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IUserProfileFesUnitRankStatus.FromPointer); // 0270D6695A60 0x10 Status                      ( 00018668E5C0 ModelClassType IUserProfileFesUnitRankStatus IUserProfileFesUnitRankStatus IUserProfileFesUnitRankStatus Pointer )
            value.Rank                                      = (ProduceParameterRank)GetInt32(new IntPtr(p + 0x018)); // 0270D6695A80 0x18 Rank                        ( 00018660DDC0 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32 )
            value.Title                                     = GetString(new IntPtr(p + 0x020)); // 0270D6695AA0 0x20 Title                       ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
