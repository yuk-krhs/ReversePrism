using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MvName                                   0001866722E0 ModelPrimitiveType string string string String
    // 018 UnitID                                   0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class PMVData
    {
        public string                                   MvName                                  { get; set; }
        public int                                      UnitID                                  { get; set; }

        public static PMVData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PMVData();

            value.MvName                                    = GetString(new IntPtr(p + 0x010)); // 0270D4CE8A28 0x10 MvName                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.UnitID                                    = GetInt32(new IntPtr(p + 0x018)); // 0270D4CE8A48 0x18 UnitID                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
