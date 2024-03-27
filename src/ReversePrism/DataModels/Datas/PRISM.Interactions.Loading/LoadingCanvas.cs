using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Canvas                                   00018653FDA0 ModelClassType Canvas Canvas Canvas Pointer
    // 028 LoadingView                              0001865A0650 ModelClassType LoadingView LoadingView LoadingView Pointer
    // 030 ConnectingView                           000186603050 ModelClassType ConnectingView ConnectingView ConnectingView Pointer
    public partial class LoadingCanvas
    {
        public Canvas?                                  Canvas                                  { get; set; }
        public LoadingView?                             LoadingView                             { get; set; }
        public ConnectingView?                          ConnectingView                          { get; set; }

        public static LoadingCanvas? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoadingCanvas();

            value.Canvas                                    = GetObject<Canvas>(new IntPtr(p + 0x020), ReversePrism.DataModels.Canvas.FromPointer); // 027001E9DBF8 0x20 Canvas                      ( 00018653FDA0 ModelClassType Canvas Canvas Canvas Pointer )
            value.LoadingView                               = GetObject<LoadingView>(new IntPtr(p + 0x028), ReversePrism.DataModels.LoadingView.FromPointer); // 027001E9DC18 0x28 LoadingView                 ( 0001865A0650 ModelClassType LoadingView LoadingView LoadingView Pointer )
            value.ConnectingView                            = GetObject<ConnectingView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ConnectingView.FromPointer); // 027001E9DC38 0x30 ConnectingView              ( 000186603050 ModelClassType ConnectingView ConnectingView ConnectingView Pointer )

            return value;
        }
    }
}
