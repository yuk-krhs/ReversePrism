using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 isLimitedSale                            ReactiveProperty`1<bool> IL2CPP_TYPE_GENERICINST
    // 018 limitedText                              ReactiveProperty`1<string> IL2CPP_TYPE_GENERICINST
    // 020 Status                                   000186764540 ModelClassType IEventIconStatus IEventIconStatus IEventIconStatus Pointer
    // 028 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 030 onChangeViewModel                        Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 038 onChangeLimitedSaleState                 Subject`1<bool> IL2CPP_TYPE_GENERICINST
    public partial class LimitedSaleViewModel
    {
        public IEventIconStatus?                        Status                                  { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static LimitedSaleViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LimitedSaleViewModel();

            value.Status                                    = GetObject<IEventIconStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IEventIconStatus.FromPointer); // 027005B3ECF8 0x20 Status                      ( 000186764540 ModelClassType IEventIconStatus IEventIconStatus IEventIconStatus Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 027005B3ED18 0x28 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
