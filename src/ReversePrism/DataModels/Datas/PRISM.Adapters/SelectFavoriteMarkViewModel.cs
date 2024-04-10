using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     000186715050 ModelEnumType SelectFavoriteMarkPopupType SelectFavoriteMarkPopupType SelectFavoriteMarkPopupType Int32
    // 018 FavoriteIconList                         000185B7EC60 ModelClassListType FavoriteIconViewModel[] FavoriteIconViewModel[] List<FavoriteIconViewModel> Pointer
    // 020 InitialSelectedMarkId                    0001865F4260 ModelPrimitiveType int int int Int32
    // 028 CurrentSelectedMark                      00018655B870 ModelClassType FavoriteIconViewModel FavoriteIconViewModel FavoriteIconViewModel Pointer
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

            value.Type                                      = (SelectFavoriteMarkPopupType)GetInt32(new IntPtr(p + 0x010)); // 024665F4BDE0 0x10 Type                        ( 000186715050 ModelEnumType SelectFavoriteMarkPopupType SelectFavoriteMarkPopupType SelectFavoriteMarkPopupType Int32 )
            value.FavoriteIconList                          = GetObjectList<FavoriteIconViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.FavoriteIconViewModel.FromPointer); // 024665F4BE00 0x18 FavoriteIconList            ( 000185B7EC60 ModelClassListType FavoriteIconViewModel[] FavoriteIconViewModel[] List<FavoriteIconViewModel> Pointer )
            value.InitialSelectedMarkId                     = GetInt32(new IntPtr(p + 0x020)); // 024665F4BE20 0x20 InitialSelectedMarkId       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.CurrentSelectedMark                       = GetObject<FavoriteIconViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.FavoriteIconViewModel.FromPointer); // 024665F4BE40 0x28 CurrentSelectedMark         ( 00018655B870 ModelClassType FavoriteIconViewModel FavoriteIconViewModel FavoriteIconViewModel Pointer )

            return value;
        }
    }
}
