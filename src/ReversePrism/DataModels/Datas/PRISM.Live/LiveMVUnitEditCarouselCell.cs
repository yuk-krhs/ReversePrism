using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 CharacterIcons                           000185B91990 ModelClassListType LiveUnitEditCharacterIcon[] LiveUnitEditCharacterIcon[] List<LiveUnitEditCharacterIcon> Pointer
    // 040 IconDragHandler                          0001866AEF70 ModelClassType IdolIconDragHandler IdolIconDragHandler IdolIconDragHandler Pointer
    // 048 Unit                                     00018655D520 ModelClassType LiveMVUnit LiveMVUnit LiveMVUnit Pointer
    // 050 Canceller                                000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    public partial class LiveMVUnitEditCarouselCell : DataModel
    {
        public List<LiveUnitEditCharacterIcon>?         CharacterIcons                          { get; set; }
        public IdolIconDragHandler?                     IconDragHandler                         { get; set; }
        public LiveMVUnit?                              Unit                                    { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }

        public static LiveMVUnitEditCarouselCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMVUnitEditCarouselCell() { Pointer= p0 };

            value.CharacterIcons                            = GetObjectList<LiveUnitEditCharacterIcon>(new IntPtr(p + 0x038), ReversePrism.DataModels.LiveUnitEditCharacterIcon.FromPointer); // 024665218080 0x38 CharacterIcons              ( 000185B91990 ModelClassListType LiveUnitEditCharacterIcon[] LiveUnitEditCharacterIcon[] List<LiveUnitEditCharacterIcon> Pointer )
            value.IconDragHandler                           = GetObject<IdolIconDragHandler>(new IntPtr(p + 0x040), ReversePrism.DataModels.IdolIconDragHandler.FromPointer); // 0246652180A0 0x40 IconDragHandler             ( 0001866AEF70 ModelClassType IdolIconDragHandler IdolIconDragHandler IdolIconDragHandler Pointer )
            value.Unit                                      = GetObject<LiveMVUnit>(new IntPtr(p + 0x048), ReversePrism.DataModels.LiveMVUnit.FromPointer); // 0246652180C0 0x48 Unit                        ( 00018655D520 ModelClassType LiveMVUnit LiveMVUnit LiveMVUnit Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x050)); // 0246652180E0 0x50 Canceller                   ( 000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
