using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Position                                 0001866ADBF0 ModelEnumType Vector3Int Vector3Int Vector3Int Int32
    // 01C Index                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 ProbeCount                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 MinSubdiv                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 MaxSubdiv                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 02C IndexChunkCount                          0001865F36C0 ModelPrimitiveType int int int Int32
    // 030 ShChunkCount                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 034 HasTwoScenarios                          000186595960 ModelPrimitiveType bool bool bool Bool
    // 038 ShBands                                  0001865220A0 ModelEnumType ProbeVolumeSHBands ProbeVolumeSHBands ProbeVolumeSHBands Int32
    // 040 <bricks>k__BackingField                  NativeArray`1<Brick> IL2CPP_TYPE_GENERICINST
    // 050 <validityNeighMaskData>k__BackingField   NativeArray`1<sbyte> IL2CPP_TYPE_GENERICINST
    // 060 <probePositions>k__BackingField          NativeArray`1<Vector3> IL2CPP_TYPE_GENERICINST
    // 070 <touchupVolumeInteraction>k__BackingField NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 080 <offsetVectors>k__BackingField           NativeArray`1<Vector3> IL2CPP_TYPE_GENERICINST
    // 090 <validity>k__BackingField                NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 0A0 Scenario0                                000186569BC0 ModelEnumType PerScenarioData PerScenarioData PerScenarioData Int32
    // 110 Scenario1                                000186569BC0 ModelEnumType PerScenarioData PerScenarioData PerScenarioData Int32
    public partial class Cell : DataModel
    {
        public Vector3Int                               Position                                { get; set; }
        public int                                      Index                                   { get; set; }
        public int                                      ProbeCount                              { get; set; }
        public int                                      MinSubdiv                               { get; set; }
        public int                                      MaxSubdiv                               { get; set; }
        public int                                      IndexChunkCount                         { get; set; }
        public int                                      ShChunkCount                            { get; set; }
        public bool                                     HasTwoScenarios                         { get; set; }
        public ProbeVolumeSHBands                       ShBands                                 { get; set; }
        public PerScenarioData                          Scenario0                               { get; set; }
        public PerScenarioData                          Scenario1                               { get; set; }

        public static Cell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Cell() { Pointer= p0 };

            value.Position                                  = (Vector3Int)GetInt32(new IntPtr(p + 0x010)); // 024669209DA8 0x10 Position                    ( 0001866ADBF0 ModelEnumType Vector3Int Vector3Int Vector3Int Int32 )
            value.Index                                     = GetInt32(new IntPtr(p + 0x01C)); // 024669209DC8 0x1C Index                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ProbeCount                                = GetInt32(new IntPtr(p + 0x020)); // 024669209DE8 0x20 ProbeCount                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MinSubdiv                                 = GetInt32(new IntPtr(p + 0x024)); // 024669209E08 0x24 MinSubdiv                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MaxSubdiv                                 = GetInt32(new IntPtr(p + 0x028)); // 024669209E28 0x28 MaxSubdiv                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.IndexChunkCount                           = GetInt32(new IntPtr(p + 0x02C)); // 024669209E48 0x2C IndexChunkCount             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ShChunkCount                              = GetInt32(new IntPtr(p + 0x030)); // 024669209E68 0x30 ShChunkCount                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.HasTwoScenarios                           = GetBool(new IntPtr(p + 0x034)); // 024669209E88 0x34 HasTwoScenarios             ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ShBands                                   = (ProbeVolumeSHBands)GetInt32(new IntPtr(p + 0x038)); // 024669209EA8 0x38 ShBands                     ( 0001865220A0 ModelEnumType ProbeVolumeSHBands ProbeVolumeSHBands ProbeVolumeSHBands Int32 )
            value.Scenario0                                 = (PerScenarioData)GetInt32(new IntPtr(p + 0x0A0)); // 024669209F88 0xA0 Scenario0                   ( 000186569BC0 ModelEnumType PerScenarioData PerScenarioData PerScenarioData Int32 )
            value.Scenario1                                 = (PerScenarioData)GetInt32(new IntPtr(p + 0x110)); // 024669209FA8 0x110 Scenario1                   ( 000186569BC0 ModelEnumType PerScenarioData PerScenarioData PerScenarioData Int32 )

            return value;
        }
    }
}
