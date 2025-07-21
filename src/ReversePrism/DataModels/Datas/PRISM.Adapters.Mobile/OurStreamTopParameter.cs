using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CurrentTabIndex                          ModelPrimitiveType int int int Int32
    // 014 CurrentArchiveHeaderTabIndex             ModelPrimitiveType int int int Int32
    // 018 ArchiveVerticalNormalizedPosition        ModelPrimitiveType float float float Single
    // 01C IsArchiveSortDown                        ModelPrimitiveType bool bool bool Bool
    public partial class OurStreamTopParameter : DataModel
    {
        public int                                      CurrentTabIndex                         { get; set; }
        public int                                      CurrentArchiveHeaderTabIndex            { get; set; }
        public float                                    ArchiveVerticalNormalizedPosition       { get; set; }
        public bool                                     IsArchiveSortDown                       { get; set; }

        public static OurStreamTopParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamTopParameter() { Pointer= p0 };

            value.CurrentTabIndex                           = GetInt32(new IntPtr(p + 0x010)); // 0x10 CurrentTabIndex             ( ModelPrimitiveType int int int Int32 )
            value.CurrentArchiveHeaderTabIndex              = GetInt32(new IntPtr(p + 0x014)); // 0x14 CurrentArchiveHeaderTabIndex ( ModelPrimitiveType int int int Int32 )
            value.ArchiveVerticalNormalizedPosition         = GetSingle(new IntPtr(p + 0x018)); // 0x18 ArchiveVerticalNormalizedPosition ( ModelPrimitiveType float float float Single )
            value.IsArchiveSortDown                         = GetBool(new IntPtr(p + 0x01C)); // 0x1C IsArchiveSortDown           ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
