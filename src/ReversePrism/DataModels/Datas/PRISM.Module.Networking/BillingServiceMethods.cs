using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ReserveStoreItem                         Method`2<IReserveStoreItemArgs, IReserveStoreItemReply> IL2CPP_TYPE_GENERICINST
    // 018 VerifyReceiptForDevelop                  Method`2<IVerifyReceiptForDevelopArgs, IVerifyReceiptForDevelopReply> IL2CPP_TYPE_GENERICINST
    // 030 VerifyReceiptForAppStore                 Method`2<IVerifyReceiptForAppStoreArgs, IVerifyReceiptForAppStoreReply> IL2CPP_TYPE_GENERICINST
    // 048 VerifyReceiptForGooglePlay               Method`2<IVerifyReceiptForGooglePlayArgs, IVerifyReceiptForGooglePlayReply> IL2CPP_TYPE_GENERICINST
    // 060 VerifyReceiptForDmmGames                 Method`2<IVerifyReceiptForDmmGamesArgs, IVerifyReceiptForDmmGamesReply> IL2CPP_TYPE_GENERICINST
    // 078 GetOrderResult                           Method`2<IGetOrderResultArgs, IGetOrderResultReply> IL2CPP_TYPE_GENERICINST
    // 090 RegisterBillingBirthdate                 Method`2<IRegisterBillingBirthdateArgs, IRegisterBillingBirthdateReply> IL2CPP_TYPE_GENERICINST
    public partial class BillingServiceMethods
    {

        public static BillingServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BillingServiceMethods();


            return value;
        }
    }
}
