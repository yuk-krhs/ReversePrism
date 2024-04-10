using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CurrentTabIndex                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 CurrentArchiveHeaderTabIndex             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 ArchiveVerticalNormalizedPosition        0001866656B0 ModelPrimitiveType float float float Single
    // 01C IsArchiveSortDown                        000186594D10 ModelPrimitiveType bool bool bool Bool
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

            value.CurrentTabIndex                           = GetInt32(new IntPtr(p + 0x010)); // 0246605CD200 0x10 CurrentTabIndex             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentArchiveHeaderTabIndex              = GetInt32(new IntPtr(p + 0x014)); // 0246605CD220 0x14 CurrentArchiveHeaderTabIndex ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ArchiveVerticalNormalizedPosition         = GetSingle(new IntPtr(p + 0x018)); // 0246605CD240 0x18 ArchiveVerticalNormalizedPosition ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.IsArchiveSortDown                         = GetBool(new IntPtr(p + 0x01C)); // 0246605CD260 0x1C IsArchiveSortDown           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
