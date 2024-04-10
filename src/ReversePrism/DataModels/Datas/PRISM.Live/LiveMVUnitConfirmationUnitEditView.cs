using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 068 UnitEditCarousel                         0001865604E0 ModelClassType LiveMVUnitEditCarousel LiveMVUnitEditCarousel LiveMVUnitEditCarousel Pointer
    // 070 MVOriginalMemberView                     00018655BD80 ModelClassType LiveMVOriginalMemberView LiveMVOriginalMemberView LiveMVOriginalMemberView Pointer
    public partial class LiveMVUnitConfirmationUnitEditView : DataModel
    {
        public LiveMVUnitEditCarousel?                  UnitEditCarousel                        { get; set; }
        public LiveMVOriginalMemberView?                MVOriginalMemberView                    { get; set; }

        public static LiveMVUnitConfirmationUnitEditView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMVUnitConfirmationUnitEditView() { Pointer= p0 };

            value.UnitEditCarousel                          = GetObject<LiveMVUnitEditCarousel>(new IntPtr(p + 0x068), ReversePrism.DataModels.LiveMVUnitEditCarousel.FromPointer); // 024665214D78 0x68 UnitEditCarousel            ( 0001865604E0 ModelClassType LiveMVUnitEditCarousel LiveMVUnitEditCarousel LiveMVUnitEditCarousel Pointer )
            value.MVOriginalMemberView                      = GetObject<LiveMVOriginalMemberView>(new IntPtr(p + 0x070), ReversePrism.DataModels.LiveMVOriginalMemberView.FromPointer); // 024665214D98 0x70 MVOriginalMemberView        ( 00018655BD80 ModelClassType LiveMVOriginalMemberView LiveMVOriginalMemberView LiveMVOriginalMemberView Pointer )

            return value;
        }
    }
}
