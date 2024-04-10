using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ParentId                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 UxmlObjectAssets                         000185D1A758 ModelClassListType List`1<UxmlObjectAsset> List`1<UxmlObjectAsset> List<UxmlObjectAsset> Pointer
    public partial class UxmlObjectEntry : DataModel
    {
        public int                                      ParentId                                { get; set; }
        public List<UxmlObjectAsset>?                   UxmlObjectAssets                        { get; set; }

        public static UxmlObjectEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UxmlObjectEntry() { Pointer= p0 };

            value.ParentId                                  = GetInt32(new IntPtr(p + 0x010)); // 0245A6816028 0x10 ParentId                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.UxmlObjectAssets                          = GetObjectList<UxmlObjectAsset>(new IntPtr(p + 0x018), ReversePrism.DataModels.UxmlObjectAsset.FromPointer); // 0245A6816048 0x18 UxmlObjectAssets            ( 000185D1A758 ModelClassListType List`1<UxmlObjectAsset> List`1<UxmlObjectAsset> List<UxmlObjectAsset> Pointer )

            return value;
        }
    }
}
