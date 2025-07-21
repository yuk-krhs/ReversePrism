using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Result                                   ModelClassType Stream Stream Stream Pointer
    public partial class OpenReadCompletedEventArgs : DataModel
    {
        public Stream?                                  Result                                  { get; set; }

        public static OpenReadCompletedEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OpenReadCompletedEventArgs() { Pointer= p0 };

            value.Result                                    = GetObject<Stream>(new IntPtr(p + 0x028), ReversePrism.DataModels.Stream.FromPointer); // 0x28 Result                      ( ModelClassType Stream Stream Stream Pointer )

            return value;
        }
    }
}
