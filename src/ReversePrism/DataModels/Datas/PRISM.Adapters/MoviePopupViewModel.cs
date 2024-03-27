using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CurrentTabType                           000186656E80 ModelEnumType MovieCategory MovieCategory MovieCategory Int32
    // 018 PIdolList                                000185CE1848 ModelClassListType List`1<ICategoryElementGridCellViewModel> List`1<ICategoryElementGridCellViewModel> List<ICategoryElementGridCellViewModel> Pointer
    // 020 SCharaList                               000185CE1848 ModelClassListType List`1<ICategoryElementGridCellViewModel> List`1<ICategoryElementGridCellViewModel> List<ICategoryElementGridCellViewModel> Pointer
    // 028 IsActive                                 0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class MoviePopupViewModel
    {
        public MovieCategory                            CurrentTabType                          { get; set; }
        public List<ICategoryElementGridCellViewModel>? PIdolList                               { get; set; }
        public List<ICategoryElementGridCellViewModel>? SCharaList                              { get; set; }
        public bool                                     IsActive                                { get; set; }

        public static MoviePopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MoviePopupViewModel();

            value.CurrentTabType                            = (MovieCategory)GetInt32(new IntPtr(p + 0x010)); // 0270D5E81D18 0x10 CurrentTabType              ( 000186656E80 ModelEnumType MovieCategory MovieCategory MovieCategory Int32 )
            value.PIdolList                                 = GetObjectList<ICategoryElementGridCellViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ICategoryElementGridCellViewModel.FromPointer); // 0270D5E81D38 0x18 PIdolList                   ( 000185CE1848 ModelClassListType List`1<ICategoryElementGridCellViewModel> List`1<ICategoryElementGridCellViewModel> List<ICategoryElementGridCellViewModel> Pointer )
            value.SCharaList                                = GetObjectList<ICategoryElementGridCellViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.ICategoryElementGridCellViewModel.FromPointer); // 0270D5E81D58 0x20 SCharaList                  ( 000185CE1848 ModelClassListType List`1<ICategoryElementGridCellViewModel> List`1<ICategoryElementGridCellViewModel> List<ICategoryElementGridCellViewModel> Pointer )
            value.IsActive                                  = GetBool(new IntPtr(p + 0x028)); // 0270D5E81D78 0x28 IsActive                    ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
