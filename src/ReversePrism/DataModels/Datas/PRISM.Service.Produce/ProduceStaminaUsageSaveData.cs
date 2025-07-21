using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsAlwaysMax                              ModelPrimitiveType bool bool bool Bool
    // 014 UsageValue                               ModelPrimitiveType int int int Int32
    public partial class ProduceStaminaUsageSaveData : DataModel
    {
        public bool                                     IsAlwaysMax                             { get; set; }
        public int                                      UsageValue                              { get; set; }

        public static ProduceStaminaUsageSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceStaminaUsageSaveData() { Pointer= p0 };

            value.IsAlwaysMax                               = GetBool(new IntPtr(p + 0x010)); // 0x10 IsAlwaysMax                 ( ModelPrimitiveType bool bool bool Bool )
            value.UsageValue                                = GetInt32(new IntPtr(p + 0x014)); // 0x14 UsageValue                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
