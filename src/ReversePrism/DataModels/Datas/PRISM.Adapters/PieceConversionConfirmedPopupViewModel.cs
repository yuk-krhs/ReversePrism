using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SelectedIcons                            000185CF93B8 ModelClassListType List`1<PieceIcon> List`1<PieceIcon> List<PieceIcon> Pointer
    // 018 IsSurplus                                0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 020 BeforePoint                              0001865F8300 ModelPrimitiveType long long long Int64
    // 028 AfterPoint                               0001865F8300 ModelPrimitiveType long long long Int64
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

            value.SelectedIcons                             = GetObjectList<PieceIcon>(new IntPtr(p + 0x010), ReversePrism.DataModels.PieceIcon.FromPointer); // 024665F892F8 0x10 SelectedIcons               ( 000185CF93B8 ModelClassListType List`1<PieceIcon> List`1<PieceIcon> List<PieceIcon> Pointer )
            value.IsSurplus                                 = GetBool(new IntPtr(p + 0x018)); // 024665F89318 0x18 IsSurplus                   ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.BeforePoint                               = GetInt64(new IntPtr(p + 0x020)); // 024665F89338 0x20 BeforePoint                 ( 0001865F8300 ModelPrimitiveType long long long Int64 )
            value.AfterPoint                                = GetInt64(new IntPtr(p + 0x028)); // 024665F89358 0x28 AfterPoint                  ( 0001865F8300 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
