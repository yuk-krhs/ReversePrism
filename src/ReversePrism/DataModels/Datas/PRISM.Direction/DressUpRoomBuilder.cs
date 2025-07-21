using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     ModelClassType DressUpRoomView DressUpRoomView DressUpRoomView Pointer
    // 028 UiView                                   ModelClassType DressUpRoomUIView DressUpRoomUIView DressUpRoomUIView Pointer
    // 030 DressUpRoom3DViewer                      ModelClassType DressUpRoom3DViewer DressUpRoom3DViewer DressUpRoom3DViewer Pointer
    // 038 CostumeChangeView                        ModelClassType DressUpRoomCostumeChangeView DressUpRoomCostumeChangeView DressUpRoomCostumeChangeView Pointer
    public partial class DressUpRoomBuilder : DataModel
    {
        public DressUpRoomView?                         View                                    { get; set; }
        public DressUpRoomUIView?                       UiView                                  { get; set; }
        public DressUpRoom3DViewer?                     DressUpRoom3DViewer                     { get; set; }
        public DressUpRoomCostumeChangeView?            CostumeChangeView                       { get; set; }

        public static DressUpRoomBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DressUpRoomBuilder() { Pointer= p0 };

            value.View                                      = GetObject<DressUpRoomView>(new IntPtr(p + 0x020), ReversePrism.DataModels.DressUpRoomView.FromPointer); // 0x20 View                        ( ModelClassType DressUpRoomView DressUpRoomView DressUpRoomView Pointer )
            value.UiView                                    = GetObject<DressUpRoomUIView>(new IntPtr(p + 0x028), ReversePrism.DataModels.DressUpRoomUIView.FromPointer); // 0x28 UiView                      ( ModelClassType DressUpRoomUIView DressUpRoomUIView DressUpRoomUIView Pointer )
            value.DressUpRoom3DViewer                       = GetObject<DressUpRoom3DViewer>(new IntPtr(p + 0x030), ReversePrism.DataModels.DressUpRoom3DViewer.FromPointer); // 0x30 DressUpRoom3DViewer         ( ModelClassType DressUpRoom3DViewer DressUpRoom3DViewer DressUpRoom3DViewer Pointer )
            value.CostumeChangeView                         = GetObject<DressUpRoomCostumeChangeView>(new IntPtr(p + 0x038), ReversePrism.DataModels.DressUpRoomCostumeChangeView.FromPointer); // 0x38 CostumeChangeView           ( ModelClassType DressUpRoomCostumeChangeView DressUpRoomCostumeChangeView DressUpRoomCostumeChangeView Pointer )

            return value;
        }
    }
}
