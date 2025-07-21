using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SelectedIcons                            ModelClassListType List`1<PieceIcon> List`1<PieceIcon> List<PieceIcon> Pointer
    // 018 IsSurplus                                ModelPrimitiveType bool bool bool Bool
    // 020 BeforePoint                              ModelPrimitiveType long long long Int64
    // 028 AfterPoint                               ModelPrimitiveType long long long Int64
    public partial class PieceConversionConfirmedPopupViewModel : DataModel
    {
        public List<PieceIcon>?                         SelectedIcons                           { get; set; }
        public bool                                     IsSurplus                               { get; set; }
        public long                                     BeforePoint                             { get; set; }
        public long                                     AfterPoint                              { get; set; }

        public static PieceConversionConfirmedPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PieceConversionConfirmedPopupViewModel() { Pointer= p0 };

            value.SelectedIcons                             = GetObjectList<PieceIcon>(new IntPtr(p + 0x010), ReversePrism.DataModels.PieceIcon.FromPointer); // 0x10 SelectedIcons               ( ModelClassListType List`1<PieceIcon> List`1<PieceIcon> List<PieceIcon> Pointer )
            value.IsSurplus                                 = GetBool(new IntPtr(p + 0x018)); // 0x18 IsSurplus                   ( ModelPrimitiveType bool bool bool Bool )
            value.BeforePoint                               = GetInt64(new IntPtr(p + 0x020)); // 0x20 BeforePoint                 ( ModelPrimitiveType long long long Int64 )
            value.AfterPoint                                = GetInt64(new IntPtr(p + 0x028)); // 0x28 AfterPoint                  ( ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
