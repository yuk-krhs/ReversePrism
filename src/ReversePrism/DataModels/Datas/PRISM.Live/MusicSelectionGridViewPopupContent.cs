using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 GridView                                 ModelClassType MusicSelectionGridView MusicSelectionGridView MusicSelectionGridView Pointer
    // 068 SelectedMusic                            ModelClassType MusicData MusicData MusicData Pointer
    public partial class MusicSelectionGridViewPopupContent : DataModel
    {
        public MusicSelectionGridView?                  GridView                                { get; set; }
        public MusicData?                               SelectedMusic                           { get; set; }

        public static MusicSelectionGridViewPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicSelectionGridViewPopupContent() { Pointer= p0 };

            value.GridView                                  = GetObject<MusicSelectionGridView>(new IntPtr(p + 0x060), ReversePrism.DataModels.MusicSelectionGridView.FromPointer); // 0x60 GridView                    ( ModelClassType MusicSelectionGridView MusicSelectionGridView MusicSelectionGridView Pointer )
            value.SelectedMusic                             = GetObject<MusicData>(new IntPtr(p + 0x068), ReversePrism.DataModels.MusicData.FromPointer); // 0x68 SelectedMusic               ( ModelClassType MusicData MusicData MusicData Pointer )

            return value;
        }
    }
}
