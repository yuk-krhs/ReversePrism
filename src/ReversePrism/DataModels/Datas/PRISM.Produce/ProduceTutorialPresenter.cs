using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Model                                    00018658F660 ModelClassType ProduceTutorialModel ProduceTutorialModel ProduceTutorialModel Pointer
    // 018 View                                     000186597140 ModelClassType ProduceTutorialView ProduceTutorialView ProduceTutorialView Pointer
    // 020 Disposables                              0001865F3410 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
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

            value.Model                                     = GetObject<ProduceTutorialModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProduceTutorialModel.FromPointer); // 024665DC17B0 0x10 Model                       ( 00018658F660 ModelClassType ProduceTutorialModel ProduceTutorialModel ProduceTutorialModel Pointer )
            value.View                                      = GetObject<ProduceTutorialView>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceTutorialView.FromPointer); // 024665DC17D0 0x18 View                        ( 000186597140 ModelClassType ProduceTutorialView ProduceTutorialView ProduceTutorialView Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 024665DC17F0 0x20 Disposables                 ( 0001865F3410 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
