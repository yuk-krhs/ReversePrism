using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_ReserveStoreItemArgs    Marshaller`1<ReserveStoreItemArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_ReserveStoreItemReply   Marshaller`1<ReserveStoreItemReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_VerifyReceiptForDevelopArgs Marshaller`1<VerifyReceiptForDevelopArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_VerifyReceiptForDevelopReply Marshaller`1<VerifyReceiptForDevelopReply> IL2CPP_TYPE_GENERICINST
    // 028 __Marshaller_api_VerifyReceiptForAppStoreArgs Marshaller`1<VerifyReceiptForAppStoreArgs> IL2CPP_TYPE_GENERICINST
    // 030 __Marshaller_api_VerifyReceiptForAppStoreReply Marshaller`1<VerifyReceiptForAppStoreReply> IL2CPP_TYPE_GENERICINST
    // 038 __Marshaller_api_VerifyReceiptForGooglePlayArgs Marshaller`1<VerifyReceiptForGooglePlayArgs> IL2CPP_TYPE_GENERICINST
    // 040 __Marshaller_api_VerifyReceiptForGooglePlayReply Marshaller`1<VerifyReceiptForGooglePlayReply> IL2CPP_TYPE_GENERICINST
    // 048 __Marshaller_api_VerifyReceiptForDmmGamesArgs Marshaller`1<VerifyReceiptForDmmGamesArgs> IL2CPP_TYPE_GENERICINST
    // 050 __Marshaller_api_VerifyReceiptForDmmGamesReply Marshaller`1<VerifyReceiptForDmmGamesReply> IL2CPP_TYPE_GENERICINST
    // 058 __Marshaller_api_GetOrderResultArgs      Marshaller`1<GetOrderResultArgs> IL2CPP_TYPE_GENERICINST
    // 060 __Marshaller_api_GetOrderResultReply     Marshaller`1<GetOrderResultReply> IL2CPP_TYPE_GENERICINST
    // 068 __Marshaller_api_RegisterBillingBirthdateArgs Marshaller`1<RegisterBillingBirthdateArgs> IL2CPP_TYPE_GENERICINST
    // 070 __Marshaller_api_RegisterBillingBirthdateReply Marshaller`1<RegisterBillingBirthdateReply> IL2CPP_TYPE_GENERICINST
    // 078 __Method_ReserveStoreItem                Method`2<ReserveStoreItemArgs, ReserveStoreItemReply> IL2CPP_TYPE_GENERICINST
    // 080 __Method_VerifyReceiptForDevelop         Method`2<VerifyReceiptForDevelopArgs, VerifyReceiptForDevelopReply> IL2CPP_TYPE_GENERICINST
    // 088 __Method_VerifyReceiptForAppStore        Method`2<VerifyReceiptForAppStoreArgs, VerifyReceiptForAppStoreReply> IL2CPP_TYPE_GENERICINST
    // 090 __Method_VerifyReceiptForGooglePlay      Method`2<VerifyReceiptForGooglePlayArgs, VerifyReceiptForGooglePlayReply> IL2CPP_TYPE_GENERICINST
    // 098 __Method_VerifyReceiptForDmmGames        Method`2<VerifyReceiptForDmmGamesArgs, VerifyReceiptForDmmGamesReply> IL2CPP_TYPE_GENERICINST
    // 0A0 __Method_GetOrderResult                  Method`2<GetOrderResultArgs, GetOrderResultReply> IL2CPP_TYPE_GENERICINST
    // 0A8 __Method_RegisterBillingBirthdate        Method`2<RegisterBillingBirthdateArgs, RegisterBillingBirthdateReply> IL2CPP_TYPE_GENERICINST
    public partial class BillingService : DataModel
    {

        public static BillingService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BillingService() { Pointer= p0 };


            return value;
        }
    }
}
