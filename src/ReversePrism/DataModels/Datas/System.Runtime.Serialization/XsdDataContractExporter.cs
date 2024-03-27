using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Options                                  000186528DF0 ModelClassType ExportOptions ExportOptions ExportOptions Pointer
    // 018 Schemas                                  0001865BEE30 ModelClassType XmlSchemaSet XmlSchemaSet XmlSchemaSet Pointer
    // 020 DataContractSet                          000186679430 ModelClassType DataContractSet DataContractSet DataContractSet Pointer
    public partial class XsdDataContractExporter
    {
        public ExportOptions?                           Options                                 { get; set; }
        public XmlSchemaSet?                            Schemas                                 { get; set; }
        public DataContractSet?                         DataContractSet                         { get; set; }

        public static XsdDataContractExporter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XsdDataContractExporter();

            value.Options                                   = GetObject<ExportOptions>(new IntPtr(p + 0x010), ReversePrism.DataModels.ExportOptions.FromPointer); // 0270D7CB6E50 0x10 Options                     ( 000186528DF0 ModelClassType ExportOptions ExportOptions ExportOptions Pointer )
            value.Schemas                                   = GetObject<XmlSchemaSet>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlSchemaSet.FromPointer); // 0270D7CB6E70 0x18 Schemas                     ( 0001865BEE30 ModelClassType XmlSchemaSet XmlSchemaSet XmlSchemaSet Pointer )
            value.DataContractSet                           = GetObject<DataContractSet>(new IntPtr(p + 0x020), ReversePrism.DataModels.DataContractSet.FromPointer); // 0270D7CB6E90 0x20 DataContractSet             ( 000186679430 ModelClassType DataContractSet DataContractSet DataContractSet Pointer )

            return value;
        }
    }
}
