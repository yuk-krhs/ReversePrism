using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Values                                   00018664F1C0 ModelClassType StandardValuesCollection StandardValuesCollection StandardValuesCollection Pointer
    // 000 DefaultInvariantCultureString            string IL2CPP_TYPE_STRING
    public partial class CultureInfoConverter : DataModel
    {
        public StandardValuesCollection?                Values                                  { get; set; }

        public static CultureInfoConverter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CultureInfoConverter() { Pointer= p0 };

            value.Values                                    = GetObject<StandardValuesCollection>(new IntPtr(p + 0x010), ReversePrism.DataModels.StandardValuesCollection.FromPointer); // 024667B80548 0x10 Values                      ( 00018664F1C0 ModelClassType StandardValuesCollection StandardValuesCollection StandardValuesCollection Pointer )

            return value;
        }
    }
}
