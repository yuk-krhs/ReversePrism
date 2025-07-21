using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IdolIcons                                ModelClassListType LiveUnitEditCharacterIcon[] LiveUnitEditCharacterIcon[] List<LiveUnitEditCharacterIcon> Pointer
    // 028 IdolIconCanceller                        ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    // 030 IconDragHandler                          ModelClassType IdolIconDragHandler IdolIconDragHandler IdolIconDragHandler Pointer
    // 038 Context                                  ModelClassType LiveMVUnitEditCarouselContext LiveMVUnitEditCarouselContext LiveMVUnitEditCarouselContext Pointer
    // 040 IsInitialized                            ModelPrimitiveType bool bool bool Bool
    // 048 Unit                                     ModelClassType LiveMVUnit LiveMVUnit LiveMVUnit Pointer
    public partial class LiveMVUnitEditCarouselIdolView : DataModel
    {
        public List<LiveUnitEditCharacterIcon>?         IdolIcons                               { get; set; }
        public AutoCancellationTokenSource              IdolIconCanceller                       { get; set; }
        public IdolIconDragHandler?                     IconDragHandler                         { get; set; }
        public LiveMVUnitEditCarouselContext?           Context                                 { get; set; }
        public bool                                     IsInitialized                           { get; set; }
        public LiveMVUnit?                              Unit                                    { get; set; }

        public static LiveMVUnitEditCarouselIdolView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMVUnitEditCarouselIdolView() { Pointer= p0 };

            value.IdolIcons                                 = GetObjectList<LiveUnitEditCharacterIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveUnitEditCharacterIcon.FromPointer); // 0x20 IdolIcons                   ( ModelClassListType LiveUnitEditCharacterIcon[] LiveUnitEditCharacterIcon[] List<LiveUnitEditCharacterIcon> Pointer )
            value.IdolIconCanceller                         = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x028)); // 0x28 IdolIconCanceller           ( ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )
            value.IconDragHandler                           = GetObject<IdolIconDragHandler>(new IntPtr(p + 0x030), ReversePrism.DataModels.IdolIconDragHandler.FromPointer); // 0x30 IconDragHandler             ( ModelClassType IdolIconDragHandler IdolIconDragHandler IdolIconDragHandler Pointer )
            value.Context                                   = GetObject<LiveMVUnitEditCarouselContext>(new IntPtr(p + 0x038), ReversePrism.DataModels.LiveMVUnitEditCarouselContext.FromPointer); // 0x38 Context                     ( ModelClassType LiveMVUnitEditCarouselContext LiveMVUnitEditCarouselContext LiveMVUnitEditCarouselContext Pointer )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x040)); // 0x40 IsInitialized               ( ModelPrimitiveType bool bool bool Bool )
            value.Unit                                      = GetObject<LiveMVUnit>(new IntPtr(p + 0x048), ReversePrism.DataModels.LiveMVUnit.FromPointer); // 0x48 Unit                        ( ModelClassType LiveMVUnit LiveMVUnit LiveMVUnit Pointer )

            return value;
        }
    }
}
