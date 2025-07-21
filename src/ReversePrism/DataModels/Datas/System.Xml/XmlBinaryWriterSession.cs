using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 strings                                  PriorityDictionary`2<string, int> IL2CPP_TYPE_GENERICINST
    // 018 maps                                     PriorityDictionary`2<IXmlDictionary, IntArray> IL2CPP_TYPE_GENERICINST
    // 020 NextKey                                  ModelPrimitiveType int int int Int32
    public partial class XmlBinaryWriterSession : DataModel
    {
        public int                                      NextKey                                 { get; set; }

        public static XmlBinaryWriterSession? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlBinaryWriterSession() { Pointer= p0 };

            value.NextKey                                   = GetInt32(new IntPtr(p + 0x020)); // 0x20 NextKey                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
