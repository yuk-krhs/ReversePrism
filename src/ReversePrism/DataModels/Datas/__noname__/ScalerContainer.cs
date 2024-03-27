using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     000186711AA0 ModelEnumType DynamicResScalePolicyType DynamicResScalePolicyType DynamicResScalePolicyType Int32
    // 018 Method                                   00018672FFC0 ModelClassType PerformDynamicRes PerformDynamicRes PerformDynamicRes Pointer
    public partial class ScalerContainer
    {
        public DynamicResScalePolicyType                Type                                    { get; set; }
        public PerformDynamicRes?                       Method                                  { get; set; }

        public static ScalerContainer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScalerContainer();

            value.Type                                      = (DynamicResScalePolicyType)GetInt32(new IntPtr(p + 0x010)); // 027003FBBEE0 0x10 Type                        ( 000186711AA0 ModelEnumType DynamicResScalePolicyType DynamicResScalePolicyType DynamicResScalePolicyType Int32 )
            value.Method                                    = GetObject<PerformDynamicRes>(new IntPtr(p + 0x018), ReversePrism.DataModels.PerformDynamicRes.FromPointer); // 027003FBBF00 0x18 Method                      ( 00018672FFC0 ModelClassType PerformDynamicRes PerformDynamicRes PerformDynamicRes Pointer )

            return value;
        }
    }
}
