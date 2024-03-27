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
    public partial class ScalerInfo
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
            var value   = new ScalerInfo();

            value.ScalerName                                = (<scalerName>e__FixedBuffer)GetInt32(new IntPtr(p + 0x010)); // 0270DB651B00 0x10 ScalerName                  ( 000186760250 ModelEnumType <scalerName>e__FixedBuffer <scalerName>e__FixedBuffer <scalerName>e__FixedBuffer Int32 )
            value.Enabled                                   = GetUInt32(new IntPtr(p + 0x150)); // 0270DB651B20 0x150 Enabled                     ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.OverrideLevel                             = GetInt32(new IntPtr(p + 0x154)); // 0270DB651B40 0x154 OverrideLevel               ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.CurrentLevel                              = GetInt32(new IntPtr(p + 0x158)); // 0270DB651B60 0x158 CurrentLevel                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MaxLevel                                  = GetInt32(new IntPtr(p + 0x15C)); // 0270DB651B80 0x15C MaxLevel                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Scale                                     = GetSingle(new IntPtr(p + 0x160)); // 0270DB651BA0 0x160 Scale                       ( 000186666050 ModelPrimitiveType float float float Single )
            value.Applied                                   = GetUInt32(new IntPtr(p + 0x164)); // 0270DB651BC0 0x164 Applied                     ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
