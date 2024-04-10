using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 DisplayIndex                             0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class SimpleDisplayIndexSaveDataBase : DataModel
    {
        public int                                      DisplayIndex                            { get; set; }

        public static SimpleDisplayIndexSaveDataBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SimpleDisplayIndexSaveDataBase() { Pointer= p0 };

            value.DisplayIndex                              = GetInt32(new IntPtr(p + 0x020)); // 0245A3A7B0D0 0x20 DisplayIndex                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
