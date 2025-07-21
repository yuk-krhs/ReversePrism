using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 initializationCount                      int IL2CPP_TYPE_I4
    // 008 effectInterfaceList                      List`1<<int>> IL2CPP_TYPE_GENERICINST
    // 010 IsConfigured                             ModelPrimitiveType bool bool bool Bool
    // 014 TimeSinceStartup                         ModelPrimitiveType float float float Single
    // 018 CpuUsage                                 ModelEnumType CpuUsage CpuUsage CpuUsage Int32
    // 024 CRIATOMUNITY_PARAMETER_ID_LOOP_COUNT     ModelPrimitiveType int int int Int32
    // 028 CRIATOMPARAMETER2_ID_INVALID             ModelPrimitiveType ushort ushort ushort UInt16
    // 030 TemporalStorage                          ModelPrimitiveType ulong ulong ulong UInt64
    public partial class CriAtomPlugin : DataModel
    {
        public bool                                     IsConfigured                            { get; set; }
        public float                                    TimeSinceStartup                        { get; set; }
        public CpuUsage                                 CpuUsage                                { get; set; }
        public int                                      CRIATOMUNITY_PARAMETER_ID_LOOP_COUNT    { get; set; }
        public ushort                                   CRIATOMPARAMETER2_ID_INVALID            { get; set; }
        public ulong                                    TemporalStorage                         { get; set; }

        public static CriAtomPlugin? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriAtomPlugin() { Pointer= p0 };

            value.IsConfigured                              = GetBool(new IntPtr(p + 0x010)); // 0x10 IsConfigured                ( ModelPrimitiveType bool bool bool Bool )
            value.TimeSinceStartup                          = GetSingle(new IntPtr(p + 0x014)); // 0x14 TimeSinceStartup            ( ModelPrimitiveType float float float Single )
            value.CpuUsage                                  = (CpuUsage)GetInt32(new IntPtr(p + 0x018)); // 0x18 CpuUsage                    ( ModelEnumType CpuUsage CpuUsage CpuUsage Int32 )
            value.CRIATOMUNITY_PARAMETER_ID_LOOP_COUNT      = GetInt32(new IntPtr(p + 0x024)); // 0x24 CRIATOMUNITY_PARAMETER_ID_LOOP_COUNT ( ModelPrimitiveType int int int Int32 )
            value.CRIATOMPARAMETER2_ID_INVALID              = GetUInt16(new IntPtr(p + 0x028)); // 0x28 CRIATOMPARAMETER2_ID_INVALID ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.TemporalStorage                           = GetUInt64(new IntPtr(p + 0x030)); // 0x30 TemporalStorage             ( ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
