using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IProduceSubSeasonSelectView IProduceSubSeasonSelectView IProduceSubSeasonSelectView Pointer
    // 018 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class ProduceSubSeasonSelectPresenter : DataModel
    {
        public IProduceSubSeasonSelectView?             View                                    { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static ProduceSubSeasonSelectPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceSubSeasonSelectPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IProduceSubSeasonSelectView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceSubSeasonSelectView.FromPointer); // 0x10 View                        ( ModelClassType IProduceSubSeasonSelectView IProduceSubSeasonSelectView IProduceSubSeasonSelectView Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x18 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
