using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Paths                                    0001866E2A00 ModelEnumType DllImportSearchPath DllImportSearchPath DllImportSearchPath Int32
    public partial class DefaultDllImportSearchPathsAttribute : DataModel
    {
        public DllImportSearchPath                      Paths                                   { get; set; }

        public static DefaultDllImportSearchPathsAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DefaultDllImportSearchPathsAttribute() { Pointer= p0 };

            value.Paths                                     = (DllImportSearchPath)GetInt32(new IntPtr(p + 0x010)); // 024666CF32E8 0x10 Paths                       ( 0001866E2A00 ModelEnumType DllImportSearchPath DllImportSearchPath DllImportSearchPath Int32 )

            return value;
        }
    }
}
