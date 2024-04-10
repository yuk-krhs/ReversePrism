using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Values                                   00018664F1C0 ModelClassType StandardValuesCollection StandardValuesCollection StandardValuesCollection Pointer
    // 018 Type                                     000186692850 ModelClassType Type Type Type Pointer
    public partial class EnumConverter : DataModel
    {
        public StandardValuesCollection?                Values                                  { get; set; }
        public Type?                                    Type                                    { get; set; }

        public static EnumConverter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnumConverter() { Pointer= p0 };

            value.Values                                    = GetObject<StandardValuesCollection>(new IntPtr(p + 0x010), ReversePrism.DataModels.StandardValuesCollection.FromPointer); // 024667BA3970 0x10 Values                      ( 00018664F1C0 ModelClassType StandardValuesCollection StandardValuesCollection StandardValuesCollection Pointer )
            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 024667BA3990 0x18 Type                        ( 000186692850 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
