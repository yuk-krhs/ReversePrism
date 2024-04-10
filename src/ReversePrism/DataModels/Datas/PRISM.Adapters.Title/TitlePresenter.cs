using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     000186674F30 ModelClassType ITitleView ITitleView ITitleView Pointer
    // 018 ViewModel                                00018667CCC0 ModelClassType TitleViewModel TitleViewModel TitleViewModel Pointer
    // 020 CancellationTokenSource                  0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 028 Sequences                                000185B89F80 ModelClassListType ITitleSequence[] ITitleSequence[] List<ITitleSequence> Pointer
    // 030 ShowTitleImage                           000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class TitlePresenter : DataModel
    {
        public ITitleView?                              View                                    { get; set; }
        public TitleViewModel?                          ViewModel                               { get; set; }
        public CancellationTokenSource?                 CancellationTokenSource                 { get; set; }
        public List<ITitleSequence>?                    Sequences                               { get; set; }
        public bool                                     ShowTitleImage                          { get; set; }

        public static TitlePresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TitlePresenter() { Pointer= p0 };

            value.View                                      = GetObject<ITitleView>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITitleView.FromPointer); // 0245A44A1720 0x10 View                        ( 000186674F30 ModelClassType ITitleView ITitleView ITitleView Pointer )
            value.ViewModel                                 = GetObject<TitleViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.TitleViewModel.FromPointer); // 0245A44A1740 0x18 ViewModel                   ( 00018667CCC0 ModelClassType TitleViewModel TitleViewModel TitleViewModel Pointer )
            value.CancellationTokenSource                   = GetObject<CancellationTokenSource>(new IntPtr(p + 0x020), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0245A44A1760 0x20 CancellationTokenSource     ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Sequences                                 = GetObjectList<ITitleSequence>(new IntPtr(p + 0x028), ReversePrism.DataModels.ITitleSequence.FromPointer); // 0245A44A1780 0x28 Sequences                   ( 000185B89F80 ModelClassListType ITitleSequence[] ITitleSequence[] List<ITitleSequence> Pointer )
            value.ShowTitleImage                            = GetBool(new IntPtr(p + 0x030)); // 0245A44A17A0 0x30 ShowTitleImage              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
