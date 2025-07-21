using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     ModelEnumType SelectFavoriteMarkPopupType SelectFavoriteMarkPopupType SelectFavoriteMarkPopupType Int32
    // 018 FavoriteIconList                         ModelClassListType FavoriteIconViewModel[] FavoriteIconViewModel[] List<FavoriteIconViewModel> Pointer
    // 020 InitialSelectedMarkId                    ModelPrimitiveType int int int Int32
    // 028 CurrentSelectedMark                      ModelClassType FavoriteIconViewModel FavoriteIconViewModel FavoriteIconViewModel Pointer
    public partial class SelectFavoriteMarkViewModel : DataModel
    {
        public SelectFavoriteMarkPopupType              Type                                    { get; set; }
        public List<FavoriteIconViewModel>?             FavoriteIconList                        { get; set; }
        public int                                      InitialSelectedMarkId                   { get; set; }
        public FavoriteIconViewModel?                   CurrentSelectedMark                     { get; set; }

        public static SelectFavoriteMarkViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelectFavoriteMarkViewModel() { Pointer= p0 };

            value.Type                                      = (SelectFavoriteMarkPopupType)GetInt32(new IntPtr(p + 0x010)); // 0x10 Type                        ( ModelEnumType SelectFavoriteMarkPopupType SelectFavoriteMarkPopupType SelectFavoriteMarkPopupType Int32 )
            value.FavoriteIconList                          = GetObjectList<FavoriteIconViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.FavoriteIconViewModel.FromPointer); // 0x18 FavoriteIconList            ( ModelClassListType FavoriteIconViewModel[] FavoriteIconViewModel[] List<FavoriteIconViewModel> Pointer )
            value.InitialSelectedMarkId                     = GetInt32(new IntPtr(p + 0x020)); // 0x20 InitialSelectedMarkId       ( ModelPrimitiveType int int int Int32 )
            value.CurrentSelectedMark                       = GetObject<FavoriteIconViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.FavoriteIconViewModel.FromPointer); // 0x28 CurrentSelectedMark         ( ModelClassType FavoriteIconViewModel FavoriteIconViewModel FavoriteIconViewModel Pointer )

            return value;
        }
    }
}
