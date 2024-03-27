using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MessageDescriptor                        000186606DB0 ModelClassType MessageDescriptor MessageDescriptor MessageDescriptor Pointer
    public partial class FieldCollection
    {
        public MessageDescriptor?                       MessageDescriptor                       { get; set; }

        public static FieldCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FieldCollection();

            value.MessageDescriptor                         = GetObject<MessageDescriptor>(new IntPtr(p + 0x010), ReversePrism.DataModels.MessageDescriptor.FromPointer); // 0270D0CF4A58 0x10 MessageDescriptor           ( 000186606DB0 ModelClassType MessageDescriptor MessageDescriptor MessageDescriptor Pointer )

            return value;
        }
    }
}
