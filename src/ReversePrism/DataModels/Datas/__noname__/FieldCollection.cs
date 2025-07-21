using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MessageDescriptor                        ModelClassType MessageDescriptor MessageDescriptor MessageDescriptor Pointer
    public partial class FieldCollection : DataModel
    {
        public MessageDescriptor?                       MessageDescriptor                       { get; set; }

        public static FieldCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FieldCollection() { Pointer= p0 };

            value.MessageDescriptor                         = GetObject<MessageDescriptor>(new IntPtr(p + 0x010), ReversePrism.DataModels.MessageDescriptor.FromPointer); // 0x10 MessageDescriptor           ( ModelClassType MessageDescriptor MessageDescriptor MessageDescriptor Pointer )

            return value;
        }
    }
}
