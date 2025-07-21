using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 User_id                                  ModelPrimitiveType int int int Int32
    // 018 Details                                  ModelClassListType List`1<Detail> List`1<Detail> List<Detail> Pointer
    public partial class Result : DataModel
    {
        public int                                      User_id                                 { get; set; }
        public List<Detail>?                            Details                                 { get; set; }

        public static Result? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Result() { Pointer= p0 };

            value.User_id                                   = GetInt32(new IntPtr(p + 0x010)); // 0x10 User_id                     ( ModelPrimitiveType int int int Int32 )
            value.Details                                   = GetObjectList<Detail>(new IntPtr(p + 0x018), ReversePrism.DataModels.Detail.FromPointer); // 0x18 Details                     ( ModelClassListType List`1<Detail> List`1<Detail> List<Detail> Pointer )

            return value;
        }
    }
}
