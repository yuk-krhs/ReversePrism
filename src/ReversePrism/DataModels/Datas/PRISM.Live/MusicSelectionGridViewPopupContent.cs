using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 GridView                                 000186675A00 ModelClassType MusicSelectionGridView MusicSelectionGridView MusicSelectionGridView Pointer
    // 068 SelectedMusic                            000186664B50 ModelClassType MusicData MusicData MusicData Pointer
    public partial class MusicSelectionGridViewPopupContent
    {
        public MusicSelectionGridView?                  GridView                                { get; set; }
        public MusicData?                               SelectedMusic                           { get; set; }

        public static MusicSelectionGridViewPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicSelectionGridViewPopupContent();

            value.GridView                                  = GetObject<MusicSelectionGridView>(new IntPtr(p + 0x060), ReversePrism.DataModels.MusicSelectionGridView.FromPointer); // 0270D5223780 0x60 GridView                    ( 000186675A00 ModelClassType MusicSelectionGridView MusicSelectionGridView MusicSelectionGridView Pointer )
            value.SelectedMusic                             = GetObject<MusicData>(new IntPtr(p + 0x068), ReversePrism.DataModels.MusicData.FromPointer); // 0270D52237A0 0x68 SelectedMusic               ( 000186664B50 ModelClassType MusicData MusicData MusicData Pointer )

            return value;
        }
    }
}
