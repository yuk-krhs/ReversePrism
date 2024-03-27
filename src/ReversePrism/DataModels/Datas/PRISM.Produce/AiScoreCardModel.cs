using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AiExternalAccess                         00018669C800 ModelClassType AiExternalAccess AiExternalAccess AiExternalAccess Pointer
    // 018 Card                                     0001866E49A0 ModelClassType IngamePCardModel IngamePCardModel IngamePCardModel Pointer
    public partial class AiScoreCardModel
    {
        public AiExternalAccess?                        AiExternalAccess                        { get; set; }
        public IngamePCardModel?                        Card                                    { get; set; }

        public static AiScoreCardModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AiScoreCardModel();

            value.AiExternalAccess                          = GetObject<AiExternalAccess>(new IntPtr(p + 0x010), ReversePrism.DataModels.AiExternalAccess.FromPointer); // 0270D5AAEF88 0x10 AiExternalAccess            ( 00018669C800 ModelClassType AiExternalAccess AiExternalAccess AiExternalAccess Pointer )
            value.Card                                      = GetObject<IngamePCardModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.IngamePCardModel.FromPointer); // 0270D5AAEFA8 0x18 Card                        ( 0001866E49A0 ModelClassType IngamePCardModel IngamePCardModel IngamePCardModel Pointer )

            return value;
        }
    }
}
