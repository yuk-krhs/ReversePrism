using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     0001865F4970 ModelClassType IProduceSubSeasonSelectView IProduceSubSeasonSelectView IProduceSubSeasonSelectView Pointer
    // 018 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class ProduceSubSeasonSelectPresenter
    {
        public IProduceSubSeasonSelectView?             View                                    { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static ProduceSubSeasonSelectPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceSubSeasonSelectPresenter();

            value.View                                      = GetObject<IProduceSubSeasonSelectView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceSubSeasonSelectView.FromPointer); // 0270D683EC40 0x10 View                        ( 0001865F4970 ModelClassType IProduceSubSeasonSelectView IProduceSubSeasonSelectView IProduceSubSeasonSelectView Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D683EC60 0x18 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
