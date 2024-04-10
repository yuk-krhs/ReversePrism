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
    // 038 NormalRateColmObjects                    000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 040 PromisedRateColmObjects                  000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 048 CellGameObjects                          000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    public partial class GashaOfferList : DataModel
    {
        public GameObject?                              GoTemplate                              { get; set; }
        public TableRowContent?                         Head                                    { get; set; }
        public Transform?                               RowRoot                                 { get; set; }
        public List<GameObject>?                        NormalRateColmObjects                   { get; set; }
        public List<GameObject>?                        PromisedRateColmObjects                 { get; set; }
        public List<GameObject>?                        CellGameObjects                         { get; set; }

        public static GashaOfferList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaOfferList() { Pointer= p0 };

            value.GoTemplate                                = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0246653C15D8 0x20 GoTemplate                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Head                                      = GetObject<TableRowContent>(new IntPtr(p + 0x028), ReversePrism.DataModels.TableRowContent.FromPointer); // 0246653C15F8 0x28 Head                        ( 00018661A200 ModelClassType TableRowContent TableRowContent TableRowContent Pointer )
            value.RowRoot                                   = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0246653C1618 0x30 RowRoot                     ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.NormalRateColmObjects                     = GetObjectList<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0246653C1638 0x38 NormalRateColmObjects       ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.PromisedRateColmObjects                   = GetObjectList<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0246653C1658 0x40 PromisedRateColmObjects     ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.CellGameObjects                           = GetObjectList<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0246653C1678 0x48 CellGameObjects             ( 000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )

            return value;
        }
    }
}
