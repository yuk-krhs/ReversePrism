using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CellList                                 0001865A9930 ModelClassType StoryTopFavoriteContentCellList StoryTopFavoriteContentCellList StoryTopFavoriteContentCellList Pointer
    // 028 StorySearchButton                        00018659BE60 ModelClassType StorySearchButton StorySearchButton StorySearchButton Pointer
    // 030 sortFilterPopupFactory                   PopupViewFactory`1<IStorySortFilterPopupView> IL2CPP_TYPE_GENERICINST
    public partial class StoryTopSearchContentView
    {
        public StoryTopFavoriteContentCellList?         CellList                                { get; set; }
        public StorySearchButton?                       StorySearchButton                       { get; set; }

        public static StoryTopSearchContentView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryTopSearchContentView();

            value.CellList                                  = GetObject<StoryTopFavoriteContentCellList>(new IntPtr(p + 0x020), ReversePrism.DataModels.StoryTopFavoriteContentCellList.FromPointer); // 0270DB9A67D8 0x20 CellList                    ( 0001865A9930 ModelClassType StoryTopFavoriteContentCellList StoryTopFavoriteContentCellList StoryTopFavoriteContentCellList Pointer )
            value.StorySearchButton                         = GetObject<StorySearchButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.StorySearchButton.FromPointer); // 0270DB9A67F8 0x28 StorySearchButton           ( 00018659BE60 ModelClassType StorySearchButton StorySearchButton StorySearchButton Pointer )

            return value;
        }
    }
}
