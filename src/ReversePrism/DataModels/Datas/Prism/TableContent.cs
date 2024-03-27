using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GoTemplate                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 Head                                     00018661A200 ModelClassType TableRowContent TableRowContent TableRowContent Pointer
    // 030 RowRoot                                  0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 038 Gos                                      000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    public partial class TableContent
    {
        public GameObject?                              GoTemplate                              { get; set; }
        public TableRowContent?                         Head                                    { get; set; }
        public Transform?                               RowRoot                                 { get; set; }
        public List<GameObject>?                        Gos                                     { get; set; }

        public static TableContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TableContent();

            value.GoTemplate                                = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4CC82A0 0x20 GoTemplate                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Head                                      = GetObject<TableRowContent>(new IntPtr(p + 0x028), ReversePrism.DataModels.TableRowContent.FromPointer); // 0270D4CC82C0 0x28 Head                        ( 00018661A200 ModelClassType TableRowContent TableRowContent TableRowContent Pointer )
            value.RowRoot                                   = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0270D4CC82E0 0x30 RowRoot                     ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.Gos                                       = GetObjectList<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4CC8300 0x38 Gos                         ( 000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )

            return value;
        }
    }
}
