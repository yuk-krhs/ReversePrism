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
    public partial class AiScoreCardModel : DataModel
    {
        public AiExternalAccess?                        AiExternalAccess                        { get; set; }
        public IngamePCardModel?                        Card                                    { get; set; }

        public static AiScoreCardModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AiScoreCardModel() { Pointer= p0 };

            value.AiExternalAccess                          = GetObject<AiExternalAccess>(new IntPtr(p + 0x010), ReversePrism.DataModels.AiExternalAccess.FromPointer); // 024665B1F940 0x10 AiExternalAccess            ( 00018669C800 ModelClassType AiExternalAccess AiExternalAccess AiExternalAccess Pointer )
            value.Card                                      = GetObject<IngamePCardModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.IngamePCardModel.FromPointer); // 024665B1F960 0x18 Card                        ( 0001866E49A0 ModelClassType IngamePCardModel IngamePCardModel IngamePCardModel Pointer )

            return value;
        }
    }
}
