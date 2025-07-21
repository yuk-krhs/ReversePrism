using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Model                                    ModelClassType ProduceTutorialModel ProduceTutorialModel ProduceTutorialModel Pointer
    // 018 View                                     ModelClassType ProduceTutorialView ProduceTutorialView ProduceTutorialView Pointer
    // 020 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 028 onDestroyView                            Action`1<ProduceTutorialView> IL2CPP_TYPE_GENERICINST
    public partial class ProduceTutorialPresenter : DataModel
    {
        public ProduceTutorialModel?                    Model                                   { get; set; }
        public ProduceTutorialView?                     View                                    { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static ProduceTutorialPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceTutorialPresenter() { Pointer= p0 };

            value.Model                                     = GetObject<ProduceTutorialModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProduceTutorialModel.FromPointer); // 0x10 Model                       ( ModelClassType ProduceTutorialModel ProduceTutorialModel ProduceTutorialModel Pointer )
            value.View                                      = GetObject<ProduceTutorialView>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceTutorialView.FromPointer); // 0x18 View                        ( ModelClassType ProduceTutorialView ProduceTutorialView ProduceTutorialView Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x20 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
