using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<PurchaseLimitStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 CountResetTimingTypeFieldNumber          int IL2CPP_TYPE_I4
    // 018 CountResetTimingType                     0001865D9F70 ModelEnumType PurchaseCountResetTimingType PurchaseCountResetTimingType PurchaseCountResetTimingType Int32
    // 000 LimitCountFieldNumber                    int IL2CPP_TYPE_I4
    // 01C LimitCount                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 CurrentCountFieldNumber                  int IL2CPP_TYPE_I4
    // 020 CurrentCount                             0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class PurchaseLimitStatus
    {
        public PurchaseCountResetTimingType             CountResetTimingType                    { get; set; }
        public int                                      LimitCount                              { get; set; }
        public int                                      CurrentCount                            { get; set; }

        public static PurchaseLimitStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PurchaseLimitStatus();

            value.CountResetTimingType                      = (PurchaseCountResetTimingType)GetInt32(new IntPtr(p + 0x018)); // 0270D10D32A0 0x18 CountResetTimingType        ( 0001865D9F70 ModelEnumType PurchaseCountResetTimingType PurchaseCountResetTimingType PurchaseCountResetTimingType Int32 )
            value.LimitCount                                = GetInt32(new IntPtr(p + 0x01C)); // 0270D10D32E0 0x1C LimitCount                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentCount                              = GetInt32(new IntPtr(p + 0x020)); // 0270D10D3320 0x20 CurrentCount                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
