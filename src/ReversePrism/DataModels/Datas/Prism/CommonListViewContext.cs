using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SelectedIndex                            ModelPrimitiveType int int int Int32
    // 028 <OnCellClicked>k__BackingField           Action`1<int> IL2CPP_TYPE_GENERICINST
    // 030 <OnCellLongPressed>k__BackingField       Action`1<int> IL2CPP_TYPE_GENERICINST
    // 038 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class CommonListViewContext : DataModel
    {
        public int                                      SelectedIndex                           { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static CommonListViewContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CommonListViewContext() { Pointer= p0 };

            value.SelectedIndex                             = GetInt32(new IntPtr(p + 0x020)); // 0x20 SelectedIndex               ( ModelPrimitiveType int int int Int32 )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x038), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x38 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
