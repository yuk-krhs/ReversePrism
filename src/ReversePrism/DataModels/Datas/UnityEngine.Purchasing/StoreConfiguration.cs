using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AndroidStore                             0001866CB330 ModelEnumType AppStore AppStore AppStore Int32
    public partial class StoreConfiguration : DataModel
    {
        public AppStore                                 AndroidStore                            { get; set; }

        public static StoreConfiguration? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoreConfiguration() { Pointer= p0 };

            value.AndroidStore                              = (AppStore)GetInt32(new IntPtr(p + 0x010)); // 0245A68DF460 0x10 AndroidStore                ( 0001866CB330 ModelEnumType AppStore AppStore AppStore Int32 )

            return value;
        }
    }
}
