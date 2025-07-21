using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Currency                                 ModelPrimitiveType string string string String
    // 018 EventToken                               ModelPrimitiveType string string string String
    // 020 CallbackId                               ModelPrimitiveType string string string String
    // 028 TransactionId                            ModelPrimitiveType string string string String
    // 030 revenue                                  Nullable`1<double> IL2CPP_TYPE_GENERICINST
    // 040 PartnerList                              ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 048 CallbackList                             ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 050 Receipt                                  ModelPrimitiveType string string string String
    // 058 IsReceiptSet                             ModelPrimitiveType bool bool bool Bool
    public partial class AdjustEvent : DataModel
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
            var value   = new AdjustEvent() { Pointer= p0 };

            value.Currency                                  = GetString(new IntPtr(p + 0x010)); // 0x10 Currency                    ( ModelPrimitiveType string string string String )
            value.EventToken                                = GetString(new IntPtr(p + 0x018)); // 0x18 EventToken                  ( ModelPrimitiveType string string string String )
            value.CallbackId                                = GetString(new IntPtr(p + 0x020)); // 0x20 CallbackId                  ( ModelPrimitiveType string string string String )
            value.TransactionId                             = GetString(new IntPtr(p + 0x028)); // 0x28 TransactionId               ( ModelPrimitiveType string string string String )
            value.PartnerList                               = GetStringList(new IntPtr(p + 0x040)); // 0x40 PartnerList                 ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.CallbackList                              = GetStringList(new IntPtr(p + 0x048)); // 0x48 CallbackList                ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.Receipt                                   = GetString(new IntPtr(p + 0x050)); // 0x50 Receipt                     ( ModelPrimitiveType string string string String )
            value.IsReceiptSet                              = GetBool(new IntPtr(p + 0x058)); // 0x58 IsReceiptSet                ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
