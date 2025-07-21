using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 RewindValue                              float IL2CPP_TYPE_R4
    // 000 FastforwardValue                         float IL2CPP_TYPE_R4
    // 010 Argument                                 ModelClassType OurstreamLiveViewingArgument OurstreamLiveViewingArgument OurstreamLiveViewingArgument Pointer
    // 018 View                                     ModelClassType IOurStreamLiveViewingView IOurStreamLiveViewingView IOurStreamLiveViewingView Pointer
    // 020 Disposable                               ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 028 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 IsShowErrorPopup                         ModelPrimitiveType bool bool bool Bool
    // 038 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class OurStreamLiveViewingPresenter : DataModel
    {
        public OurstreamLiveViewingArgument?            Argument                                { get; set; }
        public IOurStreamLiveViewingView?               View                                    { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public bool                                     IsShowErrorPopup                        { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static OurStreamLiveViewingPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamLiveViewingPresenter() { Pointer= p0 };

            value.Argument                                  = GetObject<OurstreamLiveViewingArgument>(new IntPtr(p + 0x010), ReversePrism.DataModels.OurstreamLiveViewingArgument.FromPointer); // 0x10 Argument                    ( ModelClassType OurstreamLiveViewingArgument OurstreamLiveViewingArgument OurstreamLiveViewingArgument Pointer )
            value.View                                      = GetObject<IOurStreamLiveViewingView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IOurStreamLiveViewingView.FromPointer); // 0x18 View                        ( ModelClassType IOurStreamLiveViewingView IOurStreamLiveViewingView IOurStreamLiveViewingView Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x20 Disposable                  ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x28 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.IsShowErrorPopup                          = GetBool(new IntPtr(p + 0x030)); // 0x30 IsShowErrorPopup            ( ModelPrimitiveType bool bool bool Bool )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x038), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x38 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
