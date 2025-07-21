using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TeamCount                                ModelPrimitiveType int int int Int32
    // 014 UnityFrameDeltaTime                      ModelPrimitiveType float float float Single
    // 018 UnityFrameFixedDeltaTime                 ModelPrimitiveType float float float Single
    // 01C UnityFrameUnscaledDeltaTime              ModelPrimitiveType float float float Single
    // 020 GlobalTimeScale                          ModelPrimitiveType float float float Single
    // 024 SimulationDeltaTime                      ModelPrimitiveType float float float Single
    // 028 MaxSimmulationCountPerFrame              ModelPrimitiveType int int int Int32
    // 030 maxUpdateCount                           NativeReference`1<int> IL2CPP_TYPE_GENERICINST
    // 040 teamDataArray                            NativeArray`1<TeamData> IL2CPP_TYPE_GENERICINST
    // 050 parameterArray                           NativeArray`1<ClothParameters> IL2CPP_TYPE_GENERICINST
    public partial class AlwaysTeamUpdateJob : DataModel
    {
        public int                                      TeamCount                               { get; set; }
        public float                                    UnityFrameDeltaTime                     { get; set; }
        public float                                    UnityFrameFixedDeltaTime                { get; set; }
        public float                                    UnityFrameUnscaledDeltaTime             { get; set; }
        public float                                    GlobalTimeScale                         { get; set; }
        public float                                    SimulationDeltaTime                     { get; set; }
        public int                                      MaxSimmulationCountPerFrame             { get; set; }

        public static AlwaysTeamUpdateJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AlwaysTeamUpdateJob() { Pointer= p0 };

            value.TeamCount                                 = GetInt32(new IntPtr(p + 0x010)); // 0x10 TeamCount                   ( ModelPrimitiveType int int int Int32 )
            value.UnityFrameDeltaTime                       = GetSingle(new IntPtr(p + 0x014)); // 0x14 UnityFrameDeltaTime         ( ModelPrimitiveType float float float Single )
            value.UnityFrameFixedDeltaTime                  = GetSingle(new IntPtr(p + 0x018)); // 0x18 UnityFrameFixedDeltaTime    ( ModelPrimitiveType float float float Single )
            value.UnityFrameUnscaledDeltaTime               = GetSingle(new IntPtr(p + 0x01C)); // 0x1C UnityFrameUnscaledDeltaTime ( ModelPrimitiveType float float float Single )
            value.GlobalTimeScale                           = GetSingle(new IntPtr(p + 0x020)); // 0x20 GlobalTimeScale             ( ModelPrimitiveType float float float Single )
            value.SimulationDeltaTime                       = GetSingle(new IntPtr(p + 0x024)); // 0x24 SimulationDeltaTime         ( ModelPrimitiveType float float float Single )
            value.MaxSimmulationCountPerFrame               = GetInt32(new IntPtr(p + 0x028)); // 0x28 MaxSimmulationCountPerFrame ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
