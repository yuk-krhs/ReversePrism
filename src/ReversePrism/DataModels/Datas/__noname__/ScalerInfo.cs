using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScalerName                               000186760250 ModelEnumType <scalerName>e__FixedBuffer <scalerName>e__FixedBuffer <scalerName>e__FixedBuffer Int32
    // 150 Enabled                                  0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 154 OverrideLevel                            0001865F36C0 ModelPrimitiveType int int int Int32
    // 158 CurrentLevel                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 15C MaxLevel                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 160 Scale                                    000186666050 ModelPrimitiveType float float float Single
    // 164 Applied                                  0001866992B0 ModelPrimitiveType uint uint uint UInt32
    public partial class ScalerInfo : DataModel
    {
        public <scalerName>e__FixedBuffer               ScalerName                              { get; set; }
        public uint                                     Enabled                                 { get; set; }
        public int                                      OverrideLevel                           { get; set; }
        public int                                      CurrentLevel                            { get; set; }
        public int                                      MaxLevel                                { get; set; }
        public float                                    Scale                                   { get; set; }
        public uint                                     Applied                                 { get; set; }

        public static ScalerInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScalerInfo() { Pointer= p0 };

            value.ScalerName                                = (<scalerName>e__FixedBuffer)GetInt32(new IntPtr(p + 0x010)); // 02466B6D5B98 0x10 ScalerName                  ( 000186760250 ModelEnumType <scalerName>e__FixedBuffer <scalerName>e__FixedBuffer <scalerName>e__FixedBuffer Int32 )
            value.Enabled                                   = GetUInt32(new IntPtr(p + 0x150)); // 02466B6D5BB8 0x150 Enabled                     ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.OverrideLevel                             = GetInt32(new IntPtr(p + 0x154)); // 02466B6D5BD8 0x154 OverrideLevel               ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.CurrentLevel                              = GetInt32(new IntPtr(p + 0x158)); // 02466B6D5BF8 0x158 CurrentLevel                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MaxLevel                                  = GetInt32(new IntPtr(p + 0x15C)); // 02466B6D5C18 0x15C MaxLevel                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Scale                                     = GetSingle(new IntPtr(p + 0x160)); // 02466B6D5C38 0x160 Scale                       ( 000186666050 ModelPrimitiveType float float float Single )
            value.Applied                                   = GetUInt32(new IntPtr(p + 0x164)); // 02466B6D5C58 0x164 Applied                     ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
