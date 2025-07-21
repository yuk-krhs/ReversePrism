using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Flag_Valid                               int IL2CPP_TYPE_I4
    // 000 Flag_Enable                              int IL2CPP_TYPE_I4
    // 000 Flag_Reset                               int IL2CPP_TYPE_I4
    // 000 Flag_TimeReset                           int IL2CPP_TYPE_I4
    // 000 Flag_Suspend                             int IL2CPP_TYPE_I4
    // 000 Flag_Running                             int IL2CPP_TYPE_I4
    // 000 Flag_Synchronization                     int IL2CPP_TYPE_I4
    // 000 Flag_StepRunning                         int IL2CPP_TYPE_I4
    // 000 Flag_Exit                                int IL2CPP_TYPE_I4
    // 000 Flag_KeepTeleport                        int IL2CPP_TYPE_I4
    // 000 Flag_InertiaShift                        int IL2CPP_TYPE_I4
    // 000 Flag_CullingInvisible                    int IL2CPP_TYPE_I4
    // 000 Flag_CullingKeep                         int IL2CPP_TYPE_I4
    // 000 Flag_Spring                              int IL2CPP_TYPE_I4
    // 000 Flag_SkipWriting                         int IL2CPP_TYPE_I4
    // 000 Flag_Anchor                              int IL2CPP_TYPE_I4
    // 000 Flag_AnchorReset                         int IL2CPP_TYPE_I4
    // 000 Flag_Self_PointPrimitive                 int IL2CPP_TYPE_I4
    // 000 Flag_Self_EdgePrimitive                  int IL2CPP_TYPE_I4
    // 000 Flag_Self_TrianglePrimitive              int IL2CPP_TYPE_I4
    // 000 Flag_Self_EdgeEdge                       int IL2CPP_TYPE_I4
    // 000 Flag_Sync_EdgeEdge                       int IL2CPP_TYPE_I4
    // 000 Flag_PSync_EdgeEdge                      int IL2CPP_TYPE_I4
    // 000 Flag_Self_PointTriangle                  int IL2CPP_TYPE_I4
    // 000 Flag_Sync_PointTriangle                  int IL2CPP_TYPE_I4
    // 000 Flag_PSync_PointTriangle                 int IL2CPP_TYPE_I4
    // 000 Flag_Self_TrianglePoint                  int IL2CPP_TYPE_I4
    // 000 Flag_Sync_TrianglePoint                  int IL2CPP_TYPE_I4
    // 000 Flag_PSync_TrianglePoint                 int IL2CPP_TYPE_I4
    // 000 Flag_Self_EdgeTriangleIntersect          int IL2CPP_TYPE_I4
    // 000 Flag_Sync_EdgeTriangleIntersect          int IL2CPP_TYPE_I4
    // 000 Flag_PSync_EdgeTriangleIntersect         int IL2CPP_TYPE_I4
    // 000 Flag_Self_TriangleEdgeIntersect          int IL2CPP_TYPE_I4
    // 000 Flag_Sync_TriangleEdgeIntersect          int IL2CPP_TYPE_I4
    // 000 Flag_PSync_TriangleEdgeIntersect         int IL2CPP_TYPE_I4
    // 010 teamDataArray                            ExNativeArray`1<TeamData> IL2CPP_TYPE_GENERICINST
    // 018 teamWindArray                            ExNativeArray`1<TeamWindData> IL2CPP_TYPE_GENERICINST
    // 020 mappingDataArray                         ExNativeArray`1<MappingData> IL2CPP_TYPE_GENERICINST
    // 028 teamMappingIndexArray                    ExNativeArray`1<FixedList64Bytes`1<short>> IL2CPP_TYPE_GENERICINST
    // 030 maxUpdateCount                           NativeReference`1<int> IL2CPP_TYPE_GENERICINST
    // 040 parameterArray                           ExNativeArray`1<ClothParameters> IL2CPP_TYPE_GENERICINST
    // 048 centerDataArray                          ExNativeArray`1<CenterData> IL2CPP_TYPE_GENERICINST
    // 050 enableTeamSet                            HashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 058 clothProcessDict                         Dictionary`2<int, ClothProcess> IL2CPP_TYPE_GENERICINST
    // 060 IsValid                                  ModelPrimitiveType bool bool bool Bool
    // 064 EdgeColliderCollisionCount               ModelPrimitiveType int int int Int32
    // 000 teamUpdateCullingProfiler                ProfilerMarker IL2CPP_TYPE_VALUETYPE
    // 068 WorkPostProcessList                      ModelClassListType List`1<ClothProcess> List`1<ClothProcess> List<ClothProcess> Pointer
    // 070 monitoringProcessSet                     HashSet`1<ClothProcess> IL2CPP_TYPE_GENERICINST
    // 078 DisposeProcessList                       ModelClassListType List`1<ClothProcess> List`1<ClothProcess> List<ClothProcess> Pointer
    public partial class TeamManager : DataModel
    {
        public bool                                     IsValid                                 { get; set; }
        public int                                      EdgeColliderCollisionCount              { get; set; }
        public List<ClothProcess>?                      WorkPostProcessList                     { get; set; }
        public List<ClothProcess>?                      DisposeProcessList                      { get; set; }

        public static TeamManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TeamManager() { Pointer= p0 };

            value.IsValid                                   = GetBool(new IntPtr(p + 0x060)); // 0x60 IsValid                     ( ModelPrimitiveType bool bool bool Bool )
            value.EdgeColliderCollisionCount                = GetInt32(new IntPtr(p + 0x064)); // 0x64 EdgeColliderCollisionCount  ( ModelPrimitiveType int int int Int32 )
            value.WorkPostProcessList                       = GetObjectList<ClothProcess>(new IntPtr(p + 0x068), ReversePrism.DataModels.ClothProcess.FromPointer); // 0x68 WorkPostProcessList         ( ModelClassListType List`1<ClothProcess> List`1<ClothProcess> List<ClothProcess> Pointer )
            value.DisposeProcessList                        = GetObjectList<ClothProcess>(new IntPtr(p + 0x078), ReversePrism.DataModels.ClothProcess.FromPointer); // 0x78 DisposeProcessList          ( ModelClassListType List`1<ClothProcess> List`1<ClothProcess> List<ClothProcess> Pointer )

            return value;
        }
    }
}
