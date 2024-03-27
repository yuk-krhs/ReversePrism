using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Item                                     0001866B0920 ModelEnumType TreeItem TreeItem TreeItem Int32
    // 020 Depth                                    0001865F4940 ModelPrimitiveType int int int Int32
    public partial class TreeViewItemWrapper
    {
        public TreeItem                                 Item                                    { get; set; }
        public int                                      Depth                                   { get; set; }

        public static TreeViewItemWrapper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TreeViewItemWrapper();

            value.Item                                      = (TreeItem)GetInt32(new IntPtr(p + 0x010)); // 027006741018 0x10 Item                        ( 0001866B0920 ModelEnumType TreeItem TreeItem TreeItem Int32 )
            value.Depth                                     = GetInt32(new IntPtr(p + 0x020)); // 027006741038 0x20 Depth                       ( 0001865F4940 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
