using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     0001866722E0 ModelPrimitiveType string string string String
    // 018 Data                                     0001866722E0 ModelPrimitiveType string string string String
    // 020 Shape                                    000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    public partial class Feature
    {
        public string                                   Type                                    { get; set; }
        public string                                   Data                                    { get; set; }
        public List<int>?                               Shape                                   { get; set; }

        public static Feature? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Feature();

            value.Type                                      = GetString(new IntPtr(p + 0x010)); // 0270DBDC0180 0x10 Type                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Data                                      = GetString(new IntPtr(p + 0x018)); // 0270DBDC01A0 0x18 Data                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Shape                                     = GetInt32List(new IntPtr(p + 0x020)); // 0270DBDC01C0 0x20 Shape                       ( 000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
