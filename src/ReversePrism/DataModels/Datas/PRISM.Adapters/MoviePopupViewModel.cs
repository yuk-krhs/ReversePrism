using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CurrentTabType                           ModelEnumType MovieCategory MovieCategory MovieCategory Int32
    // 018 PIdolList                                ModelClassListType List`1<ICategoryElementGridCellViewModel> List`1<ICategoryElementGridCellViewModel> List<ICategoryElementGridCellViewModel> Pointer
    // 020 SCharaList                               ModelClassListType List`1<ICategoryElementGridCellViewModel> List`1<ICategoryElementGridCellViewModel> List<ICategoryElementGridCellViewModel> Pointer
    // 028 IsActive                                 ModelPrimitiveType bool bool bool Bool
    public partial class MoviePopupViewModel : DataModel
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
            var value   = new MoviePopupViewModel() { Pointer= p0 };

            value.CurrentTabType                            = (MovieCategory)GetInt32(new IntPtr(p + 0x010)); // 0x10 CurrentTabType              ( ModelEnumType MovieCategory MovieCategory MovieCategory Int32 )
            value.PIdolList                                 = GetObjectList<ICategoryElementGridCellViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ICategoryElementGridCellViewModel.FromPointer); // 0x18 PIdolList                   ( ModelClassListType List`1<ICategoryElementGridCellViewModel> List`1<ICategoryElementGridCellViewModel> List<ICategoryElementGridCellViewModel> Pointer )
            value.SCharaList                                = GetObjectList<ICategoryElementGridCellViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.ICategoryElementGridCellViewModel.FromPointer); // 0x20 SCharaList                  ( ModelClassListType List`1<ICategoryElementGridCellViewModel> List`1<ICategoryElementGridCellViewModel> List<ICategoryElementGridCellViewModel> Pointer )
            value.IsActive                                  = GetBool(new IntPtr(p + 0x028)); // 0x28 IsActive                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
