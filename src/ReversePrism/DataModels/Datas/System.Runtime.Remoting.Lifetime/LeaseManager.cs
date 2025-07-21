using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Objects                                  ModelClassType ArrayList ArrayList ArrayList Pointer
    // 018 Timer                                    ModelClassType Timer Timer Timer Pointer
    public partial class LeaseManager : DataModel
    {
        public ArrayList?                               Objects                                 { get; set; }
        public Timer?                                   Timer                                   { get; set; }

        public static LeaseManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LeaseManager() { Pointer= p0 };

            value.Objects                                   = GetObject<ArrayList>(new IntPtr(p + 0x010), ReversePrism.DataModels.ArrayList.FromPointer); // 0x10 Objects                     ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.Timer                                     = GetObject<Timer>(new IntPtr(p + 0x018), ReversePrism.DataModels.Timer.FromPointer); // 0x18 Timer                       ( ModelClassType Timer Timer Timer Pointer )

            return value;
        }
    }
}
