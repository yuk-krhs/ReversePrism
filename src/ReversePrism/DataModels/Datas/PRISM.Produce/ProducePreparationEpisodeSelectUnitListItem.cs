using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 TabIcon                                  ModelClassType UIImage UIImage UIImage Pointer
    // 048 SelectedFrameObj                         ModelClassType GameObject GameObject GameObject Pointer
    // 050 SpaceLine                                ModelClassType GameObject GameObject GameObject Pointer
    // 058 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 060 SelectedDisposable                       ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class ProducePreparationEpisodeSelectUnitListItem : DataModel
    {
        public UIImage?                                 TabIcon                                 { get; set; }
        public GameObject?                              SelectedFrameObj                        { get; set; }
        public GameObject?                              SpaceLine                               { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public IDisposable?                             SelectedDisposable                      { get; set; }

        public static ProducePreparationEpisodeSelectUnitListItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducePreparationEpisodeSelectUnitListItem() { Pointer= p0 };

            value.TabIcon                                   = GetObject<UIImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIImage.FromPointer); // 0x40 TabIcon                     ( ModelClassType UIImage UIImage UIImage Pointer )
            value.SelectedFrameObj                          = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 SelectedFrameObj            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SpaceLine                                 = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 SpaceLine                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x058), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x58 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.SelectedDisposable                        = GetObject<IDisposable>(new IntPtr(p + 0x060), ReversePrism.DataModels.IDisposable.FromPointer); // 0x60 SelectedDisposable          ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
