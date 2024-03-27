using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 XmlFormatWriterMethod                    000186613630 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 068 XmlFormatContentWriterMethod             000186613630 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 070 XmlFormatReaderMethod                    000186613630 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    public partial class PrimitiveDataContractCriticalHelper
    {
        public MethodInfo?                              XmlFormatWriterMethod                   { get; set; }
        public MethodInfo?                              XmlFormatContentWriterMethod            { get; set; }
        public MethodInfo?                              XmlFormatReaderMethod                   { get; set; }

        public static PrimitiveDataContractCriticalHelper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrimitiveDataContractCriticalHelper();

            value.XmlFormatWriterMethod                     = GetObject<MethodInfo>(new IntPtr(p + 0x060), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D4FB28 0x60 XmlFormatWriterMethod       ( 000186613630 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.XmlFormatContentWriterMethod              = GetObject<MethodInfo>(new IntPtr(p + 0x068), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D4FB48 0x68 XmlFormatContentWriterMethod ( 000186613630 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.XmlFormatReaderMethod                     = GetObject<MethodInfo>(new IntPtr(p + 0x070), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D4FB68 0x70 XmlFormatReaderMethod       ( 000186613630 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )

            return value;
        }
    }
}
