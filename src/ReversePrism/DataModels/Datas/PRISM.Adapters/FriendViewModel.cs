using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CategoryViewModels                       000185B80150 ModelClassListType FriendCategoryListViewModel[] FriendCategoryListViewModel[] List<FriendCategoryListViewModel> Pointer
    // 018 FriendViewModelList                      000185CDCD88 ModelClassListType List`1<FriendListViewModel> List`1<FriendListViewModel> List<FriendListViewModel> Pointer
    // 020 Cursor                                   000186671910 ModelPrimitiveType string string string String
    // 028 ListCount                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C MaxListCount                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 LastFollowerDateTime                     000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    public partial class FriendViewModel
    {
        public List<FriendCategoryListViewModel>?       CategoryViewModels                      { get; set; }
        public List<FriendListViewModel>?               FriendViewModelList                     { get; set; }
        public string                                   Cursor                                  { get; set; }
        public int                                      ListCount                               { get; set; }
        public int                                      MaxListCount                            { get; set; }
        public DateTime                                 LastFollowerDateTime                    { get; set; }

        public static FriendViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FriendViewModel();

            value.CategoryViewModels                        = GetObjectList<FriendCategoryListViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.FriendCategoryListViewModel.FromPointer); // 0270D63220F8 0x10 CategoryViewModels          ( 000185B80150 ModelClassListType FriendCategoryListViewModel[] FriendCategoryListViewModel[] List<FriendCategoryListViewModel> Pointer )
            value.FriendViewModelList                       = GetObjectList<FriendListViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.FriendListViewModel.FromPointer); // 0270D6322118 0x18 FriendViewModelList         ( 000185CDCD88 ModelClassListType List`1<FriendListViewModel> List`1<FriendListViewModel> List<FriendListViewModel> Pointer )
            value.Cursor                                    = GetString(new IntPtr(p + 0x020)); // 0270D6322138 0x20 Cursor                      ( 000186671910 ModelPrimitiveType string string string String )
            value.ListCount                                 = GetInt32(new IntPtr(p + 0x028)); // 0270D6322158 0x28 ListCount                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MaxListCount                              = GetInt32(new IntPtr(p + 0x02C)); // 0270D6322178 0x2C MaxListCount                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LastFollowerDateTime                      = GetDateTime(new IntPtr(p + 0x030)); // 0270D6322198 0x30 LastFollowerDateTime        ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )

            return value;
        }
    }
}
