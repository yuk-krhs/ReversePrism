using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 WindId                                   ModelPrimitiveType int int int Int32
    // 014 Time                                     ModelPrimitiveType float float float Single
    // 018 Main                                     ModelPrimitiveType float float float Single
    // 01C Direction                                ModelEnumType float3 float3 float3 Int32
    public partial class TeamWindInfo : DataModel
    {
        public int                                      WindId                                  { get; set; }
        public float                                    Time                                    { get; set; }
        public float                                    Main                                    { get; set; }
        public float3                                   Direction                               { get; set; }

        public static TeamWindInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TeamWindInfo() { Pointer= p0 };

            value.WindId                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 WindId                      ( ModelPrimitiveType int int int Int32 )
            value.Time                                      = GetSingle(new IntPtr(p + 0x014)); // 0x14 Time                        ( ModelPrimitiveType float float float Single )
            value.Main                                      = GetSingle(new IntPtr(p + 0x018)); // 0x18 Main                        ( ModelPrimitiveType float float float Single )
            value.Direction                                 = (float3)GetInt32(new IntPtr(p + 0x01C)); // 0x1C Direction                   ( ModelEnumType float3 float3 float3 Int32 )

            return value;
        }
    }
}
