using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 CellButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 068 ThumbnailImage                           ModelClassType UIImage UIImage UIImage Pointer
    // 070 NewBadge                                 ModelClassType GameObject GameObject GameObject Pointer
    // 078 UnreadBadge                              ModelClassType GameObject GameObject GameObject Pointer
    // 080 Title                                    ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 090 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class ExtraStoryFirstCategoryCell : DataModel
    {
        public UIButton?                                CellButton                              { get; set; }
        public UIImage?                                 ThumbnailImage                          { get; set; }
        public GameObject?                              NewBadge                                { get; set; }
        public GameObject?                              UnreadBadge                             { get; set; }
        public UITextMeshProUGUI?                       Title                                   { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static ExtraStoryFirstCategoryCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtraStoryFirstCategoryCell() { Pointer= p0 };

            value.CellButton                                = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 0x60 CellButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ThumbnailImage                            = GetObject<UIImage>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIImage.FromPointer); // 0x68 ThumbnailImage              ( ModelClassType UIImage UIImage UIImage Pointer )
            value.NewBadge                                  = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 NewBadge                    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.UnreadBadge                               = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0x78 UnreadBadge                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Title                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x80 Title                       ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x088), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x88 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x090), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x90 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
