using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Primary                                  000186749070 ModelClassType ICustomTypeDescriptor ICustomTypeDescriptor ICustomTypeDescriptor Pointer
    // 018 Secondary                                000186749070 ModelClassType ICustomTypeDescriptor ICustomTypeDescriptor ICustomTypeDescriptor Pointer
    public partial class MergedTypeDescriptor : DataModel
    {
        public ICustomTypeDescriptor?                   Primary                                 { get; set; }
        public ICustomTypeDescriptor?                   Secondary                               { get; set; }

        public static MergedTypeDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MergedTypeDescriptor() { Pointer= p0 };

            value.Primary                                   = GetObject<ICustomTypeDescriptor>(new IntPtr(p + 0x010), ReversePrism.DataModels.ICustomTypeDescriptor.FromPointer); // 024667BA48B8 0x10 Primary                     ( 000186749070 ModelClassType ICustomTypeDescriptor ICustomTypeDescriptor ICustomTypeDescriptor Pointer )
            value.Secondary                                 = GetObject<ICustomTypeDescriptor>(new IntPtr(p + 0x018), ReversePrism.DataModels.ICustomTypeDescriptor.FromPointer); // 024667BA48D8 0x18 Secondary                   ( 000186749070 ModelClassType ICustomTypeDescriptor ICustomTypeDescriptor ICustomTypeDescriptor Pointer )

            return value;
        }
    }
}
