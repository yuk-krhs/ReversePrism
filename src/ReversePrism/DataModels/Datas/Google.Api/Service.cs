using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Service> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Name                                     000186671910 ModelPrimitiveType string string string String
    // 000 TitleFieldNumber                         int IL2CPP_TYPE_I4
    // 020 Title                                    000186671910 ModelPrimitiveType string string string String
    // 000 ProducerProjectIdFieldNumber             int IL2CPP_TYPE_I4
    // 028 ProducerProjectId                        000186671910 ModelPrimitiveType string string string String
    // 000 IdFieldNumber                            int IL2CPP_TYPE_I4
    // 030 Id                                       000186671910 ModelPrimitiveType string string string String
    // 000 ApisFieldNumber                          int IL2CPP_TYPE_I4
    // 008 _repeated_apis_codec                     FieldCodec`1<Api> IL2CPP_TYPE_GENERICINST
    // 038 Apis                                     000185CCE6A8 ModelClassListType RepeatedField`1<Api> RepeatedField`1<Api> List<Api> Pointer
    // 000 Types_FieldNumber                        int IL2CPP_TYPE_I4
    // 010 _repeated_types_codec                    FieldCodec`1<Type> IL2CPP_TYPE_GENERICINST
    // 040 Types                                    000185CF6068 ModelClassListType RepeatedField`1<Type> RepeatedField`1<Type> List<Type> Pointer
    // 000 EnumsFieldNumber                         int IL2CPP_TYPE_I4
    // 018 _repeated_enums_codec                    FieldCodec`1<Enum> IL2CPP_TYPE_GENERICINST
    // 048 Enums                                    000185CD42C8 ModelClassListType RepeatedField`1<Enum> RepeatedField`1<Enum> List<Enum> Pointer
    // 000 DocumentationFieldNumber                 int IL2CPP_TYPE_I4
    // 050 Documentation                            0001866E99A0 ModelClassType Documentation Documentation Documentation Pointer
    // 000 BackendFieldNumber                       int IL2CPP_TYPE_I4
    // 058 Backend                                  000186733360 ModelClassType Backend Backend Backend Pointer
    // 000 HttpFieldNumber                          int IL2CPP_TYPE_I4
    // 060 Http                                     0001866DB7C0 ModelClassType Http Http Http Pointer
    // 000 QuotaFieldNumber                         int IL2CPP_TYPE_I4
    // 068 Quota                                    000186601160 ModelClassType Quota Quota Quota Pointer
    // 000 AuthenticationFieldNumber                int IL2CPP_TYPE_I4
    // 070 Authentication                           000186722470 ModelClassType Authentication Authentication Authentication Pointer
    // 000 ContextFieldNumber                       int IL2CPP_TYPE_I4
    // 078 Context                                  000186613070 ModelClassType Context Context Context Pointer
    // 000 UsageFieldNumber                         int IL2CPP_TYPE_I4
    // 080 Usage                                    000186749260 ModelClassType Usage Usage Usage Pointer
    // 000 EndpointsFieldNumber                     int IL2CPP_TYPE_I4
    // 020 _repeated_endpoints_codec                FieldCodec`1<Endpoint> IL2CPP_TYPE_GENERICINST
    // 088 Endpoints                                000185CD4058 ModelClassListType RepeatedField`1<Endpoint> RepeatedField`1<Endpoint> List<Endpoint> Pointer
    // 000 ControlFieldNumber                       int IL2CPP_TYPE_I4
    // 090 Control                                  00018661AF00 ModelClassType Control Control Control Pointer
    // 000 LogsFieldNumber                          int IL2CPP_TYPE_I4
    // 028 _repeated_logs_codec                     FieldCodec`1<LogDescriptor> IL2CPP_TYPE_GENERICINST
    // 098 Logs                                     000185CE49E8 ModelClassListType RepeatedField`1<LogDescriptor> RepeatedField`1<LogDescriptor> List<LogDescriptor> Pointer
    // 000 MetricsFieldNumber                       int IL2CPP_TYPE_I4
    // 030 _repeated_metrics_codec                  FieldCodec`1<MetricDescriptor> IL2CPP_TYPE_GENERICINST
    // 0A0 Metrics                                  000185CE6568 ModelClassListType RepeatedField`1<MetricDescriptor> RepeatedField`1<MetricDescriptor> List<MetricDescriptor> Pointer
    // 000 MonitoredResourcesFieldNumber            int IL2CPP_TYPE_I4
    // 038 _repeated_monitoredResources_codec       FieldCodec`1<MonitoredResourceDescriptor> IL2CPP_TYPE_GENERICINST
    // 0A8 MonitoredResources                       000185CE7598 ModelClassListType RepeatedField`1<MonitoredResourceDescriptor> RepeatedField`1<MonitoredResourceDescriptor> List<MonitoredResourceDescriptor> Pointer
    // 000 BillingFieldNumber                       int IL2CPP_TYPE_I4
    // 0B0 Billing                                  000186751090 ModelClassType Billing Billing Billing Pointer
    // 000 LoggingFieldNumber                       int IL2CPP_TYPE_I4
    // 0B8 Logging                                  0001865B46A0 ModelClassType Logging Logging Logging Pointer
    // 000 MonitoringFieldNumber                    int IL2CPP_TYPE_I4
    // 0C0 Monitoring                               00018663CD00 ModelClassType Monitoring Monitoring Monitoring Pointer
    // 000 SystemParametersFieldNumber              int IL2CPP_TYPE_I4
    // 0C8 SystemParameters                         000186608530 ModelClassType SystemParameters SystemParameters SystemParameters Pointer
    // 000 SourceInfoFieldNumber                    int IL2CPP_TYPE_I4
    // 0D0 SourceInfo                               00018653A1C0 ModelClassType SourceInfo SourceInfo SourceInfo Pointer
    // 000 ConfigVersionFieldNumber                 int IL2CPP_TYPE_I4
    // 040 _single_configVersion_codec              FieldCodec`1<Nullable`1<uint>> IL2CPP_TYPE_GENERICINST
    // 0D8 configVersion_                           Nullable`1<uint> IL2CPP_TYPE_GENERICINST
    public partial class Service : DataModel
    {
        public string                                   Name                                    { get; set; }
        public string                                   Title                                   { get; set; }
        public string                                   ProducerProjectId                       { get; set; }
        public string                                   Id                                      { get; set; }
        public List<Api>?                               Apis                                    { get; set; }
        public List<Type>?                              Types                                   { get; set; }
        public List<Enum>?                              Enums                                   { get; set; }
        public Documentation?                           Documentation                           { get; set; }
        public Backend?                                 Backend                                 { get; set; }
        public Http?                                    Http                                    { get; set; }
        public Quota?                                   Quota                                   { get; set; }
        public Authentication?                          Authentication                          { get; set; }
        public Context?                                 Context                                 { get; set; }
        public Usage?                                   Usage                                   { get; set; }
        public List<Endpoint>?                          Endpoints                               { get; set; }
        public Control?                                 Control                                 { get; set; }
        public List<LogDescriptor>?                     Logs                                    { get; set; }
        public List<MetricDescriptor>?                  Metrics                                 { get; set; }
        public List<MonitoredResourceDescriptor>?       MonitoredResources                      { get; set; }
        public Billing?                                 Billing                                 { get; set; }
        public Logging?                                 Logging                                 { get; set; }
        public Monitoring?                              Monitoring                              { get; set; }
        public SystemParameters?                        SystemParameters                        { get; set; }
        public SourceInfo?                              SourceInfo                              { get; set; }

        public static Service? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Service() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 02466A8A7A18 0x18 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Title                                     = GetString(new IntPtr(p + 0x020)); // 02466A8A7A58 0x20 Title                       ( 000186671910 ModelPrimitiveType string string string String )
            value.ProducerProjectId                         = GetString(new IntPtr(p + 0x028)); // 02466A8A7A98 0x28 ProducerProjectId           ( 000186671910 ModelPrimitiveType string string string String )
            value.Id                                        = GetString(new IntPtr(p + 0x030)); // 02466A8A7AD8 0x30 Id                          ( 000186671910 ModelPrimitiveType string string string String )
            value.Apis                                      = GetObjectList<Api>(new IntPtr(p + 0x038), ReversePrism.DataModels.Api.FromPointer); // 02466A8A7B38 0x38 Apis                        ( 000185CCE6A8 ModelClassListType RepeatedField`1<Api> RepeatedField`1<Api> List<Api> Pointer )
            value.Types                                     = GetObjectList<Type>(new IntPtr(p + 0x040), ReversePrism.DataModels.Type.FromPointer); // 02466A8A7B98 0x40 Types                       ( 000185CF6068 ModelClassListType RepeatedField`1<Type> RepeatedField`1<Type> List<Type> Pointer )
            value.Enums                                     = GetObjectList<Enum>(new IntPtr(p + 0x048), ReversePrism.DataModels.Enum.FromPointer); // 02466A8A7BF8 0x48 Enums                       ( 000185CD42C8 ModelClassListType RepeatedField`1<Enum> RepeatedField`1<Enum> List<Enum> Pointer )
            value.Documentation                             = GetObject<Documentation>(new IntPtr(p + 0x050), ReversePrism.DataModels.Documentation.FromPointer); // 02466A8A7C38 0x50 Documentation               ( 0001866E99A0 ModelClassType Documentation Documentation Documentation Pointer )
            value.Backend                                   = GetObject<Backend>(new IntPtr(p + 0x058), ReversePrism.DataModels.Backend.FromPointer); // 02466A8A7C78 0x58 Backend                     ( 000186733360 ModelClassType Backend Backend Backend Pointer )
            value.Http                                      = GetObject<Http>(new IntPtr(p + 0x060), ReversePrism.DataModels.Http.FromPointer); // 02466A8A7CB8 0x60 Http                        ( 0001866DB7C0 ModelClassType Http Http Http Pointer )
            value.Quota                                     = GetObject<Quota>(new IntPtr(p + 0x068), ReversePrism.DataModels.Quota.FromPointer); // 02466A8A7CF8 0x68 Quota                       ( 000186601160 ModelClassType Quota Quota Quota Pointer )
            value.Authentication                            = GetObject<Authentication>(new IntPtr(p + 0x070), ReversePrism.DataModels.Authentication.FromPointer); // 02466A8A7D38 0x70 Authentication              ( 000186722470 ModelClassType Authentication Authentication Authentication Pointer )
            value.Context                                   = GetObject<Context>(new IntPtr(p + 0x078), ReversePrism.DataModels.Context.FromPointer); // 02466A8A7D78 0x78 Context                     ( 000186613070 ModelClassType Context Context Context Pointer )
            value.Usage                                     = GetObject<Usage>(new IntPtr(p + 0x080), ReversePrism.DataModels.Usage.FromPointer); // 02466A8A7DB8 0x80 Usage                       ( 000186749260 ModelClassType Usage Usage Usage Pointer )
            value.Endpoints                                 = GetObjectList<Endpoint>(new IntPtr(p + 0x088), ReversePrism.DataModels.Endpoint.FromPointer); // 02466A8A7E18 0x88 Endpoints                   ( 000185CD4058 ModelClassListType RepeatedField`1<Endpoint> RepeatedField`1<Endpoint> List<Endpoint> Pointer )
            value.Control                                   = GetObject<Control>(new IntPtr(p + 0x090), ReversePrism.DataModels.Control.FromPointer); // 02466A8A7E58 0x90 Control                     ( 00018661AF00 ModelClassType Control Control Control Pointer )
            value.Logs                                      = GetObjectList<LogDescriptor>(new IntPtr(p + 0x098), ReversePrism.DataModels.LogDescriptor.FromPointer); // 02466A8A7EB8 0x98 Logs                        ( 000185CE49E8 ModelClassListType RepeatedField`1<LogDescriptor> RepeatedField`1<LogDescriptor> List<LogDescriptor> Pointer )
            value.Metrics                                   = GetObjectList<MetricDescriptor>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.MetricDescriptor.FromPointer); // 02466A8A7F18 0xA0 Metrics                     ( 000185CE6568 ModelClassListType RepeatedField`1<MetricDescriptor> RepeatedField`1<MetricDescriptor> List<MetricDescriptor> Pointer )
            value.MonitoredResources                        = GetObjectList<MonitoredResourceDescriptor>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.MonitoredResourceDescriptor.FromPointer); // 02466A8A7F78 0xA8 MonitoredResources          ( 000185CE7598 ModelClassListType RepeatedField`1<MonitoredResourceDescriptor> RepeatedField`1<MonitoredResourceDescriptor> List<MonitoredResourceDescriptor> Pointer )
            value.Billing                                   = GetObject<Billing>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Billing.FromPointer); // 02466A8A7FB8 0xB0 Billing                     ( 000186751090 ModelClassType Billing Billing Billing Pointer )
            value.Logging                                   = GetObject<Logging>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.Logging.FromPointer); // 02466A8A7FF8 0xB8 Logging                     ( 0001865B46A0 ModelClassType Logging Logging Logging Pointer )
            value.Monitoring                                = GetObject<Monitoring>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.Monitoring.FromPointer); // 02466A8A8038 0xC0 Monitoring                  ( 00018663CD00 ModelClassType Monitoring Monitoring Monitoring Pointer )
            value.SystemParameters                          = GetObject<SystemParameters>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.SystemParameters.FromPointer); // 02466A8A8078 0xC8 SystemParameters            ( 000186608530 ModelClassType SystemParameters SystemParameters SystemParameters Pointer )
            value.SourceInfo                                = GetObject<SourceInfo>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.SourceInfo.FromPointer); // 02466A8A80B8 0xD0 SourceInfo                  ( 00018653A1C0 ModelClassType SourceInfo SourceInfo SourceInfo Pointer )

            return value;
        }
    }
}
