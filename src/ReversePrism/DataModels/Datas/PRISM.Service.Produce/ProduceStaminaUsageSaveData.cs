using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsAlwaysMax                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 014 UsageValue                               0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ProduceStaminaUsageSaveData
    {
        public bool                                     IsAlwaysMax                             { get; set; }
        public int                                      UsageValue                              { get; set; }

        public static ProduceStaminaUsageSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceStaminaUsageSaveData();

            value.IsAlwaysMax                               = GetBool(new IntPtr(p + 0x010)); // 027003A6E7D8 0x10 IsAlwaysMax                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UsageValue                                = GetInt32(new IntPtr(p + 0x014)); // 027003A6E7F8 0x14 UsageValue                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
