using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Buffer                                 ModelClassType IBuffer IBuffer IBuffer Pointer
    public partial class DataGenerator : DataModel
    {
        public IBuffer?                                 M_Buffer                                { get; set; }

        public static DataGenerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataGenerator() { Pointer= p0 };

            value.M_Buffer                                  = GetObject<IBuffer>(new IntPtr(p + 0x010), ReversePrism.DataModels.IBuffer.FromPointer); // 0x10 M_Buffer                    ( ModelClassType IBuffer IBuffer IBuffer Pointer )

            return value;
        }
    }
}
