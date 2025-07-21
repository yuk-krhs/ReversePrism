using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Communicator                             ModelClassType PrivacyOptionCommunicator PrivacyOptionCommunicator PrivacyOptionCommunicator Pointer
    // 018 ExecutorParameter                        ModelClassType PrivacyOptionExecutorParameter PrivacyOptionExecutorParameter PrivacyOptionExecutorParameter Pointer
    // 020 LocalizationManager                      ModelClassType LocalizationManager LocalizationManager LocalizationManager Pointer
    // 028 MessagePopupSequencer                    ModelClassType ICommonSequencerContainer ICommonSequencerContainer ICommonSequencerContainer Pointer
    // 030 CachedTermUrlResponse                    ModelClassType TermUrlResponse TermUrlResponse TermUrlResponse Pointer
    // 038 CachedConsentResponse                    ModelClassType ConsentResponse ConsentResponse ConsentResponse Pointer
    // 040 CurrentConsentStatus                     ModelEnumType ConfirmConsentStatus ConfirmConsentStatus ConfirmConsentStatus Int32
    public partial class PrivacyOptionExecutor : DataModel
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
            var value   = new PrivacyOptionExecutor() { Pointer= p0 };

            value.Communicator                              = GetObject<PrivacyOptionCommunicator>(new IntPtr(p + 0x010), ReversePrism.DataModels.PrivacyOptionCommunicator.FromPointer); // 0x10 Communicator                ( ModelClassType PrivacyOptionCommunicator PrivacyOptionCommunicator PrivacyOptionCommunicator Pointer )
            value.ExecutorParameter                         = GetObject<PrivacyOptionExecutorParameter>(new IntPtr(p + 0x018), ReversePrism.DataModels.PrivacyOptionExecutorParameter.FromPointer); // 0x18 ExecutorParameter           ( ModelClassType PrivacyOptionExecutorParameter PrivacyOptionExecutorParameter PrivacyOptionExecutorParameter Pointer )
            value.LocalizationManager                       = GetObject<LocalizationManager>(new IntPtr(p + 0x020), ReversePrism.DataModels.LocalizationManager.FromPointer); // 0x20 LocalizationManager         ( ModelClassType LocalizationManager LocalizationManager LocalizationManager Pointer )
            value.MessagePopupSequencer                     = GetObject<ICommonSequencerContainer>(new IntPtr(p + 0x028), ReversePrism.DataModels.ICommonSequencerContainer.FromPointer); // 0x28 MessagePopupSequencer       ( ModelClassType ICommonSequencerContainer ICommonSequencerContainer ICommonSequencerContainer Pointer )
            value.CachedTermUrlResponse                     = GetObject<TermUrlResponse>(new IntPtr(p + 0x030), ReversePrism.DataModels.TermUrlResponse.FromPointer); // 0x30 CachedTermUrlResponse       ( ModelClassType TermUrlResponse TermUrlResponse TermUrlResponse Pointer )
            value.CachedConsentResponse                     = GetObject<ConsentResponse>(new IntPtr(p + 0x038), ReversePrism.DataModels.ConsentResponse.FromPointer); // 0x38 CachedConsentResponse       ( ModelClassType ConsentResponse ConsentResponse ConsentResponse Pointer )
            value.CurrentConsentStatus                      = (ConfirmConsentStatus)GetInt32(new IntPtr(p + 0x040)); // 0x40 CurrentConsentStatus        ( ModelEnumType ConfirmConsentStatus ConfirmConsentStatus ConfirmConsentStatus Int32 )

            return value;
        }
    }
}
