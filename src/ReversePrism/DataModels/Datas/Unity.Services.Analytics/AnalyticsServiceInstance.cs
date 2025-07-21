using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_ForgetCallingId                        string IL2CPP_TYPE_STRING
    // 000 m_StartUpCallingId                       string IL2CPP_TYPE_STRING
    // 010 K_BackgroundSessionRefreshPeriod         ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 018 M_CommonParams                           ModelClassType StdCommonParams StdCommonParams StdCommonParams Pointer
    // 020 M_PlayerId                               ModelClassType IPlayerId IPlayerId IPlayerId Pointer
    // 028 M_InstallId                              ModelClassType IInstallationId IInstallationId IInstallationId Pointer
    // 030 M_DataGenerator                          ModelClassType IDataGenerator IDataGenerator IDataGenerator Pointer
    // 038 M_CoreStatsHelper                        ModelClassType ICoreStatsHelper ICoreStatsHelper ICoreStatsHelper Pointer
    // 040 M_ConsentTracker                         ModelClassType IConsentTracker IConsentTracker IConsentTracker Pointer
    // 048 M_DataDispatcher                         ModelClassType IDispatcher IDispatcher IDispatcher Pointer
    // 050 M_AnalyticsForgetter                     ModelClassType IAnalyticsForgetter IAnalyticsForgetter IAnalyticsForgetter Pointer
    // 058 M_CustomUserId                           ModelClassType IExternalUserId IExternalUserId IExternalUserId Pointer
    // 060 M_SystemCalls                            ModelClassType IAnalyticsServiceSystemCalls IAnalyticsServiceSystemCalls IAnalyticsServiceSystemCalls Pointer
    // 068 M_Container                              ModelClassType IAnalyticsContainer IAnalyticsContainer IAnalyticsContainer Pointer
    // 070 M_DataBuffer                             ModelClassType IBuffer IBuffer IBuffer Pointer
    // 078 SessionID                                ModelPrimitiveType string string string String
    // 080 M_BufferLengthAtLastGameRunning          ModelPrimitiveType int int int Int32
    // 088 M_ApplicationPauseTime                   ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 090 M_IsActive                               ModelPrimitiveType bool bool bool Bool
    // 094 M_ConsentFlow                            ModelEnumType ConsentFlow ConsentFlow ConsentFlow Int32
    // 098 M_StartUpEventsRecorded                  ModelPrimitiveType bool bool bool Bool
    // 0A0 Converter                                ModelClassType TransactionCurrencyConverter TransactionCurrencyConverter TransactionCurrencyConverter Pointer
    public partial class AnalyticsServiceInstance : DataModel
    {
        public TimeSpan                                 K_BackgroundSessionRefreshPeriod        { get; set; }
        public StdCommonParams?                         M_CommonParams                          { get; set; }
        public IPlayerId?                               M_PlayerId                              { get; set; }
        public IInstallationId?                         M_InstallId                             { get; set; }
        public IDataGenerator?                          M_DataGenerator                         { get; set; }
        public ICoreStatsHelper?                        M_CoreStatsHelper                       { get; set; }
        public IConsentTracker?                         M_ConsentTracker                        { get; set; }
        public IDispatcher?                             M_DataDispatcher                        { get; set; }
        public IAnalyticsForgetter?                     M_AnalyticsForgetter                    { get; set; }
        public IExternalUserId?                         M_CustomUserId                          { get; set; }
        public IAnalyticsServiceSystemCalls?            M_SystemCalls                           { get; set; }
        public IAnalyticsContainer?                     M_Container                             { get; set; }
        public IBuffer?                                 M_DataBuffer                            { get; set; }
        public string                                   SessionID                               { get; set; }
        public int                                      M_BufferLengthAtLastGameRunning         { get; set; }
        public DateTime                                 M_ApplicationPauseTime                  { get; set; }
        public bool                                     M_IsActive                              { get; set; }
        public ConsentFlow                              M_ConsentFlow                           { get; set; }
        public bool                                     M_StartUpEventsRecorded                 { get; set; }
        public TransactionCurrencyConverter?            Converter                               { get; set; }

        public static AnalyticsServiceInstance? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnalyticsServiceInstance() { Pointer= p0 };

            value.K_BackgroundSessionRefreshPeriod          = (TimeSpan)GetInt32(new IntPtr(p + 0x010)); // 0x10 K_BackgroundSessionRefreshPeriod ( ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.M_CommonParams                            = GetObject<StdCommonParams>(new IntPtr(p + 0x018), ReversePrism.DataModels.StdCommonParams.FromPointer); // 0x18 M_CommonParams              ( ModelClassType StdCommonParams StdCommonParams StdCommonParams Pointer )
            value.M_PlayerId                                = GetObject<IPlayerId>(new IntPtr(p + 0x020), ReversePrism.DataModels.IPlayerId.FromPointer); // 0x20 M_PlayerId                  ( ModelClassType IPlayerId IPlayerId IPlayerId Pointer )
            value.M_InstallId                               = GetObject<IInstallationId>(new IntPtr(p + 0x028), ReversePrism.DataModels.IInstallationId.FromPointer); // 0x28 M_InstallId                 ( ModelClassType IInstallationId IInstallationId IInstallationId Pointer )
            value.M_DataGenerator                           = GetObject<IDataGenerator>(new IntPtr(p + 0x030), ReversePrism.DataModels.IDataGenerator.FromPointer); // 0x30 M_DataGenerator             ( ModelClassType IDataGenerator IDataGenerator IDataGenerator Pointer )
            value.M_CoreStatsHelper                         = GetObject<ICoreStatsHelper>(new IntPtr(p + 0x038), ReversePrism.DataModels.ICoreStatsHelper.FromPointer); // 0x38 M_CoreStatsHelper           ( ModelClassType ICoreStatsHelper ICoreStatsHelper ICoreStatsHelper Pointer )
            value.M_ConsentTracker                          = GetObject<IConsentTracker>(new IntPtr(p + 0x040), ReversePrism.DataModels.IConsentTracker.FromPointer); // 0x40 M_ConsentTracker            ( ModelClassType IConsentTracker IConsentTracker IConsentTracker Pointer )
            value.M_DataDispatcher                          = GetObject<IDispatcher>(new IntPtr(p + 0x048), ReversePrism.DataModels.IDispatcher.FromPointer); // 0x48 M_DataDispatcher            ( ModelClassType IDispatcher IDispatcher IDispatcher Pointer )
            value.M_AnalyticsForgetter                      = GetObject<IAnalyticsForgetter>(new IntPtr(p + 0x050), ReversePrism.DataModels.IAnalyticsForgetter.FromPointer); // 0x50 M_AnalyticsForgetter        ( ModelClassType IAnalyticsForgetter IAnalyticsForgetter IAnalyticsForgetter Pointer )
            value.M_CustomUserId                            = GetObject<IExternalUserId>(new IntPtr(p + 0x058), ReversePrism.DataModels.IExternalUserId.FromPointer); // 0x58 M_CustomUserId              ( ModelClassType IExternalUserId IExternalUserId IExternalUserId Pointer )
            value.M_SystemCalls                             = GetObject<IAnalyticsServiceSystemCalls>(new IntPtr(p + 0x060), ReversePrism.DataModels.IAnalyticsServiceSystemCalls.FromPointer); // 0x60 M_SystemCalls               ( ModelClassType IAnalyticsServiceSystemCalls IAnalyticsServiceSystemCalls IAnalyticsServiceSystemCalls Pointer )
            value.M_Container                               = GetObject<IAnalyticsContainer>(new IntPtr(p + 0x068), ReversePrism.DataModels.IAnalyticsContainer.FromPointer); // 0x68 M_Container                 ( ModelClassType IAnalyticsContainer IAnalyticsContainer IAnalyticsContainer Pointer )
            value.M_DataBuffer                              = GetObject<IBuffer>(new IntPtr(p + 0x070), ReversePrism.DataModels.IBuffer.FromPointer); // 0x70 M_DataBuffer                ( ModelClassType IBuffer IBuffer IBuffer Pointer )
            value.SessionID                                 = GetString(new IntPtr(p + 0x078)); // 0x78 SessionID                   ( ModelPrimitiveType string string string String )
            value.M_BufferLengthAtLastGameRunning           = GetInt32(new IntPtr(p + 0x080)); // 0x80 M_BufferLengthAtLastGameRunning ( ModelPrimitiveType int int int Int32 )
            value.M_ApplicationPauseTime                    = GetDateTime(new IntPtr(p + 0x088)); // 0x88 M_ApplicationPauseTime      ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.M_IsActive                                = GetBool(new IntPtr(p + 0x090)); // 0x90 M_IsActive                  ( ModelPrimitiveType bool bool bool Bool )
            value.M_ConsentFlow                             = (ConsentFlow)GetInt32(new IntPtr(p + 0x094)); // 0x94 M_ConsentFlow               ( ModelEnumType ConsentFlow ConsentFlow ConsentFlow Int32 )
            value.M_StartUpEventsRecorded                   = GetBool(new IntPtr(p + 0x098)); // 0x98 M_StartUpEventsRecorded     ( ModelPrimitiveType bool bool bool Bool )
            value.Converter                                 = GetObject<TransactionCurrencyConverter>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.TransactionCurrencyConverter.FromPointer); // 0xA0 Converter                   ( ModelClassType TransactionCurrencyConverter TransactionCurrencyConverter TransactionCurrencyConverter Pointer )

            return value;
        }
    }
}
