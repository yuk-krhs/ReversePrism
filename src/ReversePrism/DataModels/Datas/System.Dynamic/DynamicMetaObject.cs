using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 EmptyMetaObjects                         DynamicMetaObject[] IL2CPP_TYPE_SZARRAY
    // 008 s_noValueSentinel                        <object> IL2CPP_TYPE_OBJECT
    // 010 _value                                   <object> IL2CPP_TYPE_OBJECT
    // 018 Expression                               0001865CF210 ModelClassType Expression Expression Expression Pointer
    // 020 Restrictions                             00018675E300 ModelClassType BindingRestrictions BindingRestrictions BindingRestrictions Pointer
    public partial class DynamicMetaObject : DataModel
    {
        public Expression?                              Expression                              { get; set; }
        public BindingRestrictions?                     Restrictions                            { get; set; }

        public static DynamicMetaObject? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DynamicMetaObject() { Pointer= p0 };

            value.Expression                                = GetObject<Expression>(new IntPtr(p + 0x018), ReversePrism.DataModels.Expression.FromPointer); // 024668780DD0 0x18 Expression                  ( 0001865CF210 ModelClassType Expression Expression Expression Pointer )
            value.Restrictions                              = GetObject<BindingRestrictions>(new IntPtr(p + 0x020), ReversePrism.DataModels.BindingRestrictions.FromPointer); // 024668780DF0 0x20 Restrictions                ( 00018675E300 ModelClassType BindingRestrictions BindingRestrictions BindingRestrictions Pointer )

            return value;
        }
    }
}
