using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Currency                                 000186671BA0 ModelPrimitiveType string string string String
    // 018 EventToken                               000186671BA0 ModelPrimitiveType string string string String
    // 020 CallbackId                               000186671BA0 ModelPrimitiveType string string string String
    // 028 TransactionId                            000186671BA0 ModelPrimitiveType string string string String
    // 030 revenue                                  Nullable`1<double> IL2CPP_TYPE_GENERICINST
    // 040 PartnerList                              000185D0D578 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 048 CallbackList                             000185D0D578 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 050 Receipt                                  000186671BA0 ModelPrimitiveType string string string String
    // 058 IsReceiptSet                             000186595210 ModelPrimitiveType bool bool bool Bool
    public partial class AdjustEvent
    {
        public string                                   Currency                                { get; set; }
        public string                                   EventToken                              { get; set; }
        public string                                   CallbackId                              { get; set; }
        public string                                   TransactionId                           { get; set; }
        public List<string>?                            PartnerList                             { get; set; }
        public List<string>?                            CallbackList                            { get; set; }
        public string                                   Receipt                                 { get; set; }
        public bool                                     IsReceiptSet                            { get; set; }

        public static AdjustEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdjustEvent();

            value.Currency                                  = GetString(new IntPtr(p + 0x010)); // 0270DBB0D450 0x10 Currency                    ( 000186671BA0 ModelPrimitiveType string string string String )
            value.EventToken                                = GetString(new IntPtr(p + 0x018)); // 0270DBB0D470 0x18 EventToken                  ( 000186671BA0 ModelPrimitiveType string string string String )
            value.CallbackId                                = GetString(new IntPtr(p + 0x020)); // 0270DBB0D490 0x20 CallbackId                  ( 000186671BA0 ModelPrimitiveType string string string String )
            value.TransactionId                             = GetString(new IntPtr(p + 0x028)); // 0270DBB0D4B0 0x28 TransactionId               ( 000186671BA0 ModelPrimitiveType string string string String )
            value.PartnerList                               = GetStringList(new IntPtr(p + 0x040)); // 0270DBB0D4F0 0x40 PartnerList                 ( 000185D0D578 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.CallbackList                              = GetStringList(new IntPtr(p + 0x048)); // 0270DBB0D510 0x48 CallbackList                ( 000185D0D578 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.Receipt                                   = GetString(new IntPtr(p + 0x050)); // 0270DBB0D530 0x50 Receipt                     ( 000186671BA0 ModelPrimitiveType string string string String )
            value.IsReceiptSet                              = GetBool(new IntPtr(p + 0x058)); // 0270DBB0D550 0x58 IsReceiptSet                ( 000186595210 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
