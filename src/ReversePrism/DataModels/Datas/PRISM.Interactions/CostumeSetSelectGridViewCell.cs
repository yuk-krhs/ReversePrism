using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 CostumePuSetListView                     00018662DA00 ModelClassType CostumePUSetListView CostumePUSetListView CostumePUSetListView Pointer
    public partial class CostumeSetSelectGridViewCell : DataModel
    {
        public CostumePUSetListView?                    CostumePuSetListView                    { get; set; }

        public static CostumeSetSelectGridViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumeSetSelectGridViewCell() { Pointer= p0 };

            value.CostumePuSetListView                      = GetObject<CostumePUSetListView>(new IntPtr(p + 0x030), ReversePrism.DataModels.CostumePUSetListView.FromPointer); // 02466A2FA9D0 0x30 CostumePuSetListView        ( 00018662DA00 ModelClassType CostumePUSetListView CostumePUSetListView CostumePUSetListView Pointer )

            return value;
        }
    }
}
