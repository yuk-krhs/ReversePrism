using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Helper                                   000186731460 ModelClassType XmlDataContractCriticalHelper XmlDataContractCriticalHelper XmlDataContractCriticalHelper Pointer
    public partial class XmlDataContract : DataModel
    {
        public XmlDataContractCriticalHelper?           Helper                                  { get; set; }

        public static XmlDataContract? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlDataContract() { Pointer= p0 };

            value.Helper                                    = GetObject<XmlDataContractCriticalHelper>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlDataContractCriticalHelper.FromPointer); // 0245A4CC3698 0x28 Helper                      ( 000186731460 ModelClassType XmlDataContractCriticalHelper XmlDataContractCriticalHelper XmlDataContractCriticalHelper Pointer )

            return value;
        }
    }
}
