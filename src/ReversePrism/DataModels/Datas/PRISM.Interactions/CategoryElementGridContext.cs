using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 onClick                                  Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 048 onDetail                                 Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 050 CellViewType                             00018654F530 ModelEnumType CategoryElementGridCellViewType CategoryElementGridCellViewType CategoryElementGridCellViewType Int32
    // 058 ResourceLoader                           00018661A8D0 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class CategoryElementGridContext : DataModel
    {
        public CategoryElementGridCellViewType          CellViewType                            { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static CategoryElementGridContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CategoryElementGridContext() { Pointer= p0 };

            value.CellViewType                              = (CategoryElementGridCellViewType)GetInt32(new IntPtr(p + 0x050)); // 02466A353220 0x50 CellViewType                ( 00018654F530 ModelEnumType CategoryElementGridCellViewType CategoryElementGridCellViewType CategoryElementGridCellViewType Int32 )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x058), ReversePrism.DataModels.IResourceLoader.FromPointer); // 02466A353240 0x58 ResourceLoader              ( 00018661A8D0 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
