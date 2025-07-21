using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Left                                     ModelClassType BindingRestrictions BindingRestrictions BindingRestrictions Pointer
    // 018 Right                                    ModelClassType BindingRestrictions BindingRestrictions BindingRestrictions Pointer
    public partial class MergedRestriction : DataModel
    {
        public BindingRestrictions?                     Left                                    { get; set; }
        public BindingRestrictions?                     Right                                   { get; set; }

        public static MergedRestriction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MergedRestriction() { Pointer= p0 };

            value.Left                                      = GetObject<BindingRestrictions>(new IntPtr(p + 0x010), ReversePrism.DataModels.BindingRestrictions.FromPointer); // 0x10 Left                        ( ModelClassType BindingRestrictions BindingRestrictions BindingRestrictions Pointer )
            value.Right                                     = GetObject<BindingRestrictions>(new IntPtr(p + 0x018), ReversePrism.DataModels.BindingRestrictions.FromPointer); // 0x18 Right                       ( ModelClassType BindingRestrictions BindingRestrictions BindingRestrictions Pointer )

            return value;
        }
    }
}
