using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Result                                   000186670BE0 ModelClassType Stream Stream Stream Pointer
    public partial class OpenReadCompletedEventArgs
    {
        public Stream?                                  Result                                  { get; set; }

        public static OpenReadCompletedEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OpenReadCompletedEventArgs();

            value.Result                                    = GetObject<Stream>(new IntPtr(p + 0x028), ReversePrism.DataModels.Stream.FromPointer); // 0270D7A17790 0x28 Result                      ( 000186670BE0 ModelClassType Stream Stream Stream Pointer )

            return value;
        }
    }
}
