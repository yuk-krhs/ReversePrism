using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Guid                                     ModelPrimitiveType string string string String
    // 030 Selector                                 ModelPrimitiveType string string string String
    // 038 Fields                                   ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 040 Count                                    ModelPrimitiveType int int int Int32
    // 044 StartIndex                               ModelPrimitiveType int int int Int32
    // 048 Filter                                   ModelClassType Filter Filter Filter Pointer
    public partial class PeopleParameter : DataModel
    {
        public string                                   Guid                                    { get; set; }
        public string                                   Selector                                { get; set; }
        public List<string>?                            Fields                                  { get; set; }
        public int                                      Count                                   { get; set; }
        public int                                      StartIndex                              { get; set; }
        public Filter?                                  Filter                                  { get; set; }

        public static PeopleParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PeopleParameter() { Pointer= p0 };

            value.Guid                                      = GetString(new IntPtr(p + 0x028)); // 0x28 Guid                        ( ModelPrimitiveType string string string String )
            value.Selector                                  = GetString(new IntPtr(p + 0x030)); // 0x30 Selector                    ( ModelPrimitiveType string string string String )
            value.Fields                                    = GetStringList(new IntPtr(p + 0x038)); // 0x38 Fields                      ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.Count                                     = GetInt32(new IntPtr(p + 0x040)); // 0x40 Count                       ( ModelPrimitiveType int int int Int32 )
            value.StartIndex                                = GetInt32(new IntPtr(p + 0x044)); // 0x44 StartIndex                  ( ModelPrimitiveType int int int Int32 )
            value.Filter                                    = GetObject<Filter>(new IntPtr(p + 0x048), ReversePrism.DataModels.Filter.FromPointer); // 0x48 Filter                      ( ModelClassType Filter Filter Filter Pointer )

            return value;
        }
    }
}
