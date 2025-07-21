using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IAdvScreenView IAdvScreenView IAdvScreenView Pointer
    // 018 ViewModel                                ModelClassType AdvScreenViewModel AdvScreenViewModel AdvScreenViewModel Pointer
    // 020 AdvMenuPresenter                         ModelClassType AdvMenuPresenter AdvMenuPresenter AdvMenuPresenter Pointer
    // 028 AdvMenuOptionButtonContainerViewModel    ModelClassType AdvMenuOptionButtonContainerViewModel AdvMenuOptionButtonContainerViewModel AdvMenuOptionButtonContainerViewModel Pointer
    // 030 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 038 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 040 IsTapped                                 ModelPrimitiveType bool bool bool Bool
    public partial class AdvScreenPresenter : DataModel
    {
        public IAdvScreenView?                          View                                    { get; set; }
        public AdvScreenViewModel?                      ViewModel                               { get; set; }
        public AdvMenuPresenter?                        AdvMenuPresenter                        { get; set; }
        public AdvMenuOptionButtonContainerViewModel?   AdvMenuOptionButtonContainerViewModel   { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public bool                                     IsTapped                                { get; set; }

        public static AdvScreenPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdvScreenPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IAdvScreenView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IAdvScreenView.FromPointer); // 0x10 View                        ( ModelClassType IAdvScreenView IAdvScreenView IAdvScreenView Pointer )
            value.ViewModel                                 = GetObject<AdvScreenViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.AdvScreenViewModel.FromPointer); // 0x18 ViewModel                   ( ModelClassType AdvScreenViewModel AdvScreenViewModel AdvScreenViewModel Pointer )
            value.AdvMenuPresenter                          = GetObject<AdvMenuPresenter>(new IntPtr(p + 0x020), ReversePrism.DataModels.AdvMenuPresenter.FromPointer); // 0x20 AdvMenuPresenter            ( ModelClassType AdvMenuPresenter AdvMenuPresenter AdvMenuPresenter Pointer )
            value.AdvMenuOptionButtonContainerViewModel     = GetObject<AdvMenuOptionButtonContainerViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.AdvMenuOptionButtonContainerViewModel.FromPointer); // 0x28 AdvMenuOptionButtonContainerViewModel ( ModelClassType AdvMenuOptionButtonContainerViewModel AdvMenuOptionButtonContainerViewModel AdvMenuOptionButtonContainerViewModel Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x030), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x30 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x38 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.IsTapped                                  = GetBool(new IntPtr(p + 0x040)); // 0x40 IsTapped                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
