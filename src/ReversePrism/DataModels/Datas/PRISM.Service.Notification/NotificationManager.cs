using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 PrismTitle                               string IL2CPP_TYPE_STRING
    // 010 NotificationHandler                      ModelClassType INotificationHandler INotificationHandler INotificationHandler Pointer
    // 018 MessageFilter                            ModelClassType ServerMessageFilter ServerMessageFilter ServerMessageFilter Pointer
    // 020 SettingsSaveData                         ModelClassType NotificationSettingsSaveData NotificationSettingsSaveData NotificationSettingsSaveData Pointer
    // 028 NotificationSaveData                     ModelClassType NotificationSaveData NotificationSaveData NotificationSaveData Pointer
    // 030 TextReader                               ModelClassType INotificationTextReader INotificationTextReader INotificationTextReader Pointer
    // 038 BirthdayNotification                     ModelClassType BirthdayNotification BirthdayNotification BirthdayNotification Pointer
    // 040 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 048 ModuleInitialized                        ModelPrimitiveType bool bool bool Bool
    // 049 ServerPushInitialized                    ModelPrimitiveType bool bool bool Bool
    // 04A IsNotificationPermission                 ModelPrimitiveType bool bool bool Bool
    // 04B ServerNotificationActivated              ModelPrimitiveType bool bool bool Bool
    // 050 TokenSource                              ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 058 IsApplicationPause                       ModelPrimitiveType bool bool bool Bool
    public partial class NotificationManager : DataModel
    {
        public INotificationHandler?                    NotificationHandler                     { get; set; }
        public ServerMessageFilter?                     MessageFilter                           { get; set; }
        public NotificationSettingsSaveData?            SettingsSaveData                        { get; set; }
        public NotificationSaveData?                    NotificationSaveData                    { get; set; }
        public INotificationTextReader?                 TextReader                              { get; set; }
        public BirthdayNotification?                    BirthdayNotification                    { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public bool                                     ModuleInitialized                       { get; set; }
        public bool                                     ServerPushInitialized                   { get; set; }
        public bool                                     IsNotificationPermission                { get; set; }
        public bool                                     ServerNotificationActivated             { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }
        public bool                                     IsApplicationPause                      { get; set; }

        public static NotificationManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NotificationManager() { Pointer= p0 };

            value.NotificationHandler                       = GetObject<INotificationHandler>(new IntPtr(p + 0x010), ReversePrism.DataModels.INotificationHandler.FromPointer); // 0x10 NotificationHandler         ( ModelClassType INotificationHandler INotificationHandler INotificationHandler Pointer )
            value.MessageFilter                             = GetObject<ServerMessageFilter>(new IntPtr(p + 0x018), ReversePrism.DataModels.ServerMessageFilter.FromPointer); // 0x18 MessageFilter               ( ModelClassType ServerMessageFilter ServerMessageFilter ServerMessageFilter Pointer )
            value.SettingsSaveData                          = GetObject<NotificationSettingsSaveData>(new IntPtr(p + 0x020), ReversePrism.DataModels.NotificationSettingsSaveData.FromPointer); // 0x20 SettingsSaveData            ( ModelClassType NotificationSettingsSaveData NotificationSettingsSaveData NotificationSettingsSaveData Pointer )
            value.NotificationSaveData                      = GetObject<NotificationSaveData>(new IntPtr(p + 0x028), ReversePrism.DataModels.NotificationSaveData.FromPointer); // 0x28 NotificationSaveData        ( ModelClassType NotificationSaveData NotificationSaveData NotificationSaveData Pointer )
            value.TextReader                                = GetObject<INotificationTextReader>(new IntPtr(p + 0x030), ReversePrism.DataModels.INotificationTextReader.FromPointer); // 0x30 TextReader                  ( ModelClassType INotificationTextReader INotificationTextReader INotificationTextReader Pointer )
            value.BirthdayNotification                      = GetObject<BirthdayNotification>(new IntPtr(p + 0x038), ReversePrism.DataModels.BirthdayNotification.FromPointer); // 0x38 BirthdayNotification        ( ModelClassType BirthdayNotification BirthdayNotification BirthdayNotification Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x040), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x40 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.ModuleInitialized                         = GetBool(new IntPtr(p + 0x048)); // 0x48 ModuleInitialized           ( ModelPrimitiveType bool bool bool Bool )
            value.ServerPushInitialized                     = GetBool(new IntPtr(p + 0x049)); // 0x49 ServerPushInitialized       ( ModelPrimitiveType bool bool bool Bool )
            value.IsNotificationPermission                  = GetBool(new IntPtr(p + 0x04A)); // 0x4A IsNotificationPermission    ( ModelPrimitiveType bool bool bool Bool )
            value.ServerNotificationActivated               = GetBool(new IntPtr(p + 0x04B)); // 0x4B ServerNotificationActivated ( ModelPrimitiveType bool bool bool Bool )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x050), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x50 TokenSource                 ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.IsApplicationPause                        = GetBool(new IntPtr(p + 0x058)); // 0x58 IsApplicationPause          ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
