using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ButtonParameters                         ModelClassListType IReadOnlyList`1<ButtonInfoParameter> IReadOnlyList`1<ButtonInfoParameter> List<ButtonInfoParameter> Pointer
    public partial class FooterInfoParameter : DataModel
    {
        public List<ButtonInfoParameter>?               ButtonParameters                        { get; set; }

        public static FooterInfoParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FooterInfoParameter() { Pointer= p0 };

            value.ButtonParameters                          = GetObjectList<ButtonInfoParameter>(new IntPtr(p + 0x010), ReversePrism.DataModels.ButtonInfoParameter.FromPointer); // 0x10 ButtonParameters            ( ModelClassListType IReadOnlyList`1<ButtonInfoParameter> IReadOnlyList`1<ButtonInfoParameter> List<ButtonInfoParameter> Pointer )

            return value;
        }
    }
}
