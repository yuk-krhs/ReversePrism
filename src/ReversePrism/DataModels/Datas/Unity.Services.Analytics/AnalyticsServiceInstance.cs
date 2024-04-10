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
    // 010 K_BackgroundSessionRefreshPeriod         00018668B520 ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 018 M_CommonParams                           000186587C90 ModelClassType StdCommonParams StdCommonParams StdCommonParams Pointer
    // 020 M_PlayerId                               0001865D7FA0 ModelClassType IPlayerId IPlayerId IPlayerId Pointer
    // 028 M_InstallId                              0001865843B0 ModelClassType IInstallationId IInstallationId IInstallationId Pointer
    // 030 M_DataGenerator                          00018674AD40 ModelClassType IDataGenerator IDataGenerator IDataGenerator Pointer
    // 038 M_CoreStatsHelper                        00018673FB40 ModelClassType ICoreStatsHelper ICoreStatsHelper ICoreStatsHelper Pointer
    // 040 M_ConsentTracker                         000186739920 ModelClassType IConsentTracker IConsentTracker IConsentTracker Pointer
    // 048 M_DataDispatcher                         000186752CD0 ModelClassType IDispatcher IDispatcher IDispatcher Pointer
    // 050 M_AnalyticsForgetter                     0001866F2F50 ModelClassType IAnalyticsForgetter IAnalyticsForgetter IAnalyticsForgetter Pointer
    // 058 M_CustomUserId                           000186772110 ModelClassType IExternalUserId IExternalUserId IExternalUserId Pointer
    // 060 M_SystemCalls                            0001866F38F0 ModelClassType IAnalyticsServiceSystemCalls IAnalyticsServiceSystemCalls IAnalyticsServiceSystemCalls Pointer
    // 068 M_Container                              0001866F2840 ModelClassType IAnalyticsContainer IAnalyticsContainer IAnalyticsContainer Pointer
    // 070 M_DataBuffer                             0001865E1A50 ModelClassType IBuffer IBuffer IBuffer Pointer
    // 078 SessionID                                000186671910 ModelPrimitiveType string string string String
    // 080 M_BufferLengthAtLastGameRunning          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 088 M_ApplicationPauseTime                   0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 090 M_IsActive                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 094 M_ConsentFlow                            00018669DBB0 ModelEnumType ConsentFlow ConsentFlow ConsentFlow Int32
    // 098 M_StartUpEventsRecorded                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A0 Converter                                0001866A0A30 ModelClassType TransactionCurrencyConverter TransactionCurrencyConverter TransactionCurrencyConverter Pointer
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

            value.K_BackgroundSessionRefreshPeriod          = (TimeSpan)GetInt32(new IntPtr(p + 0x010)); // 0245A667FCF8 0x10 K_BackgroundSessionRefreshPeriod ( 00018668B520 ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.M_CommonParams                            = GetObject<StdCommonParams>(new IntPtr(p + 0x018), ReversePrism.DataModels.StdCommonParams.FromPointer); // 0245A667FD18 0x18 M_CommonParams              ( 000186587C90 ModelClassType StdCommonParams StdCommonParams StdCommonParams Pointer )
            value.M_PlayerId                                = GetObject<IPlayerId>(new IntPtr(p + 0x020), ReversePrism.DataModels.IPlayerId.FromPointer); // 0245A667FD38 0x20 M_PlayerId                  ( 0001865D7FA0 ModelClassType IPlayerId IPlayerId IPlayerId Pointer )
            value.M_InstallId                               = GetObject<IInstallationId>(new IntPtr(p + 0x028), ReversePrism.DataModels.IInstallationId.FromPointer); // 0245A667FD58 0x28 M_InstallId                 ( 0001865843B0 ModelClassType IInstallationId IInstallationId IInstallationId Pointer )
            value.M_DataGenerator                           = GetObject<IDataGenerator>(new IntPtr(p + 0x030), ReversePrism.DataModels.IDataGenerator.FromPointer); // 0245A667FD78 0x30 M_DataGenerator             ( 00018674AD40 ModelClassType IDataGenerator IDataGenerator IDataGenerator Pointer )
            value.M_CoreStatsHelper                         = GetObject<ICoreStatsHelper>(new IntPtr(p + 0x038), ReversePrism.DataModels.ICoreStatsHelper.FromPointer); // 0245A667FD98 0x38 M_CoreStatsHelper           ( 00018673FB40 ModelClassType ICoreStatsHelper ICoreStatsHelper ICoreStatsHelper Pointer )
            value.M_ConsentTracker                          = GetObject<IConsentTracker>(new IntPtr(p + 0x040), ReversePrism.DataModels.IConsentTracker.FromPointer); // 0245A667FDB8 0x40 M_ConsentTracker            ( 000186739920 ModelClassType IConsentTracker IConsentTracker IConsentTracker Pointer )
            value.M_DataDispatcher                          = GetObject<IDispatcher>(new IntPtr(p + 0x048), ReversePrism.DataModels.IDispatcher.FromPointer); // 0245A667FDD8 0x48 M_DataDispatcher            ( 000186752CD0 ModelClassType IDispatcher IDispatcher IDispatcher Pointer )
            value.M_AnalyticsForgetter                      = GetObject<IAnalyticsForgetter>(new IntPtr(p + 0x050), ReversePrism.DataModels.IAnalyticsForgetter.FromPointer); // 0245A667FDF8 0x50 M_AnalyticsForgetter        ( 0001866F2F50 ModelClassType IAnalyticsForgetter IAnalyticsForgetter IAnalyticsForgetter Pointer )
            value.M_CustomUserId                            = GetObject<IExternalUserId>(new IntPtr(p + 0x058), ReversePrism.DataModels.IExternalUserId.FromPointer); // 0245A667FE18 0x58 M_CustomUserId              ( 000186772110 ModelClassType IExternalUserId IExternalUserId IExternalUserId Pointer )
            value.M_SystemCalls                             = GetObject<IAnalyticsServiceSystemCalls>(new IntPtr(p + 0x060), ReversePrism.DataModels.IAnalyticsServiceSystemCalls.FromPointer); // 0245A667FE38 0x60 M_SystemCalls               ( 0001866F38F0 ModelClassType IAnalyticsServiceSystemCalls IAnalyticsServiceSystemCalls IAnalyticsServiceSystemCalls Pointer )
            value.M_Container                               = GetObject<IAnalyticsContainer>(new IntPtr(p + 0x068), ReversePrism.DataModels.IAnalyticsContainer.FromPointer); // 0245A667FE58 0x68 M_Container                 ( 0001866F2840 ModelClassType IAnalyticsContainer IAnalyticsContainer IAnalyticsContainer Pointer )
            value.M_DataBuffer                              = GetObject<IBuffer>(new IntPtr(p + 0x070), ReversePrism.DataModels.IBuffer.FromPointer); // 0245A667FE78 0x70 M_DataBuffer                ( 0001865E1A50 ModelClassType IBuffer IBuffer IBuffer Pointer )
            value.SessionID                                 = GetString(new IntPtr(p + 0x078)); // 0245A667FE98 0x78 SessionID                   ( 000186671910 ModelPrimitiveType string string string String )
            value.M_BufferLengthAtLastGameRunning           = GetInt32(new IntPtr(p + 0x080)); // 0245A667FEB8 0x80 M_BufferLengthAtLastGameRunning ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_ApplicationPauseTime                    = GetDateTime(new IntPtr(p + 0x088)); // 0245A667FED8 0x88 M_ApplicationPauseTime      ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.M_IsActive                                = GetBool(new IntPtr(p + 0x090)); // 0245A667FEF8 0x90 M_IsActive                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_ConsentFlow                             = (ConsentFlow)GetInt32(new IntPtr(p + 0x094)); // 0245A667FF18 0x94 M_ConsentFlow               ( 00018669DBB0 ModelEnumType ConsentFlow ConsentFlow ConsentFlow Int32 )
            value.M_StartUpEventsRecorded                   = GetBool(new IntPtr(p + 0x098)); // 0245A667FF38 0x98 M_StartUpEventsRecorded     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Converter                                 = GetObject<TransactionCurrencyConverter>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.TransactionCurrencyConverter.FromPointer); // 0245A667FF58 0xA0 Converter                   ( 0001866A0A30 ModelClassType TransactionCurrencyConverter TransactionCurrencyConverter TransactionCurrencyConverter Pointer )

            return value;
        }
    }
}
