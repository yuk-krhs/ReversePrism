using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Dish                                     0001866E3F10 ModelClassType LoadingPriorityDish LoadingPriorityDish LoadingPriorityDish Pointer
    // 000 stack                                    ActivationStack`1<LoadingPriorityDish> IL2CPP_TYPE_GENERICINST
    public partial class LoadingPriorityScope : DataModel
    {
        public LoadingPriorityDish?                     Dish                                    { get; set; }

        public static LoadingPriorityScope? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoadingPriorityScope() { Pointer= p0 };

            value.Dish                                      = GetObject<LoadingPriorityDish>(new IntPtr(p + 0x010), ReversePrism.DataModels.LoadingPriorityDish.FromPointer); // 02466B732DD0 0x10 Dish                        ( 0001866E3F10 ModelClassType LoadingPriorityDish LoadingPriorityDish LoadingPriorityDish Pointer )

            return value;
        }
    }
}
