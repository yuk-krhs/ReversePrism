using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Communicator                             00018651A010 ModelClassType PrivacyOptionCommunicator PrivacyOptionCommunicator PrivacyOptionCommunicator Pointer
    // 018 ExecutorParameter                        00018651AF90 ModelClassType PrivacyOptionExecutorParameter PrivacyOptionExecutorParameter PrivacyOptionExecutorParameter Pointer
    // 020 LocalizationManager                      0001865A7340 ModelClassType LocalizationManager LocalizationManager LocalizationManager Pointer
    // 028 MessagePopupSequencer                    0001867347C0 ModelClassType ICommonSequencerContainer ICommonSequencerContainer ICommonSequencerContainer Pointer
    // 030 CachedTermUrlResponse                    00018662F840 ModelClassType TermUrlResponse TermUrlResponse TermUrlResponse Pointer
    // 038 CachedConsentResponse                    000186605F40 ModelClassType ConsentResponse ConsentResponse ConsentResponse Pointer
    // 040 CurrentConsentStatus                     0001865AFE80 ModelEnumType ConfirmConsentStatus ConfirmConsentStatus ConfirmConsentStatus Int32
    public partial class PrivacyOptionExecutor
    {
        public PrivacyOptionCommunicator?               Communicator                            { get; set; }
        public PrivacyOptionExecutorParameter?          ExecutorParameter                       { get; set; }
        public LocalizationManager?                     LocalizationManager                     { get; set; }
        public ICommonSequencerContainer?               MessagePopupSequencer                   { get; set; }
        public TermUrlResponse?                         CachedTermUrlResponse                   { get; set; }
        public ConsentResponse?                         CachedConsentResponse                   { get; set; }
        public ConfirmConsentStatus                     CurrentConsentStatus                    { get; set; }

        public static PrivacyOptionExecutor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrivacyOptionExecutor();

            value.Communicator                              = GetObject<PrivacyOptionCommunicator>(new IntPtr(p + 0x010), ReversePrism.DataModels.PrivacyOptionCommunicator.FromPointer); // 027004E15D40 0x10 Communicator                ( 00018651A010 ModelClassType PrivacyOptionCommunicator PrivacyOptionCommunicator PrivacyOptionCommunicator Pointer )
            value.ExecutorParameter                         = GetObject<PrivacyOptionExecutorParameter>(new IntPtr(p + 0x018), ReversePrism.DataModels.PrivacyOptionExecutorParameter.FromPointer); // 027004E15D60 0x18 ExecutorParameter           ( 00018651AF90 ModelClassType PrivacyOptionExecutorParameter PrivacyOptionExecutorParameter PrivacyOptionExecutorParameter Pointer )
            value.LocalizationManager                       = GetObject<LocalizationManager>(new IntPtr(p + 0x020), ReversePrism.DataModels.LocalizationManager.FromPointer); // 027004E15D80 0x20 LocalizationManager         ( 0001865A7340 ModelClassType LocalizationManager LocalizationManager LocalizationManager Pointer )
            value.MessagePopupSequencer                     = GetObject<ICommonSequencerContainer>(new IntPtr(p + 0x028), ReversePrism.DataModels.ICommonSequencerContainer.FromPointer); // 027004E15DA0 0x28 MessagePopupSequencer       ( 0001867347C0 ModelClassType ICommonSequencerContainer ICommonSequencerContainer ICommonSequencerContainer Pointer )
            value.CachedTermUrlResponse                     = GetObject<TermUrlResponse>(new IntPtr(p + 0x030), ReversePrism.DataModels.TermUrlResponse.FromPointer); // 027004E15DC0 0x30 CachedTermUrlResponse       ( 00018662F840 ModelClassType TermUrlResponse TermUrlResponse TermUrlResponse Pointer )
            value.CachedConsentResponse                     = GetObject<ConsentResponse>(new IntPtr(p + 0x038), ReversePrism.DataModels.ConsentResponse.FromPointer); // 027004E15DE0 0x38 CachedConsentResponse       ( 000186605F40 ModelClassType ConsentResponse ConsentResponse ConsentResponse Pointer )
            value.CurrentConsentStatus                      = (ConfirmConsentStatus)GetInt32(new IntPtr(p + 0x040)); // 027004E15E00 0x40 CurrentConsentStatus        ( 0001865AFE80 ModelEnumType ConfirmConsentStatus ConfirmConsentStatus ConfirmConsentStatus Int32 )

            return value;
        }
    }
}
