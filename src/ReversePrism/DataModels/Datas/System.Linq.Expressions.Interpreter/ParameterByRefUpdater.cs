using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Parameter                                000186609A60 ModelClassType LocalVariable LocalVariable LocalVariable Pointer
    public partial class ParameterByRefUpdater : DataModel
    {
        public LocalVariable?                           Parameter                               { get; set; }

        public static ParameterByRefUpdater? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ParameterByRefUpdater() { Pointer= p0 };

            value.Parameter                                 = GetObject<LocalVariable>(new IntPtr(p + 0x018), ReversePrism.DataModels.LocalVariable.FromPointer); // 02466A070340 0x18 Parameter                   ( 000186609A60 ModelClassType LocalVariable LocalVariable LocalVariable Pointer )

            return value;
        }
    }
}
