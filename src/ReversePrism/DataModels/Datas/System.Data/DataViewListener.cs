using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DvWeak                                   ModelClassType WeakReference WeakReference WeakReference Pointer
    // 018 Table                                    ModelClassType DataTable DataTable DataTable Pointer
    // 020 Index                                    ModelClassType Index Index Index Pointer
    // 028 ObjectID                                 ModelPrimitiveType int int int Int32
    public partial class DataViewListener : DataModel
    {
        public WeakReference?                           DvWeak                                  { get; set; }
        public DataTable?                               Table                                   { get; set; }
        public Index?                                   Index                                   { get; set; }
        public int                                      ObjectID                                { get; set; }

        public static DataViewListener? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataViewListener() { Pointer= p0 };

            value.DvWeak                                    = GetObject<WeakReference>(new IntPtr(p + 0x010), ReversePrism.DataModels.WeakReference.FromPointer); // 0x10 DvWeak                      ( ModelClassType WeakReference WeakReference WeakReference Pointer )
            value.Table                                     = GetObject<DataTable>(new IntPtr(p + 0x018), ReversePrism.DataModels.DataTable.FromPointer); // 0x18 Table                       ( ModelClassType DataTable DataTable DataTable Pointer )
            value.Index                                     = GetObject<Index>(new IntPtr(p + 0x020), ReversePrism.DataModels.Index.FromPointer); // 0x20 Index                       ( ModelClassType Index Index Index Pointer )
            value.ObjectID                                  = GetInt32(new IntPtr(p + 0x028)); // 0x28 ObjectID                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
