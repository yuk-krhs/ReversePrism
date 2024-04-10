using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Param                                    000185CB62F8 ModelClassListType BodyParameter[] BodyParameter[] List<BodyParameter> Pointer
    public partial class BodyParameters : DataModel
    {
        public List<BodyParameter>?                     Param                                   { get; set; }

        public static BodyParameters? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BodyParameters() { Pointer= p0 };

            value.Param                                     = GetObjectList<BodyParameter>(new IntPtr(p + 0x010), ReversePrism.DataModels.BodyParameter.FromPointer); // 0245A69A19C0 0x10 Param                       ( 000185CB62F8 ModelClassListType BodyParameter[] BodyParameter[] List<BodyParameter> Pointer )

            return value;
        }
    }
}
