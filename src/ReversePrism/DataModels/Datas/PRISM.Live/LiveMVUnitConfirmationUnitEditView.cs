using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 078 UnitEditCarousel                         ModelClassType LiveMVUnitEditCarousel LiveMVUnitEditCarousel LiveMVUnitEditCarousel Pointer
    // 080 MVOriginalMemberView                     ModelClassType LiveMVOriginalMemberView LiveMVOriginalMemberView LiveMVOriginalMemberView Pointer
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

            value.UnitEditCarousel                          = GetObject<LiveMVUnitEditCarousel>(new IntPtr(p + 0x078), ReversePrism.DataModels.LiveMVUnitEditCarousel.FromPointer); // 0x78 UnitEditCarousel            ( ModelClassType LiveMVUnitEditCarousel LiveMVUnitEditCarousel LiveMVUnitEditCarousel Pointer )
            value.MVOriginalMemberView                      = GetObject<LiveMVOriginalMemberView>(new IntPtr(p + 0x080), ReversePrism.DataModels.LiveMVOriginalMemberView.FromPointer); // 0x80 MVOriginalMemberView        ( ModelClassType LiveMVOriginalMemberView LiveMVOriginalMemberView LiveMVOriginalMemberView Pointer )

            return value;
        }
    }
}
