using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 Cells                                    ModelClassListType IdolStoryFirstCategoryCell[] IdolStoryFirstCategoryCell[] List<IdolStoryFirstCategoryCell> Pointer
    // 068 UnitIconImage                            ModelClassType UIImage UIImage UIImage Pointer
    // 070 CellDisposables                          ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 078 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class IdolStoryFirstCategoryCellGroup : DataModel
    {
        public List<IdolStoryFirstCategoryCell>?        Cells                                   { get; set; }
        public UIImage?                                 UnitIconImage                           { get; set; }
        public CompositeDisposable?                     CellDisposables                         { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }

        public static IdolStoryFirstCategoryCellGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolStoryFirstCategoryCellGroup() { Pointer= p0 };

            value.Cells                                     = GetObjectList<IdolStoryFirstCategoryCell>(new IntPtr(p + 0x060), ReversePrism.DataModels.IdolStoryFirstCategoryCell.FromPointer); // 0x60 Cells                       ( ModelClassListType IdolStoryFirstCategoryCell[] IdolStoryFirstCategoryCell[] List<IdolStoryFirstCategoryCell> Pointer )
            value.UnitIconImage                             = GetObject<UIImage>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIImage.FromPointer); // 0x68 UnitIconImage               ( ModelClassType UIImage UIImage UIImage Pointer )
            value.CellDisposables                           = GetObject<CompositeDisposable>(new IntPtr(p + 0x070), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x70 CellDisposables             ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x078), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x78 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
