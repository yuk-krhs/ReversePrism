using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Details                                  Dictionary`2<int, string> IL2CPP_TYPE_GENERICINST
    // 010 Reason                                   ModelEnumType PurchaseFailureReason PurchaseFailureReason PurchaseFailureReason Int32
    // 018 ProductDefinition                        ModelClassType ProductDefinition ProductDefinition ProductDefinition Pointer
    // 020 Kind                                     ModelPrimitiveType string string string String
    // 028 Code                                     ModelPrimitiveType int int int Int32
    // 030 Message                                  ModelPrimitiveType string string string String
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

            value.Reason                                    = (PurchaseFailureReason)GetInt32(new IntPtr(p + 0x010)); // 0x10 Reason                      ( ModelEnumType PurchaseFailureReason PurchaseFailureReason PurchaseFailureReason Int32 )
            value.ProductDefinition                         = GetObject<ProductDefinition>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProductDefinition.FromPointer); // 0x18 ProductDefinition           ( ModelClassType ProductDefinition ProductDefinition ProductDefinition Pointer )
            value.Kind                                      = GetString(new IntPtr(p + 0x020)); // 0x20 Kind                        ( ModelPrimitiveType string string string String )
            value.Code                                      = GetInt32(new IntPtr(p + 0x028)); // 0x28 Code                        ( ModelPrimitiveType int int int Int32 )
            value.Message                                   = GetString(new IntPtr(p + 0x030)); // 0x30 Message                     ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
