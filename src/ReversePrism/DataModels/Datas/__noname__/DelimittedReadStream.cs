using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Reader                                   0001866BDB70 ModelClassType DelimittedStreamReader DelimittedStreamReader DelimittedStreamReader Pointer
    public partial class DelimittedReadStream
    {
        public DelimittedStreamReader?                  Reader                                  { get; set; }

        public static DelimittedReadStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DelimittedReadStream();

            value.Reader                                    = GetObject<DelimittedStreamReader>(new IntPtr(p + 0x028), ReversePrism.DataModels.DelimittedStreamReader.FromPointer); // 0270D7C91578 0x28 Reader                      ( 0001866BDB70 ModelClassType DelimittedStreamReader DelimittedStreamReader DelimittedStreamReader Pointer )

            return value;
        }
    }
}
