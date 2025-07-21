using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 IdolView                                 ModelClassType LiveMVUnitEditCarouselIdolView LiveMVUnitEditCarouselIdolView LiveMVUnitEditCarouselIdolView Pointer
    // 040 IconDragHandler                          ModelClassType IdolIconDragHandler IdolIconDragHandler IdolIconDragHandler Pointer
    // 048 Unit                                     ModelClassType LiveMVUnit LiveMVUnit LiveMVUnit Pointer
    // 050 Canceller                                ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    public partial class LiveMVUnitEditCarouselCell : DataModel
    {
        public LiveMVUnitEditCarouselIdolView?          IdolView                                { get; set; }
        public IdolIconDragHandler?                     IconDragHandler                         { get; set; }
        public LiveMVUnit?                              Unit                                    { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }

        public static LiveMVUnitEditCarouselCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMVUnitEditCarouselCell() { Pointer= p0 };

            value.IdolView                                  = GetObject<LiveMVUnitEditCarouselIdolView>(new IntPtr(p + 0x038), ReversePrism.DataModels.LiveMVUnitEditCarouselIdolView.FromPointer); // 0x38 IdolView                    ( ModelClassType LiveMVUnitEditCarouselIdolView LiveMVUnitEditCarouselIdolView LiveMVUnitEditCarouselIdolView Pointer )
            value.IconDragHandler                           = GetObject<IdolIconDragHandler>(new IntPtr(p + 0x040), ReversePrism.DataModels.IdolIconDragHandler.FromPointer); // 0x40 IconDragHandler             ( ModelClassType IdolIconDragHandler IdolIconDragHandler IdolIconDragHandler Pointer )
            value.Unit                                      = GetObject<LiveMVUnit>(new IntPtr(p + 0x048), ReversePrism.DataModels.LiveMVUnit.FromPointer); // 0x48 Unit                        ( ModelClassType LiveMVUnit LiveMVUnit LiveMVUnit Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x050)); // 0x50 Canceller                   ( ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
