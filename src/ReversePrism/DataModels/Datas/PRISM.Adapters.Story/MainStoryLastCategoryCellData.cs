using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CellData                                 00018665C460 ModelClassType IStoryLastCategoryCellData IStoryLastCategoryCellData IStoryLastCategoryCellData Pointer
    public partial class MainStoryLastCategoryCellData
    {
        public IStoryLastCategoryCellData?              CellData                                { get; set; }

        public static MainStoryLastCategoryCellData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MainStoryLastCategoryCellData();

            value.CellData                                  = GetObject<IStoryLastCategoryCellData>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStoryLastCategoryCellData.FromPointer); // 0270D67BB840 0x10 CellData                    ( 00018665C460 ModelClassType IStoryLastCategoryCellData IStoryLastCategoryCellData IStoryLastCategoryCellData Pointer )

            return value;
        }
    }
}
