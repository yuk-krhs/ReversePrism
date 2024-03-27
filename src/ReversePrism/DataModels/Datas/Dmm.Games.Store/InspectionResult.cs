using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Entry                                    000185CEC818 ModelClassListType List`1<InspectionEntry> List`1<InspectionEntry> List<InspectionEntry> Pointer
    // 018 Data                                     0001866722E0 ModelPrimitiveType string string string String
    public partial class InspectionResult
    {
        public List<InspectionEntry>?                   Entry                                   { get; set; }
        public string                                   Data                                    { get; set; }

        public static InspectionResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InspectionResult();

            value.Entry                                     = GetObjectList<InspectionEntry>(new IntPtr(p + 0x010), ReversePrism.DataModels.InspectionEntry.FromPointer); // 0270DB4BC108 0x10 Entry                       ( 000185CEC818 ModelClassListType List`1<InspectionEntry> List`1<InspectionEntry> List<InspectionEntry> Pointer )
            value.Data                                      = GetString(new IntPtr(p + 0x018)); // 0270DB4BC128 0x18 Data                        ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
