using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 PrismTitle                               string IL2CPP_TYPE_STRING
    // 010 NotificationHandler                      0001865C1740 ModelClassType INotificationHandler INotificationHandler INotificationHandler Pointer
    // 018 MessagingHandler                         0001865B16E0 ModelClassType IMessagingHandler IMessagingHandler IMessagingHandler Pointer
    // 020 SettingsSaveData                         0001866B5110 ModelClassType NotificationSettingsSaveData NotificationSettingsSaveData NotificationSettingsSaveData Pointer
    // 028 NotificationSaveData                     0001866B4520 ModelClassType NotificationSaveData NotificationSaveData NotificationSaveData Pointer
    // 030 TextReader                               0001865C2AC0 ModelClassType INotificationTextReader INotificationTextReader INotificationTextReader Pointer
    // 038 BirthdayNotification                     00018675ECE0 ModelClassType BirthdayNotification BirthdayNotification BirthdayNotification Pointer
    // 040 Disposables                              0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 048 ModuleInitialized                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 050 MessagingTokenSource                     0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 058 IsNotificationPermission                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class NotificationManager : DataModel
    {
        public INotificationHandler?                    NotificationHandler                     { get; set; }
        public IMessagingHandler?                       MessagingHandler                        { get; set; }
        public NotificationSettingsSaveData?            SettingsSaveData                        { get; set; }
        public NotificationSaveData?                    NotificationSaveData                    { get; set; }
        public INotificationTextReader?                 TextReader                              { get; set; }
        public BirthdayNotification?                    BirthdayNotification                    { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public bool                                     ModuleInitialized                       { get; set; }
        public CancellationTokenSource?                 MessagingTokenSource                    { get; set; }
        public bool                                     IsNotificationPermission                { get; set; }

        public static NotificationManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NotificationManager() { Pointer= p0 };

            value.NotificationHandler                       = GetObject<INotificationHandler>(new IntPtr(p + 0x010), ReversePrism.DataModels.INotificationHandler.FromPointer); // 0245A3ACE818 0x10 NotificationHandler         ( 0001865C1740 ModelClassType INotificationHandler INotificationHandler INotificationHandler Pointer )
            value.MessagingHandler                          = GetObject<IMessagingHandler>(new IntPtr(p + 0x018), ReversePrism.DataModels.IMessagingHandler.FromPointer); // 0245A3ACE838 0x18 MessagingHandler            ( 0001865B16E0 ModelClassType IMessagingHandler IMessagingHandler IMessagingHandler Pointer )
            value.SettingsSaveData                          = GetObject<NotificationSettingsSaveData>(new IntPtr(p + 0x020), ReversePrism.DataModels.NotificationSettingsSaveData.FromPointer); // 0245A3ACE858 0x20 SettingsSaveData            ( 0001866B5110 ModelClassType NotificationSettingsSaveData NotificationSettingsSaveData NotificationSettingsSaveData Pointer )
            value.NotificationSaveData                      = GetObject<NotificationSaveData>(new IntPtr(p + 0x028), ReversePrism.DataModels.NotificationSaveData.FromPointer); // 0245A3ACE878 0x28 NotificationSaveData        ( 0001866B4520 ModelClassType NotificationSaveData NotificationSaveData NotificationSaveData Pointer )
            value.TextReader                                = GetObject<INotificationTextReader>(new IntPtr(p + 0x030), ReversePrism.DataModels.INotificationTextReader.FromPointer); // 0245A3ACE898 0x30 TextReader                  ( 0001865C2AC0 ModelClassType INotificationTextReader INotificationTextReader INotificationTextReader Pointer )
            value.BirthdayNotification                      = GetObject<BirthdayNotification>(new IntPtr(p + 0x038), ReversePrism.DataModels.BirthdayNotification.FromPointer); // 0245A3ACE8B8 0x38 BirthdayNotification        ( 00018675ECE0 ModelClassType BirthdayNotification BirthdayNotification BirthdayNotification Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x040), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0245A3ACE8D8 0x40 Disposables                 ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.ModuleInitialized                         = GetBool(new IntPtr(p + 0x048)); // 0245A3ACE8F8 0x48 ModuleInitialized           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MessagingTokenSource                      = GetObject<CancellationTokenSource>(new IntPtr(p + 0x050), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0245A3ACE918 0x50 MessagingTokenSource        ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.IsNotificationPermission                  = GetBool(new IntPtr(p + 0x058)); // 0245A3ACE938 0x58 IsNotificationPermission    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
