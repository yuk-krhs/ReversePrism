using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Contract                                 0001865919D0 ModelClassType XmlDataContract XmlDataContract XmlDataContract Pointer
    public partial class XmlDataContractInterpreter : DataModel
    {
        public XmlDataContract?                         Contract                                { get; set; }

        public static XmlDataContractInterpreter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlDataContractInterpreter() { Pointer= p0 };

            value.Contract                                  = GetObject<XmlDataContract>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlDataContract.FromPointer); // 024667E29D00 0x10 Contract                    ( 0001865919D0 ModelClassType XmlDataContract XmlDataContract XmlDataContract Pointer )

            return value;
        }
    }
}
