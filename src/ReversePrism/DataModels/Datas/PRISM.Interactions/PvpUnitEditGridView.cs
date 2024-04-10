using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 CellPrefab                               0001865F62B0 ModelClassType PvpUnitEditGridViewCell PvpUnitEditGridViewCell PvpUnitEditGridViewCell Pointer
    public partial class PvpUnitEditGridView : DataModel
    {
        public PvpUnitEditGridViewCell?                 CellPrefab                              { get; set; }

        public static PvpUnitEditGridView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpUnitEditGridView() { Pointer= p0 };

            value.CellPrefab                                = GetObject<PvpUnitEditGridViewCell>(new IntPtr(p + 0x090), ReversePrism.DataModels.PvpUnitEditGridViewCell.FromPointer); // 02466A1A6E18 0x90 CellPrefab                  ( 0001865F62B0 ModelClassType PvpUnitEditGridViewCell PvpUnitEditGridViewCell PvpUnitEditGridViewCell Pointer )

            return value;
        }
    }
}
