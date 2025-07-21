using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScalerName                               ModelEnumType <scalerName>e__FixedBuffer <scalerName>e__FixedBuffer <scalerName>e__FixedBuffer Int32
    // 150 Enabled                                  ModelPrimitiveType uint uint uint UInt32
    // 154 OverrideLevel                            ModelPrimitiveType int int int Int32
    // 158 CurrentLevel                             ModelPrimitiveType int int int Int32
    // 15C MaxLevel                                 ModelPrimitiveType int int int Int32
    // 160 Scale                                    ModelPrimitiveType float float float Single
    // 164 Applied                                  ModelPrimitiveType uint uint uint UInt32
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

            value.ScalerName                                = (<scalerName>e__FixedBuffer)GetInt32(new IntPtr(p + 0x010)); // 0x10 ScalerName                  ( ModelEnumType <scalerName>e__FixedBuffer <scalerName>e__FixedBuffer <scalerName>e__FixedBuffer Int32 )
            value.Enabled                                   = GetUInt32(new IntPtr(p + 0x150)); // 0x150 Enabled                     ( ModelPrimitiveType uint uint uint UInt32 )
            value.OverrideLevel                             = GetInt32(new IntPtr(p + 0x154)); // 0x154 OverrideLevel               ( ModelPrimitiveType int int int Int32 )
            value.CurrentLevel                              = GetInt32(new IntPtr(p + 0x158)); // 0x158 CurrentLevel                ( ModelPrimitiveType int int int Int32 )
            value.MaxLevel                                  = GetInt32(new IntPtr(p + 0x15C)); // 0x15C MaxLevel                    ( ModelPrimitiveType int int int Int32 )
            value.Scale                                     = GetSingle(new IntPtr(p + 0x160)); // 0x160 Scale                       ( ModelPrimitiveType float float float Single )
            value.Applied                                   = GetUInt32(new IntPtr(p + 0x164)); // 0x164 Applied                     ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
