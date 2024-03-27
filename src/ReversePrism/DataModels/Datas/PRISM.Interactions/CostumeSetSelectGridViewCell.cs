using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 CostumePuSetListView                     00018662DA00 ModelClassType CostumePUSetListView CostumePUSetListView CostumePUSetListView Pointer
    public partial class CostumeSetSelectGridViewCell
    {
        public CostumePUSetListView?                    CostumePuSetListView                    { get; set; }

        public static CostumeSetSelectGridViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumeSetSelectGridViewCell();

            value.CostumePuSetListView                      = GetObject<CostumePUSetListView>(new IntPtr(p + 0x030), ReversePrism.DataModels.CostumePUSetListView.FromPointer); // 0270DA2A73E8 0x30 CostumePuSetListView        ( 00018662DA00 ModelClassType CostumePUSetListView CostumePUSetListView CostumePUSetListView Pointer )

            return value;
        }
    }
}
