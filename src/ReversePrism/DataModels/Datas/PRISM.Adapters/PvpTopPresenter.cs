using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     00018660AB30 ModelClassType IPvpTopView IPvpTopView IPvpTopView Pointer
    // 018 Model                                    0001865F4690 ModelClassType PvpTopModel PvpTopModel PvpTopModel Pointer
    // 020 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 028 Cts                                      0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 EventId                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class PvpTopPresenter
    {
        public IPvpTopView?                             View                                    { get; set; }
        public PvpTopModel?                             Model                                   { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public int                                      EventId                                 { get; set; }

        public static PvpTopPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpTopPresenter();

            value.View                                      = GetObject<IPvpTopView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IPvpTopView.FromPointer); // 0270D6619630 0x10 View                        ( 00018660AB30 ModelClassType IPvpTopView IPvpTopView IPvpTopView Pointer )
            value.Model                                     = GetObject<PvpTopModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.PvpTopModel.FromPointer); // 0270D6619650 0x18 Model                       ( 0001865F4690 ModelClassType PvpTopModel PvpTopModel PvpTopModel Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D6619670 0x20 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D6619690 0x28 Cts                         ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.EventId                                   = GetInt32(new IntPtr(p + 0x030)); // 0270D66196B0 0x30 EventId                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
