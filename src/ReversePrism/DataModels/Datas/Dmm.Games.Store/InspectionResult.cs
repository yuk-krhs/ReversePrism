using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Entry                                    ModelClassListType List`1<InspectionEntry> List`1<InspectionEntry> List<InspectionEntry> Pointer
    // 018 Data                                     ModelPrimitiveType string string string String
    public partial class InspectionResult : DataModel
    {
        public List<InspectionEntry>?                   Entry                                   { get; set; }
        public string                                   Data                                    { get; set; }

        public static InspectionResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InspectionResult() { Pointer= p0 };

            value.Entry                                     = GetObjectList<InspectionEntry>(new IntPtr(p + 0x010), ReversePrism.DataModels.InspectionEntry.FromPointer); // 0x10 Entry                       ( ModelClassListType List`1<InspectionEntry> List`1<InspectionEntry> List<InspectionEntry> Pointer )
            value.Data                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Data                        ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
