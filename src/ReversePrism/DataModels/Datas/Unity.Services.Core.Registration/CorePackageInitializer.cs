using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ActionScheduler                          00018667B630 ModelClassType ActionScheduler ActionScheduler ActionScheduler Pointer
    // 018 InstallationId                           00018670C490 ModelClassType InstallationId InstallationId InstallationId Pointer
    // 020 ProjectConfig                            0001865CE8E0 ModelClassType ProjectConfiguration ProjectConfiguration ProjectConfiguration Pointer
    // 028 Environments                             0001867404A0 ModelClassType Environments Environments Environments Pointer
    // 030 ExternalUserId                           000186537520 ModelClassType ExternalUserId ExternalUserId ExternalUserId Pointer
    // 038 CloudProjectId                           000186730F60 ModelClassType ICloudProjectId ICloudProjectId ICloudProjectId Pointer
    // 040 DiagnosticsFactory                       00018674FD30 ModelClassType IDiagnosticsFactory IDiagnosticsFactory IDiagnosticsFactory Pointer
    // 048 MetricsFactory                           0001865B3470 ModelClassType IMetricsFactory IMetricsFactory IMetricsFactory Pointer
    // 050 UnityThreadUtils                         00018672C6F0 ModelClassType UnityThreadUtilsInternal UnityThreadUtilsInternal UnityThreadUtilsInternal Pointer
    // 058 M_Serializer                             00018658BD20 ModelClassType IJsonSerializer IJsonSerializer IJsonSerializer Pointer
    // 060 M_CurrentInitializationOptions           0001866F2260 ModelClassType InitializationOptions InitializationOptions InitializationOptions Pointer
    public partial class CorePackageInitializer : DataModel
    {
        public ActionScheduler?                         ActionScheduler                         { get; set; }
        public InstallationId?                          InstallationId                          { get; set; }
        public ProjectConfiguration?                    ProjectConfig                           { get; set; }
        public Environments?                            Environments                            { get; set; }
        public ExternalUserId?                          ExternalUserId                          { get; set; }
        public ICloudProjectId?                         CloudProjectId                          { get; set; }
        public IDiagnosticsFactory?                     DiagnosticsFactory                      { get; set; }
        public IMetricsFactory?                         MetricsFactory                          { get; set; }
        public UnityThreadUtilsInternal?                UnityThreadUtils                        { get; set; }
        public IJsonSerializer?                         M_Serializer                            { get; set; }
        public InitializationOptions?                   M_CurrentInitializationOptions          { get; set; }

        public static CorePackageInitializer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CorePackageInitializer() { Pointer= p0 };

            value.ActionScheduler                           = GetObject<ActionScheduler>(new IntPtr(p + 0x010), ReversePrism.DataModels.ActionScheduler.FromPointer); // 0245A3B64DD0 0x10 ActionScheduler             ( 00018667B630 ModelClassType ActionScheduler ActionScheduler ActionScheduler Pointer )
            value.InstallationId                            = GetObject<InstallationId>(new IntPtr(p + 0x018), ReversePrism.DataModels.InstallationId.FromPointer); // 0245A3B64DF0 0x18 InstallationId              ( 00018670C490 ModelClassType InstallationId InstallationId InstallationId Pointer )
            value.ProjectConfig                             = GetObject<ProjectConfiguration>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProjectConfiguration.FromPointer); // 0245A3B64E10 0x20 ProjectConfig               ( 0001865CE8E0 ModelClassType ProjectConfiguration ProjectConfiguration ProjectConfiguration Pointer )
            value.Environments                              = GetObject<Environments>(new IntPtr(p + 0x028), ReversePrism.DataModels.Environments.FromPointer); // 0245A3B64E30 0x28 Environments                ( 0001867404A0 ModelClassType Environments Environments Environments Pointer )
            value.ExternalUserId                            = GetObject<ExternalUserId>(new IntPtr(p + 0x030), ReversePrism.DataModels.ExternalUserId.FromPointer); // 0245A3B64E50 0x30 ExternalUserId              ( 000186537520 ModelClassType ExternalUserId ExternalUserId ExternalUserId Pointer )
            value.CloudProjectId                            = GetObject<ICloudProjectId>(new IntPtr(p + 0x038), ReversePrism.DataModels.ICloudProjectId.FromPointer); // 0245A3B64E70 0x38 CloudProjectId              ( 000186730F60 ModelClassType ICloudProjectId ICloudProjectId ICloudProjectId Pointer )
            value.DiagnosticsFactory                        = GetObject<IDiagnosticsFactory>(new IntPtr(p + 0x040), ReversePrism.DataModels.IDiagnosticsFactory.FromPointer); // 0245A3B64E90 0x40 DiagnosticsFactory          ( 00018674FD30 ModelClassType IDiagnosticsFactory IDiagnosticsFactory IDiagnosticsFactory Pointer )
            value.MetricsFactory                            = GetObject<IMetricsFactory>(new IntPtr(p + 0x048), ReversePrism.DataModels.IMetricsFactory.FromPointer); // 0245A3B64EB0 0x48 MetricsFactory              ( 0001865B3470 ModelClassType IMetricsFactory IMetricsFactory IMetricsFactory Pointer )
            value.UnityThreadUtils                          = GetObject<UnityThreadUtilsInternal>(new IntPtr(p + 0x050), ReversePrism.DataModels.UnityThreadUtilsInternal.FromPointer); // 0245A3B64ED0 0x50 UnityThreadUtils            ( 00018672C6F0 ModelClassType UnityThreadUtilsInternal UnityThreadUtilsInternal UnityThreadUtilsInternal Pointer )
            value.M_Serializer                              = GetObject<IJsonSerializer>(new IntPtr(p + 0x058), ReversePrism.DataModels.IJsonSerializer.FromPointer); // 0245A3B64EF0 0x58 M_Serializer                ( 00018658BD20 ModelClassType IJsonSerializer IJsonSerializer IJsonSerializer Pointer )
            value.M_CurrentInitializationOptions            = GetObject<InitializationOptions>(new IntPtr(p + 0x060), ReversePrism.DataModels.InitializationOptions.FromPointer); // 0245A3B64F10 0x60 M_CurrentInitializationOptions ( 0001866F2260 ModelClassType InitializationOptions InitializationOptions InitializationOptions Pointer )

            return value;
        }
    }
}
