using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Details                                  Dictionary`2<int, string> IL2CPP_TYPE_GENERICINST
    // 010 Reason                                   0001865DBE10 ModelEnumType PurchaseFailureReason PurchaseFailureReason PurchaseFailureReason Int32
    // 018 ProductDefinition                        0001865A0170 ModelClassType ProductDefinition ProductDefinition ProductDefinition Pointer
    // 020 Kind                                     000186671910 ModelPrimitiveType string string string String
    // 028 Code                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 Message                                  000186671910 ModelPrimitiveType string string string String
    public partial class ErrorObject : DataModel
    {
        public PurchaseFailureReason                    Reason                                  { get; set; }
        public ProductDefinition?                       ProductDefinition                       { get; set; }
        public string                                   Kind                                    { get; set; }
        public int                                      Code                                    { get; set; }
        public string                                   Message                                 { get; set; }

        public static ErrorObject? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ErrorObject() { Pointer= p0 };

            value.Reason                                    = (PurchaseFailureReason)GetInt32(new IntPtr(p + 0x010)); // 02466B4E74A8 0x10 Reason                      ( 0001865DBE10 ModelEnumType PurchaseFailureReason PurchaseFailureReason PurchaseFailureReason Int32 )
            value.ProductDefinition                         = GetObject<ProductDefinition>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProductDefinition.FromPointer); // 02466B4E74C8 0x18 ProductDefinition           ( 0001865A0170 ModelClassType ProductDefinition ProductDefinition ProductDefinition Pointer )
            value.Kind                                      = GetString(new IntPtr(p + 0x020)); // 02466B4E74E8 0x20 Kind                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Code                                      = GetInt32(new IntPtr(p + 0x028)); // 02466B4E7508 0x28 Code                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Message                                   = GetString(new IntPtr(p + 0x030)); // 02466B4E7528 0x30 Message                     ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
