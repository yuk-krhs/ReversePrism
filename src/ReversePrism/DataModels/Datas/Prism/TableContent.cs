using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GoTemplate                               ModelClassType GameObject GameObject GameObject Pointer
    // 028 Head                                     ModelClassType TableRowContent TableRowContent TableRowContent Pointer
    // 030 RowRoot                                  ModelClassType Transform Transform Transform Pointer
    // 038 Gos                                      ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    public partial class TableContent : DataModel
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
            var value   = new TableContent() { Pointer= p0 };

            value.GoTemplate                                = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 GoTemplate                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Head                                      = GetObject<TableRowContent>(new IntPtr(p + 0x028), ReversePrism.DataModels.TableRowContent.FromPointer); // 0x28 Head                        ( ModelClassType TableRowContent TableRowContent TableRowContent Pointer )
            value.RowRoot                                   = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0x30 RowRoot                     ( ModelClassType Transform Transform Transform Pointer )
            value.Gos                                       = GetObjectList<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 Gos                         ( ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )

            return value;
        }
    }
}
