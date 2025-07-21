using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 CellPrefab                               ModelClassType IntroductionCharacterSelectGridViewCell IntroductionCharacterSelectGridViewCell IntroductionCharacterSelectGridViewCell Pointer
    public partial class IntroductionCharacterSelectGridView : DataModel
    {
        public IntroductionCharacterSelectGridViewCell? CellPrefab                              { get; set; }

        public static IntroductionCharacterSelectGridView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionCharacterSelectGridView() { Pointer= p0 };

            value.CellPrefab                                = GetObject<IntroductionCharacterSelectGridViewCell>(new IntPtr(p + 0x090), ReversePrism.DataModels.IntroductionCharacterSelectGridViewCell.FromPointer); // 0x90 CellPrefab                  ( ModelClassType IntroductionCharacterSelectGridViewCell IntroductionCharacterSelectGridViewCell IntroductionCharacterSelectGridViewCell Pointer )

            return value;
        }
    }
}
