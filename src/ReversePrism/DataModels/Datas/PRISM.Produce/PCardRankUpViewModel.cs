using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Model                                    0001867024F0 ModelClassType PCardRankUpModel PCardRankUpModel PCardRankUpModel Pointer
    public partial class PCardRankUpViewModel
    {
        public PCardRankUpModel?                        Model                                   { get; set; }

        public static PCardRankUpViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PCardRankUpViewModel();

            value.Model                                     = GetObject<PCardRankUpModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.PCardRankUpModel.FromPointer); // 0270D5CE9E90 0x10 Model                       ( 0001867024F0 ModelClassType PCardRankUpModel PCardRankUpModel PCardRankUpModel Pointer )

            return value;
        }
    }
}
