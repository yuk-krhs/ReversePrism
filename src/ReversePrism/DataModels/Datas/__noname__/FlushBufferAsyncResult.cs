using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 onComplete                               AsyncCompletion IL2CPP_TYPE_CLASS
    // 070 Writer                                   ModelClassType XmlStreamNodeWriter XmlStreamNodeWriter XmlStreamNodeWriter Pointer
    public partial class FlushBufferAsyncResult : DataModel
    {
        public XmlStreamNodeWriter?                     Writer                                  { get; set; }

        public static FlushBufferAsyncResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FlushBufferAsyncResult() { Pointer= p0 };

            value.Writer                                    = GetObject<XmlStreamNodeWriter>(new IntPtr(p + 0x070), ReversePrism.DataModels.XmlStreamNodeWriter.FromPointer); // 0x70 Writer                      ( ModelClassType XmlStreamNodeWriter XmlStreamNodeWriter XmlStreamNodeWriter Pointer )

            return value;
        }
    }
}
