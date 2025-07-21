using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 XmlFormatWriterMethod                    ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 068 XmlFormatContentWriterMethod             ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 070 XmlFormatReaderMethod                    ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    public partial class PrimitiveDataContractCriticalHelper : DataModel
    {
        public MethodInfo?                              XmlFormatWriterMethod                   { get; set; }
        public MethodInfo?                              XmlFormatContentWriterMethod            { get; set; }
        public MethodInfo?                              XmlFormatReaderMethod                   { get; set; }

        public static PrimitiveDataContractCriticalHelper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrimitiveDataContractCriticalHelper() { Pointer= p0 };

            value.XmlFormatWriterMethod                     = GetObject<MethodInfo>(new IntPtr(p + 0x060), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x60 XmlFormatWriterMethod       ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.XmlFormatContentWriterMethod              = GetObject<MethodInfo>(new IntPtr(p + 0x068), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x68 XmlFormatContentWriterMethod ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.XmlFormatReaderMethod                     = GetObject<MethodInfo>(new IntPtr(p + 0x070), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x70 XmlFormatReaderMethod       ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )

            return value;
        }
    }
}
