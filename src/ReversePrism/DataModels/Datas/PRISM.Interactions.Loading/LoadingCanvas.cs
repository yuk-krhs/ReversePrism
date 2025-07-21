using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Canvas                                   ModelClassType Canvas Canvas Canvas Pointer
    // 028 LoadingView                              ModelClassType LoadingView LoadingView LoadingView Pointer
    // 030 ConnectingView                           ModelClassType ConnectingView ConnectingView ConnectingView Pointer
    public partial class LoadingCanvas : DataModel
    {
        public Canvas?                                  Canvas                                  { get; set; }
        public LoadingView?                             LoadingView                             { get; set; }
        public ConnectingView?                          ConnectingView                          { get; set; }

        public static LoadingCanvas? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoadingCanvas() { Pointer= p0 };

            value.Canvas                                    = GetObject<Canvas>(new IntPtr(p + 0x020), ReversePrism.DataModels.Canvas.FromPointer); // 0x20 Canvas                      ( ModelClassType Canvas Canvas Canvas Pointer )
            value.LoadingView                               = GetObject<LoadingView>(new IntPtr(p + 0x028), ReversePrism.DataModels.LoadingView.FromPointer); // 0x28 LoadingView                 ( ModelClassType LoadingView LoadingView LoadingView Pointer )
            value.ConnectingView                            = GetObject<ConnectingView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ConnectingView.FromPointer); // 0x30 ConnectingView              ( ModelClassType ConnectingView ConnectingView ConnectingView Pointer )

            return value;
        }
    }
}
