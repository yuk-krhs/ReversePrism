using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ActionScheduler                          ModelClassType ActionScheduler ActionScheduler ActionScheduler Pointer
    // 018 InstallationId                           ModelClassType InstallationId InstallationId InstallationId Pointer
    // 020 ProjectConfig                            ModelClassType ProjectConfiguration ProjectConfiguration ProjectConfiguration Pointer
    // 028 Environments                             ModelClassType Environments Environments Environments Pointer
    // 030 ExternalUserId                           ModelClassType ExternalUserId ExternalUserId ExternalUserId Pointer
    // 038 CloudProjectId                           ModelClassType ICloudProjectId ICloudProjectId ICloudProjectId Pointer
    // 040 DiagnosticsFactory                       ModelClassType IDiagnosticsFactory IDiagnosticsFactory IDiagnosticsFactory Pointer
    // 048 MetricsFactory                           ModelClassType IMetricsFactory IMetricsFactory IMetricsFactory Pointer
    // 050 UnityThreadUtils                         ModelClassType UnityThreadUtilsInternal UnityThreadUtilsInternal UnityThreadUtilsInternal Pointer
    // 058 M_Registry                               ModelClassType CoreRegistry CoreRegistry CoreRegistry Pointer
    // 060 M_Serializer                             ModelClassType IJsonSerializer IJsonSerializer IJsonSerializer Pointer
    // 068 M_CurrentInitializationOptions           ModelClassType InitializationOptions InitializationOptions InitializationOptions Pointer
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
        public CoreRegistry?                            M_Registry                              { get; set; }
        public IJsonSerializer?                         M_Serializer                            { get; set; }
        public InitializationOptions?                   M_CurrentInitializationOptions          { get; set; }

        public static CorePackageInitializer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CorePackageInitializer() { Pointer= p0 };

            value.ActionScheduler                           = GetObject<ActionScheduler>(new IntPtr(p + 0x010), ReversePrism.DataModels.ActionScheduler.FromPointer); // 0x10 ActionScheduler             ( ModelClassType ActionScheduler ActionScheduler ActionScheduler Pointer )
            value.InstallationId                            = GetObject<InstallationId>(new IntPtr(p + 0x018), ReversePrism.DataModels.InstallationId.FromPointer); // 0x18 InstallationId              ( ModelClassType InstallationId InstallationId InstallationId Pointer )
            value.ProjectConfig                             = GetObject<ProjectConfiguration>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProjectConfiguration.FromPointer); // 0x20 ProjectConfig               ( ModelClassType ProjectConfiguration ProjectConfiguration ProjectConfiguration Pointer )
            value.Environments                              = GetObject<Environments>(new IntPtr(p + 0x028), ReversePrism.DataModels.Environments.FromPointer); // 0x28 Environments                ( ModelClassType Environments Environments Environments Pointer )
            value.ExternalUserId                            = GetObject<ExternalUserId>(new IntPtr(p + 0x030), ReversePrism.DataModels.ExternalUserId.FromPointer); // 0x30 ExternalUserId              ( ModelClassType ExternalUserId ExternalUserId ExternalUserId Pointer )
            value.CloudProjectId                            = GetObject<ICloudProjectId>(new IntPtr(p + 0x038), ReversePrism.DataModels.ICloudProjectId.FromPointer); // 0x38 CloudProjectId              ( ModelClassType ICloudProjectId ICloudProjectId ICloudProjectId Pointer )
            value.DiagnosticsFactory                        = GetObject<IDiagnosticsFactory>(new IntPtr(p + 0x040), ReversePrism.DataModels.IDiagnosticsFactory.FromPointer); // 0x40 DiagnosticsFactory          ( ModelClassType IDiagnosticsFactory IDiagnosticsFactory IDiagnosticsFactory Pointer )
            value.MetricsFactory                            = GetObject<IMetricsFactory>(new IntPtr(p + 0x048), ReversePrism.DataModels.IMetricsFactory.FromPointer); // 0x48 MetricsFactory              ( ModelClassType IMetricsFactory IMetricsFactory IMetricsFactory Pointer )
            value.UnityThreadUtils                          = GetObject<UnityThreadUtilsInternal>(new IntPtr(p + 0x050), ReversePrism.DataModels.UnityThreadUtilsInternal.FromPointer); // 0x50 UnityThreadUtils            ( ModelClassType UnityThreadUtilsInternal UnityThreadUtilsInternal UnityThreadUtilsInternal Pointer )
            value.M_Registry                                = GetObject<CoreRegistry>(new IntPtr(p + 0x058), ReversePrism.DataModels.CoreRegistry.FromPointer); // 0x58 M_Registry                  ( ModelClassType CoreRegistry CoreRegistry CoreRegistry Pointer )
            value.M_Serializer                              = GetObject<IJsonSerializer>(new IntPtr(p + 0x060), ReversePrism.DataModels.IJsonSerializer.FromPointer); // 0x60 M_Serializer                ( ModelClassType IJsonSerializer IJsonSerializer IJsonSerializer Pointer )
            value.M_CurrentInitializationOptions            = GetObject<InitializationOptions>(new IntPtr(p + 0x068), ReversePrism.DataModels.InitializationOptions.FromPointer); // 0x68 M_CurrentInitializationOptions ( ModelClassType InitializationOptions InitializationOptions InitializationOptions Pointer )

            return value;
        }
    }
}
